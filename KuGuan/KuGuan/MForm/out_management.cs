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
    public partial class out_management : DockContent
    {

        private choose_stock P = new choose_stock();

        private CustomerForm C = new CustomerForm(true);
        private kuguanDataSetTableAdapters.TableAdapterManager manager;
        private kuguanDataSetTableAdapters.outTableAdapter outAdapter = new kuguanDataSetTableAdapters.outTableAdapter();
        private kuguanDataSetTableAdapters.stockTableAdapter stockAdapter = new kuguanDataSetTableAdapters.stockTableAdapter();
        private kuguanDataSetTableAdapters.remainTableAdapter remainAdapter = new kuguanDataSetTableAdapters.remainTableAdapter();
        public out_management()
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
            manager.storageTableAdapter = null ;
            manager.outTableAdapter = outAdapter;
            manager.exchangeTableAdapter = null;
            manager.remainTableAdapter = remainAdapter;
            manager.accountTableAdapter = accountTableAdapter;
        }
        private void choose_product(object sender, EventArgs e)
        {
            if (P.ShowDialog() == DialogResult.OK)
            {
                proIdBox.Text = P.ID;
                proNameBox.Text = P.ProName;
                unitBox.Text = P.Unit;
                priceBox.Text = P.OutPrice;
                storeBox.Text = P.Store;
                engBox.Text = P.Type;
                unitBox.Text = P.Unit;
                stockBox.Text = P.Stock+"";
                
                this.numUpDown.Focus();
                this.numUpDown.Select(0, numUpDown.Value.ToString().Length);
            }
        }
        private static String[] b = new String[9];
        private List<String> to = new List<String>();

        private void out_management_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.custodian”中。您可以根据需要移动或删除它。
            this.custodianTableAdapter.Fill(this.dataDataSet.custodian);
            stockAdapter.Fill(this.dataDataSet.stock);
            string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.out_managementTableAdapter.find(date));
            new_id++;
            oIdBox.Text = new_id.ToString();
        }

        
        private void show_on_list(object sender, EventArgs e)
        {
            if (proNameBox.Text == "")
            {
                MessageBox.Show("请您选择货品");
                return;
            }
            if (numUpDown.Value == 0)
            {
                MessageBox.Show("请您填写货品数量");
                return;
            }
            try
            {
                KuGuan.kuguanDataSet.out_managementRow row = (kuguanDataSet.out_managementRow)this.dataDataSet.out_management.NewRow();
                row.BeginEdit();
                row.product_id = Int32.Parse(proIdBox.Text);
                row.product_type_id = P.TypeId;
                row.product_name = proNameBox.Text;
                row.unit_id = P.UnitId;
                row.unit = unitBox.Text;
                row.spec = P.ProSpec;
                row.storage_num = numUpDown.Value;
                row.out_price = Decimal.Parse(priceBox.Text);
                row.total_price = Decimal.Round(numUpDown.Value * Decimal.Parse(priceBox.Text),11);
                row.EndEdit();
                this.dataDataSet.out_management.Addout_managementRow(row);
                var rs = from kuguanDataSet.out_managementRow r0 in dataDataSet.out_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.storage_num) + "";
                amountBox.Text = Decimal.Round(rs.Sum(r1 => r1.total_price), 2) + "";
            }
            catch (System.Exception)
            {
            }

        }

        private bool isPrice(string s)
        {
            Regex reg = new Regex("\\d+\\.\\d{11}");
            return reg.IsMatch(s);
        }

        private void choose_customer(object sender, EventArgs e)
        {
            if (C.ShowDialog() == DialogResult.OK)
            {
                cusIdBox.Text = C.Id.ToString();
                cusNameBox.Text = C.CusName; 
                this.numUpDown.Focus();
                this.numUpDown.Select(0, numUpDown.Value.ToString().Length);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataDataSet.out_management.Rows.Clear();
            sumBox.Text = 0+"";
            amountBox.Text = 0+"";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = this.dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(row_index);

                var rs = from kuguanDataSet.out_managementRow r0 in dataDataSet.out_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.storage_num) + "";
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
                MessageBox.Show(this, "该日期已结账，不可出库！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePicker.Value = DateTime.Now;
                return;
            }
            try
            {
                string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
                Decimal new_id = Decimal.Parse((String)this.out_managementTableAdapter.find(date)) + 1;
                oIdBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cusNameBox.Text == "")
            {
                MessageBox.Show("请您选择客户");
                return;
            }
            if (custBox.Text == "")
            {
                MessageBox.Show("请您选择保管员");
                return;
            }
            Util.deleteBak();
            try
            {
                File.Copy(@"data\kuguan.sdf", @"data\kuguan.sdf.obak", true);
                undoButton.Enabled = true;
            }
            catch { }
            int count = 0;
            string reason = "";
            if (this.dataDataSet.out_management.Rows.Count == 0)
                return;
            List<KuGuan.kuguanDataSet.out_managementRow> successedRows = new List<kuguanDataSet.out_managementRow>();

            int cus_id = -1;
            if (cusNameBox.Text.Trim() != "")
            {
                cus_id = Int32.Parse(cusIdBox.Text);
            }
            int typeId = -1;
            this.dataDataSet._out.Rows.Clear();
            this.dataDataSet.account.Rows.Clear();
            stockAdapter.Fill(this.dataDataSet.stock);
            remainAdapter.Fill(this.dataDataSet.remain);
            DateTime tmp = datePicker.Value.Date;
            foreach (KuGuan.kuguanDataSet.out_managementRow row in this.dataDataSet.out_management.Rows)
            {
                typeId = row.product_type_id;
                kuguanDataSet.stockRow r = DBUtil.changeStock(
                    row.product_id, 
                    row.product_type_id, 
                    -row.storage_num,
                    row.out_price,
                    -row.total_price, this.dataDataSet.stock);
                this.dataDataSet._out.AddoutRow(
                    oIdBox.Text, 
                    tmp, 
                    cus_id, 
                    row.product_type_id, 
                    row.product_id, 
                    row.storage_num,
                    r.stock_num,
                    r.stock_amount,
                    row.out_price);
                this.dataDataSet.account.AddaccountRow(
                    row.product_id, row.product_type_id, datePicker.Value, oIdBox.Text,
                    cusNameBox.Text, 0, 0, 0, row.storage_num, row.out_price, row.total_price,
                    "", r.stock_num, r.stock_num == 0 ? 0 : Decimal.Round(r.stock_amount / r.stock_num, 11),
                    r.stock_amount, 2);
                count += 1;
                successedRows.Add(row);
            }

            manager.UpdateAll(this.dataDataSet);
            if (count == this.dataDataSet.out_management.Rows.Count)
            {
                MessageBox.Show("成功出库所有信息("+count+"条)！");
                printDGV();
                this.dataDataSet.out_management.Rows.Clear();

            }
            else
            {
                MessageBox.Show("提交出库信息条数:" + this.dataDataSet.out_management.Rows.Count
                    + "\n成功出库信息条数:" + count+"\n其他信息："+reason);
                foreach (KuGuan.kuguanDataSet.out_managementRow r in successedRows)
                    this.dataDataSet.out_management.Rows.Remove(r);
            }
            var rs = from kuguanDataSet.out_managementRow r0 in dataDataSet.out_management.Rows
                     select r0;
            sumBox.Text = rs.Sum(r1 => r1.storage_num) + "";
            amountBox.Text = Decimal.Round(rs.Sum(r1 => r1.total_price), 2) + "";
            string date = datePicker.Value.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.out_managementTableAdapter.find(date)) + 1;
            oIdBox.Text = new_id.ToString();
        }

        private void printDGV() 
        {
            if (MessageBox.Show("是否打印单据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PrintDialog dg = new PrintDialog();
                DGVPrintDocument doc = new DGVPrintDocument(dataGridView1, "出库单据",new int[]{0});
                doc.Title = use_unitTableAdapter.GetName()+"出库单据";
                doc.SubTitle = new String[] { 
                    "出库日期："+datePicker.Value.ToString("yyyy-MM-dd"),
                    "凭证号："+oIdBox.Text,
                    "客户："+cusNameBox.Text,
                    "仓库名："+storeBox.Text
                };
                doc.Footer = new String[] {
                    "操作员："+((MainForm)this.MdiParent).MUser.Username,
                    "保管员："+custBox.Text,
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

        private void out_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dataDataSet.out_management.Rows.Count > 0)
            {
                if (MessageBox.Show(
                    "还有" + this.dataDataSet.out_management.Rows.Count + "出库信息尚未提交，确定放弃？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
            try
            {
                File.Delete(@"data\kuguan.sdf.obak");
            }
            catch { }

        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(@"data\kuguan.sdf.obak", @"data\kuguan.sdf", true);
                undoButton.Enabled = false;
                File.Delete(@"data\kuguan.sdf.obak");
            }
            catch { }
        }
    
    }
}
