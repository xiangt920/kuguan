using KuGuan.Model;
using KuGuan.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class StorageDocForm : DockContent
    {
        private SupplierForm C = new SupplierForm(true);
        public StorageDocForm()
        {
            InitializeComponent();
            manager.stockTableAdapter = new kuguanDataSetTableAdapters.stockTableAdapter();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            DateTime fromTime = fromTimePicker.Value;
            DateTime toTime = toTimePicker.Value;
            string sid = SidBox.Text;
            int supId = -1;
            if (supBox.Text != "")
                supId = C.Id;
            this.storageDocTableAdapter.FillByCondition(dataDataSet.StorageDoc,
                fromTime.Date, toTime.Date.AddDays(1).Date,
                sid, supId);
        }

        private void supBox_Click(object sender, EventArgs e)
        {
            if (C.ShowDialog() == DialogResult.OK)
            {
                supBox.Text = C.SupName;
            }
        }

        private void StorageDocForm_Load(object sender, EventArgs e)
        {

            fromTimePicker.Value = DateTime.Now.Date.AddDays(-7);
        }

        private void StorageDocView_SelectionChanged(object sender, EventArgs e)
        {
            if (StorageDocView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = StorageDocView.SelectedRows[0];
                string sid = (string)row.Cells["sidDataGridViewTextBoxColumn"].Value;
                if (sid != null && sid != "")
                {
                    var rs = from kuguanDataSet.StorageDocRow r1 in this.dataDataSet.StorageDoc.Rows
                             where r1.s_id == sid
                             select r1;
                    kuguanDataSet.StorageDocRow r = rs.ElementAt(0);
                    showDateBox.Text = r.time.ToString("yyyy-MM-dd");
                    showSupBox.Text = r.sup_name;
                    showSidBox.Text = r.s_id;
                    this.storage_managementTableAdapter.FillById(dataDataSet.storage_management, sid);
                    var result = from kuguanDataSet.storage_managementRow r2 in dataDataSet.storage_management.Rows
                                 select r2;
                    numBox.Text = result.Sum(r3 => r3.num) + "";
                    amountBox.Text = "￥ " + Decimal.Round(result.Sum(r4 => r4.total_price), 2);
                    String store_s = "";
                    String eng_s = "";
                    foreach (kuguanDataSet.storage_managementRow r3 in result)
                    {
                        if (!store_s.Contains(r3.store_name))
                            store_s += r3.store_name + ";";
                        if(!eng_s.Contains(r3.eng_name))
                        eng_s += r3.eng_name + ";";
                    }
                    showStoreBox.Text = store_s.Substring(0,store_s.Length-1);
                    showEngBox.Text = eng_s.Substring(0,eng_s.Length-1);
                }
            }
            else
            {
                showDateBox.Text = "";
                showSupBox.Text = "";
                showSidBox.Text = "";
                showEngBox.Text = "";
                showStoreBox.Text = "";
                numBox.Text = "";
                amountBox.Text = "";
            }
        }

        private void saveExcelButton_Click(object sender, EventArgs e)
        {
            if (storageDetailView.Rows.Count == 0) 
            {
                MessageBox.Show("没有可导出的数据！");
                return;
            }
            String sid = showSidBox.Text;
            String time = showDateBox.Text;
            String store_name = showStoreBox.Text;
            String eng_name = showEngBox.Text;
            String supplier = showSupBox.Text;

            ExcelOperate excel = new ExcelOperate(this,"入库记录-" + sid);
            excel.StorageExport(storageDetailView,
                "["+sid+"]",
                time,
                store_name,
                eng_name,
                supplier);
        }

        private void PrintDocButton_Click(object sender, EventArgs e)
        {
            if (StorageDocView.RowCount > 0)
            {
                printDGV();
            }
            else
                MessageBox.Show("没有可以打印的数据！");
        }

        private void printDGV()
        {
            if (MessageBox.Show("是否打印单据？", "提示", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string amount = amountBox.Text;
                if (amount.Contains("￥"))
                    amount = amount.Substring(1);
                PrintDialog dg = new PrintDialog();
                DGVPrintDocument doc = new DGVPrintDocument(
                    storageDetailView, 
                    "入库单据",
                    new int[]{0});
                doc.Title = use_unitTableAdapter.GetName()+"入库单据";
                doc.SubTitle = new String[] { 
                    "入库日期："+showDateBox.Text,
                    "凭证号："+showSidBox.Text,
                    "供应商："+showSupBox.Text,
                    "仓库名："+showStoreBox.Text
                };
                doc.Footer = new String[] {
                    "操作员："+((MainForm)this.MdiParent).MUser.Username,
                    "经手人：",
                    "数量："+numBox.Text,
                    "金额："+amount
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataDataSet.storage_management.Rows.Count < 0)
            {
                return;
            }
            else
            {
                if (!(MessageBox.Show(this,
                    "作废后不可恢复，谨慎操作！确定要作废此单？",
                    "警告",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK))
                    return;
            }
            int i = 0;
            kuguanDataSetTableAdapters.accountTableAdapter ata = new kuguanDataSetTableAdapters.accountTableAdapter();
            kuguanDataSetTableAdapters.storageTableAdapter sta = new kuguanDataSetTableAdapters.storageTableAdapter();
            manager.stockTableAdapter.Fill(this.dataDataSet.stock);
            foreach (kuguanDataSet.storage_managementRow r in dataDataSet.storage_management.Rows)
            {
                if (i == 0)
                {
                    int? count = ata.Get0CountFromTime(r.t);
                    if (count > 0)
                    {
                        MessageBox.Show(this,"此单已过去太久了，不可作废！","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }
                DBUtil.changeStock(
                        r.product_id, r.product_type_id,
                        -r.num, r.get_price,
                        0-Decimal.Round(r.num * r.get_price, 11), this.dataDataSet.stock);
                i++;
            }
            ata.DeleteRecord(showSidBox.Text, 1);
            sta.DeleteRecord(showSidBox.Text);
            manager.UpdateAll(this.dataDataSet);
            this.dataDataSet.stock.Rows.Clear();
            this.dataDataSet.storage_management.Rows.Clear();
            search();
        }
    
    }
}
