using KuGuan.Utils;
using KuGuan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace KuGuan.MForm
{
    public partial class storage_management : DockContent
    {
        
        private SupplierForm C = new SupplierForm(true);
        private choose_stock P = new choose_stock();
        private kuguanDataSetTableAdapters.TableAdapterManager manager;
        private kuguanDataSetTableAdapters.storageTableAdapter storageAdapter = new kuguanDataSetTableAdapters.storageTableAdapter();
        private kuguanDataSetTableAdapters.stockTableAdapter stockAdapter = new kuguanDataSetTableAdapters.stockTableAdapter();
        private kuguanDataSetTableAdapters.remainTableAdapter remainAdapter = new kuguanDataSetTableAdapters.remainTableAdapter();
        public storage_management()
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
            manager.storageTableAdapter = storageAdapter;
            manager.outTableAdapter = null;
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
                priceBox.Text = P.InPrice;
                specBox.Text = P.ProSpec;
                storeBox.Text = P.Store;
                engBox.Text = P.Type;
                this.numUpDown.Focus();
                this.numUpDown.Select(0, numUpDown.Value.ToString().Length);

            }
        }
        
        private void storage_management_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.product_type”中。您可以根据需要移动或删除它。
            this.product_typeTableAdapter.Fill0(this.dataDataSet.product_type);
            this.stockAdapter.Fill(this.dataDataSet.stock);
            this.remainAdapter.Fill(this.dataDataSet.remain);
            string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date));
            new_id++;
            sidBox.Text = new_id.ToString();
        }

        private bool isPrice(string s)
        {
            Regex reg = new Regex("\\d+\\.\\d{11}");
            return reg.IsMatch(s);
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
                KuGuan.kuguanDataSet.storage_managementRow row = (kuguanDataSet.storage_managementRow)this.dataDataSet.storage_management.NewRow();
                row.BeginEdit();
                row.s_id = sidBox.Text;
                row.t = datePicker.Value;
                row.supplier_id = C.Id;
                row.product_type_id = P.TypeId;
                row.product_id = Int32.Parse(proIdBox.Text);
                row.pro_name = proNameBox.Text;
                row.unit_id = P.UnitId;
                row.spec = P.ProSpec;
                row.unit_name = unitBox.Text;
                row.num = numUpDown.Value;
                row.get_price = Decimal.Parse(priceBox.Text);
                row.total_price = Decimal.Round(numUpDown.Value * Decimal.Parse(priceBox.Text),11);
                row.EndEdit();
                this.dataDataSet.storage_management.Addstorage_managementRow(row);
                var rs = from kuguanDataSet.storage_managementRow r0 in dataDataSet.storage_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.num)+"";
                amountBox.Text = Decimal.Round(rs.Sum(r1 => r1.total_price), 2) + "";

            }
            catch (System.Exception)
            {
            }
            
            
        }

        private void choose_supplier(object sender, EventArgs e)
        {
            
            if (C.ShowDialog() == DialogResult.OK)
            {
                supIdBox.Text = C.Id.ToString();
                supNameBox.Text = C.SupName;
                this.numUpDown.Focus(); 
                this.numUpDown.Select(0,numUpDown.Value.ToString().Length);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataDataSet.storage_management.Rows.Clear();
            sumBox.Text = "0";
            amountBox.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = this.dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(row_index);

                var rs = from kuguanDataSet.storage_managementRow r0 in dataDataSet.storage_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.num) + "";
                amountBox.Text = Decimal.Round(rs.Sum(r1 => r1.total_price), 2) + "";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dateTimePicker1_TabIndexChanged(object sender, EventArgs e)
        {
            kuguanDataSetTableAdapters.accountTableAdapter ata = new kuguanDataSetTableAdapters.accountTableAdapter();
            int? count = ata.Get0CountFromTime(datePicker.Value);
            if (count > 0)
            {
                MessageBox.Show(this, "该日期已结账，不可入库！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePicker.Value = DateTime.Now;
                return;
            }
            try
            {
                string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
                Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date)) + 1;
                sidBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {
                
            }
        }
        
        private Boolean saveAll()
        {
            if (supNameBox.Text == "")
            {
                MessageBox.Show("请您选择供应商");
                return false ;
            }

            if (storeBox.Text.Trim() == "" || engBox.Text.Trim() == "")
            {
                MessageBox.Show("请您选择仓库");
                return false;
            }
            int count = 0;
            if (this.dataDataSet.storage_management.Rows.Count == 0)
                return false;
            count = (int)this.storage_managementTableAdapter.GetCountById(sidBox.Text);
            if (count > 0)
            {
                MessageBox.Show("已存在该凭证号有关的入库信息！");
                return false;
            }
            Util.deleteBak();
            try
            {
                File.Copy(@"data\kuguan.sdf", @"data\kuguan.sdf.sbak", true);
                undoButton.Enabled = true;
            }
            catch { }
            count = 0;
            List<KuGuan.kuguanDataSet.storage_managementRow> successedRows = new List<kuguanDataSet.storage_managementRow>();
            this.dataDataSet.storage.Rows.Clear();
            this.dataDataSet.account.Rows.Clear();
            stockAdapter.Fill(this.dataDataSet.stock);
            remainAdapter.Fill(this.dataDataSet.remain);
            DateTime tmp = datePicker.Value.Date;
            foreach (KuGuan.kuguanDataSet.storage_managementRow row in this.dataDataSet.storage_management.Rows)
            {
                try
                {
                    kuguanDataSet.stockRow r = DBUtil.changeStock(
                        row.product_id, row.product_type_id, 
                        row.num,row.get_price,
                        Decimal.Round(row.num * row.get_price,11), this.dataDataSet.stock);
                    this.dataDataSet.storage.AddstorageRow(
                        sidBox.Text, 
                        tmp, 
                        C.Id, 
                        row.product_type_id, 
                        row.product_id, 
                        row.num,
                        r.stock_num,
                        r.stock_amount,
                        row.get_price);

                    this.dataDataSet.account.AddaccountRow(
                        row.product_id, row.product_type_id, tmp,sidBox.Text, supNameBox.Text,
                        row.num, row.get_price, row.total_price,
                        0, 0, 0, "", r.stock_num, r.stock_num == 0 ? 0 : Decimal.Round(r.stock_num / r.stock_num, 11),
                        r.stock_amount, 1);
                    successedRows.Add(row);
                    count++;
                }
                catch (Exception) { }
            }
            manager.UpdateAll(this.dataDataSet);
            if (count == this.dataDataSet.storage_management.Rows.Count)
            {
                MessageBox.Show("成功入库所有信息(" + count + "条)！");
            }
            else
            {
                MessageBox.Show("提交入库信息条数:" + this.dataDataSet.storage_management.Rows.Count
                    + "\n成功入库信息条数:" + count);
                foreach (KuGuan.kuguanDataSet.storage_managementRow r in successedRows)
                    this.dataDataSet.storage_management.Rows.Remove(r);
                var rs = from kuguanDataSet.storage_managementRow r0 in dataDataSet.storage_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.num) + "";
                amountBox.Text = Decimal.Round(rs.Sum(r1 => r1.total_price),2) + "";
                return false;
            }
            panel2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            datePicker.Enabled = true;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!saveAll()) return;
            if (MessageBox.Show("是否打印单据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                PrintDialog dg = new PrintDialog();
                DGVPrintDocument doc = new DGVPrintDocument(
                    dataGridView1,
                    "入库单据",
                    new int[]{0});
                doc.Title = use_unitTableAdapter.GetName()+"入库单据";
                doc.SubTitle = new String[] { 
                    "入库日期："+datePicker.Value.ToString("yyyy-MM-dd"),
                    "凭证号："+sidBox.Text,
                    "供应商："+supNameBox.Text,
                    "仓库名："+storeBox.Text
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
            this.dataDataSet.storage_management.Rows.Clear();
            sumBox.Text = "0";
            amountBox.Text = "0";
            string date = datePicker.Value.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date)) + 1;
            sidBox.Text = new_id.ToString();
        }

        private void storage_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dataDataSet.storage_management.Rows.Count > 0) 
            {
                if (MessageBox.Show(
                    "还有" + this.dataDataSet.storage_management.Rows.Count + "入库信息尚未提交，确定放弃？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                        e.Cancel = false;
                else
                    e.Cancel = true;
            }
            try
            {
                File.Delete(@"data\kuguan.sdf.sbak");
            }
            catch { }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {

            try
            {
                File.Copy(@"data\kuguan.sdf.sbak", @"data\kuguan.sdf", true);
                undoButton.Enabled = false;
                File.Delete(@"data\kuguan.sdf.sbak");
            }
            catch { }
        }

    }
}
