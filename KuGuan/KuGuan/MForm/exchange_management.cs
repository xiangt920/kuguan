using KuGuan.Model;
using KuGuan.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class exchange_management : DockContent
    {

        private choose_stock P = new choose_stock(true);
        private StoreForm S = new StoreForm(true);
        private bool CellValueTrue = true;
        private DataGridViewCell ErrorCell = null;
        private choose_customer C = new choose_customer();
        private List<kuguanDataSet.product_stockRow> willRows = new List<kuguanDataSet.product_stockRow>();
        private kuguanDataSetTableAdapters.TableAdapterManager manager;
        private kuguanDataSetTableAdapters.exchangeTableAdapter exchangeAdapter = new kuguanDataSetTableAdapters.exchangeTableAdapter();
        private kuguanDataSetTableAdapters.stockTableAdapter stockAdapter = new kuguanDataSetTableAdapters.stockTableAdapter();
        private kuguanDataSetTableAdapters.remainTableAdapter remainAdapter = new kuguanDataSetTableAdapters.remainTableAdapter();

        public exchange_management()
        {
            InitializeComponent();

            manager = new kuguanDataSetTableAdapters.TableAdapterManager();
            manager.BackupDataSetBeforeUpdate = false;
            manager.customer_typeTableAdapter = null;
            manager.stockTableAdapter = stockAdapter;
            manager.proTableAdapter = null;
            manager.customerTableAdapter = null;
            manager.supplier_typeTableAdapter = null;
            manager.supplierTableAdapter = null;
            manager.unitTableAdapter = null;
            manager.UpdateOrder = KuGuan.kuguanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            manager.userTableAdapter = null;
            manager.storageTableAdapter = null;
            manager.outTableAdapter = null;
            manager.exchangeTableAdapter = exchangeAdapter;
            manager.remainTableAdapter = remainAdapter;
            manager.accountTableAdapter = accountTableAdapter;
        }
        
        private void choose_product()
        {
            if (P.ShowDialog() == DialogResult.OK)
            {
                outstoreBox.Text = P.Store;
                proView.Rows.Clear();
                String t = "";
                foreach (kuguanDataSet.product_stockRow row in P.SelectedRows)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(proView, new object[] {row.product_id,row.product_name,row.stock_num,row.stock_num });
                    if (!t.Contains(row.product_type))
                        t += row.product_type + ";";

                    proView.Rows.Add(r);
                }
                outengBox.Text = t;
            }
        }

        private void exchange_management_Load(object sender, EventArgs e)
        {
            stockAdapter.Fill(this.dataDataSet.stock);
            string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(date));
            new_id++;
            oIdBox.Text = new_id.ToString();
        }

        private void show_on_list(object sender, EventArgs e)
        {
            if (proView.Rows.Count == 0)
            {
                MessageBox.Show("请您选择需要调整的货品！");
                return;
            }
            if (instoreBox.Text == "")
            {
                MessageBox.Show("请您选择调入仓库！");
                return;
            }
            foreach (kuguanDataSet.product_stockRow r in P.SelectedRows)
            {
                if (r.product_type_id == S.Id)
                {
                    MessageBox.Show("编号为" + r.product_id + "的产品调出仓库与调入仓库冲突");
                    return;
                }
            }
            try
            {
                
                foreach (kuguanDataSet.product_stockRow r in P.SelectedRows)
                {
                    KuGuan.kuguanDataSet.exchange_managementRow row = (kuguanDataSet.exchange_managementRow)this.dataDataSet.exchange_management.NewRow();
                    row.BeginEdit();
                    row.time = datePicker.Value;
                    row.from_house_id = r.product_type_id;
                    row.to_house_id = S.Id;
                    row.from_eng = r.product_type;
                    row.to_eng = S.SName;
                    row.product_id = r.product_id;
                    row.product_name = r.product_name;
                    row.unit_id = r.unit_id;
                    row.unit = r.unit;
                    row.spec = r.spec;
                    var num = from DataGridViewRow r0 in proView.Rows
                              where (int)r0.Cells["ProIdCol"].Value == r.product_id
                              select Decimal.Parse(r0.Cells["NumCol"].Value+"");
                    row.exchange_num = num.ElementAt(0);
                    if (getPriceButton.Checked)
                    {
                        row.price = r.get_price;
                        row.total_price = Decimal.Round(r.get_price * num.ElementAt(0),11);
                    }
                    else
                    {
                        row.price = r.out_price;
                        row.total_price = Decimal.Round(r.out_price * num.ElementAt(0),11);
                    }
                    row.EndEdit();
                    if(!willRows.Contains(r))
                        willRows.Add(r);
                    this.dataDataSet.exchange_management.Addexchange_managementRow(row);
                    var rs = from kuguanDataSet.exchange_managementRow r0 in dataDataSet.exchange_management.Rows
                             select r0;
                    sumBox.Text = rs.Sum(r1 => r1.exchange_num) + "";
                    amountBox.Text = Decimal.Round(rs.Sum(r1 => r1.total_price), 2) + "";
                }
            }
            catch (System.Exception)
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.dataDataSet.exchange_management.Rows.Clear();
            willRows.Clear();
            sumBox.Text = "0";
            amountBox.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = this.exchangeDocView.SelectedCells[0].RowIndex;
                exchangeDocView.Rows.RemoveAt(row_index);
                var rs = from kuguanDataSet.exchange_managementRow r0 in dataDataSet.exchange_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.exchange_num) + "";
                amountBox.Text = Decimal.Round(rs.Sum(r1 => r1.total_price), 2) + "";
                
            }
            catch (System.Exception)
            {

            }
        }

        private void dateTimePicker1_TabIndexChanged(object sender, EventArgs e)
        {
            kuguanDataSetTableAdapters.accountTableAdapter ata = new kuguanDataSetTableAdapters.accountTableAdapter();
            int? count = ata.Get0CountFromTime(datePicker.Value);
            if (count > 0)
            {
                MessageBox.Show(this, "该日期已结账，不可调库！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePicker.Value = DateTime.Now;
                return;
            }
            try
            {
                string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
                Decimal new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(date)) + 1;
                oIdBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Util.deleteBak();
            try
            {
                File.Copy(@"data\kuguan.sdf", @"data\kuguan.esdf.obak", true);
                undoButton.Enabled = true;
            }
            catch { }
            int count = 0;
            if (this.dataDataSet.exchange_management.Rows.Count == 0)
                return;
            List<KuGuan.kuguanDataSet.exchange_managementRow> successedRows = new List<kuguanDataSet.exchange_managementRow>();
            string exchangeId = oIdBox.Text;
            ISet<int> failedIdList = new SortedSet<int>();
            this.dataDataSet.exchange.Rows.Clear();
            this.dataDataSet.account.Rows.Clear();
            stockAdapter.Fill(this.dataDataSet.stock);
            remainAdapter.Fill(this.dataDataSet.remain);
            DateTime tmp = datePicker.Value.Date;
            foreach (KuGuan.kuguanDataSet.exchange_managementRow row in this.dataDataSet.exchange_management.Rows)
            {
                kuguanDataSet.stockRow r0 = DBUtil.changeStock(row.product_id, row.from_house_id, -row.exchange_num,row.price,-row.total_price, this.dataDataSet.stock);
                kuguanDataSet.stockRow r1 = DBUtil.changeStock(row.product_id, row.to_house_id, row.exchange_num, row.price, row.total_price, this.dataDataSet.stock);
                this.dataDataSet.exchange.AddexchangeRow(
                    exchangeId,
                    tmp,
                    row.product_id,
                    row.exchange_num,
                    row.from_house_id,
                    row.to_house_id,
                    outpriceButton.Checked,
                    r0.stock_num,
                    r0.stock_amount,
                    r1.stock_num,
                    r1.stock_amount,
                    row.price);
                this.dataDataSet.account.AddaccountRow(
                    row.product_id, row.from_house_id, tmp,
                    exchangeId,
                    "从" + row.from_eng +
                    "调至" + row.to_eng,
                    0, 0, 0, row.exchange_num, row.price, row.total_price, "",
                    r0.stock_num, r0.stock_num == 0 ? 0 : Decimal.Round(r0.stock_amount / r0.stock_num, 11),
                    r0.stock_amount, 3);
                this.dataDataSet.account.AddaccountRow(
                    row.product_id, row.to_house_id, tmp,
                    exchangeId,
                    "从 " + row.from_eng +
                    "调至 " + row.to_eng,
                    row.exchange_num, row.price, row.total_price, 0, 0, 0,"",
                    r1.stock_num, r1.stock_num == 0 ? 0 : Decimal.Round(r1.stock_amount / r1.stock_num, 11),
                    r1.stock_amount, 3);
                count++;

                successedRows.Add(row);
            }

            manager.UpdateAll(this.dataDataSet);
            if (count == this.dataDataSet.exchange_management.Rows.Count)
            {
                MessageBox.Show("成功调库所有信息("+count+"条)！");
                printDGV();
                this.dataDataSet.exchange_management.Rows.Clear();
                willRows.Clear();
                sumBox.Text = "0";
                amountBox.Text = "0";
            }
            else
            {
                MessageBox.Show("提交调库信息条数:" + this.dataDataSet.exchange_management.Rows.Count
                    + "\n成功调库信息条数:" + count);
                foreach (KuGuan.kuguanDataSet.exchange_managementRow r in successedRows)
                {
                    this.dataDataSet.exchange_management.Rows.Remove(r);
                }

                var rs = from kuguanDataSet.exchange_managementRow r0 in dataDataSet.exchange_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.exchange_num) + "";
                amountBox.Text = Decimal.Round(rs.Sum(r1 => r1.total_price), 2) + "";
                willRows.RemoveAll(r0 => !failedIdList.Contains(r0.product_id));
            }
            string date = datePicker.Value.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(date)) + 1;
            oIdBox.Text = new_id.ToString();
        }

        private void exchange_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dataDataSet.exchange_management.Rows.Count > 0)
            {
                if (MessageBox.Show(
                    "还有" + this.dataDataSet.exchange_management.Rows.Count + "调库信息尚未提交，确定放弃？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
            try
            {
                File.Delete(@"data\kuguan.sdf.ebak");
            }
            catch { }
        }

        private void instoreBox_Click(object sender, EventArgs e)
        {
            if (S.ShowDialog() == DialogResult.OK)
            {
                instoreBox.Text = S.ParentName;
                inengBox.Text = S.SName;
            }
        }

        private void proView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == NumCol.Index)
            {
                DataGridViewCell c = proView.CurrentCell;
                string s = c.Value+"";
                if (!isNum(s))
                {
                    CellValueTrue = false;
                    MessageBox.Show("数量格式不正确，请输入小数点位数为5位一下的正确数字！");
                    foreach (DataGridViewRow r in proView.Rows)
                        r.Selected = false;
                    c.Selected = true;
                    proView.CurrentCell = c;
                    ErrorCell = c;
                    c.Value = c.OwningRow.Cells["StockCol"].Value;
                }
                else
                {
                    CellValueTrue = true;
                    ErrorCell = null;
                }
            }
        }

        private bool isNum(string s)
        {
            Regex reg = new Regex("^\\d+(\\.\\d{1,5})?$");
            return reg.IsMatch(s);
        }

        private void proView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!CellValueTrue)
            {
                if (proView.CurrentCell != ErrorCell)
                {
                    e.Cancel = true;
                    proView.CurrentCell = ErrorCell;
                    proView.BeginEdit(true);
                }
            }
        }

        private void proView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != NumCol.Index)
                choose_product();
        }

        private void proView_MouseClick(object sender, MouseEventArgs e)
        {
            int width = 0;
            int height = proView.ColumnHeadersHeight;
            foreach(DataGridViewColumn col in proView.Columns)
                width += col.Width;
            foreach(DataGridViewRow row in proView.Rows)
                height += row.Height;

            if (e.X < width && e.Y < height)
                return;
            choose_product();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            choose_product();
        }

        private void getPriceButton_CheckedChanged(object sender, EventArgs e)
        {
            if (getPriceButton.Checked)
            {
                foreach (kuguanDataSet.exchange_managementRow row in dataDataSet.exchange_management.Rows)
                {
                    var rs = from kuguanDataSet.product_stockRow r0 in willRows
                             where row.product_id == r0.product_id
                             select r0.get_price;
                    decimal price = rs.ElementAt(0);
                    row.price = price;
                    row.total_price = Decimal.Round(row.exchange_num * price, 11);
                }
                var rs0 = from kuguanDataSet.exchange_managementRow r1 in dataDataSet.exchange_management.Rows
                          select r1;
                sumBox.Text = rs0.Sum(r1 => r1.exchange_num) + "";
                amountBox.Text = Decimal.Round(rs0.Sum(r1 => r1.total_price), 2) + "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (outpriceButton.Checked)
            {
                foreach (kuguanDataSet.exchange_managementRow row in dataDataSet.exchange_management.Rows)
                {
                    var rs = from kuguanDataSet.product_stockRow r0 in willRows
                             where row.product_id == r0.product_id
                             select r0.out_price;
                    decimal price = rs.ElementAt(0);
                    row.price = price;
                    row.total_price = Decimal.Round(row.exchange_num * price, 11);


                }
                var rs0 = from kuguanDataSet.exchange_managementRow r1 in dataDataSet.exchange_management.Rows
                          select r1;
                sumBox.Text = rs0.Sum(r1 => r1.exchange_num) + "";
                amountBox.Text = Decimal.Round(rs0.Sum(r1 => r1.total_price), 2) + "";
            }
        }

        private void printDGV()
        {
            if (MessageBox.Show("是否打印单据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PrintDialog dg = new PrintDialog();
                DGVPrintDocument doc = new DGVPrintDocument(
                    exchangeDocView, 
                    "调库单据",
                    new int[]{0});
                doc.Title = use_unitTableAdapter.GetName() +"调库单据";
                doc.SubTitle = new String[] { 
                    "出库日期："+datePicker.Value.ToString("yyyy-MM-dd"),
                    "凭证号："+oIdBox.Text,
                    "调出仓库："+outstoreBox.Text,
                    "调入仓库："+instoreBox.Text
                };
                doc.Footer = new String[] {
                    "操作员："+((MainForm)this.MdiParent).MUser.Username,
                    "经手人：",
                    "数量："+sumBox.Text,
                    "金额："+amountBox.Text
                };
                doc.CellFont = Util.GetFont(@"data\cf.dat");
                doc.SubTitleFont = Util.GetFont(@"data\cf.dat");
                doc.FooterFont = Util.GetFont(@"data\cf.dat");
                doc.TitleFont = Util.GetFont(@"data\tf.dat");
                doc.SubCount = 2;
                dg.Document = doc.Doc;
                doc.docInit(false);

                if (dg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    doc.Doc.Print();
                }
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {

            try
            {
                File.Copy(@"data\kuguan.sdf.ebak", @"data\kuguan.sdf", true);
                undoButton.Enabled = false;
                File.Delete(@"data\kuguan.sdf.ebak");
            }
            catch { }
        }

    }
}
