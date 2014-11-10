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
    public partial class OutDocForm : DockContent
    {
        private CustomerForm C = new CustomerForm(true);
        public OutDocForm()
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
            string oid = oidBox.Text;
            int cusId = -2;
            if (cusBox.Text != "")
                cusId = C.Id;
            this.outDocTableAdapter.FillByCondition(kuguanDataSet.OutDoc,
                    fromTime.Date.AddDays(-0.0001), toTime.AddDays(1).Date.AddDays(-0.000001), oid, cusId);
        }

        private void supBox_Click(object sender, EventArgs e)
        {
            if (C.ShowDialog() == DialogResult.OK)
            {
                cusBox.Text = C.CusName;
            }
        }

        private void StorageDocForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“kuguanDataSet.custodian”中。您可以根据需要移动或删除它。
            this.custodianTableAdapter.Fill(this.kuguanDataSet.custodian);
            fromTimePicker.Value = DateTime.Now.Date.AddDays(-7);
        }

        private void StorageDocView_SelectionChanged(object sender, EventArgs e)
        {
            if(OutDocView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = OutDocView.SelectedRows[0];
                string oid = (string)row.Cells["oidDataGridViewTextBoxColumn"].Value;
                if (oid != null && oid != "")
                {
                    var rs = from kuguanDataSet.OutDocRow r1 in this.kuguanDataSet.OutDoc.Rows
                             where r1.o_id == oid
                             select r1;
                    kuguanDataSet.OutDocRow r = rs.ElementAt(0);
                    showDateBox.Text = r.time.ToString("yyyy-MM-dd");
                    showCusBox.Text = r.cus_name;
                    showOidBox.Text = r.o_id;
                    this.out_managementTableAdapter.FillById(kuguanDataSet.out_management, oid);
                    var result = from kuguanDataSet.out_managementRow r2 in kuguanDataSet.out_management.Rows
                                 select r2;
                    numBox.Text = result.Sum(r3 => r3.storage_num) + "";
                    amountBox.Text = "￥ " + Decimal.Round(result.Sum(r4 => r4.total_price), 2);
                    String store_s = "";
                    String eng_s = "";
                    foreach (kuguanDataSet.out_managementRow r3 in result)
                    {
                        if (!store_s.Contains(r3.store_name))
                            store_s += r3.store_name + ";";
                        if (!eng_s.Contains(r3.eng_name))
                            eng_s += r3.eng_name + ";";
                    }
                    showStoreBox.Text = store_s.Substring(0, store_s.Length - 1);
                    showEngBox.Text = eng_s.Substring(0, eng_s.Length - 1);
                }
                
            }
            else
            {
                showDateBox.Text = "";
                showCusBox.Text = "";
                showOidBox.Text = "";
                showEngBox.Text = "";
                showStoreBox.Text = "";
                numBox.Text = "";
                amountBox.Text = "";

            }
        }

        private void saveExcelButton_Click(object sender, EventArgs e)
        {
            if (outDetailView.Rows.Count == 0) 
            {
                MessageBox.Show("没有可导出的数据！");
                return;
            }
            String oid = showOidBox.Text;
            String time = showDateBox.Text;
            String store_name = showStoreBox.Text;
            String eng_name = showEngBox.Text;

            ExcelOperate excel = new ExcelOperate(this,"出库记录-" + oid);
            excel.OutExport(outDetailView,
                "["+oid+"]",
                time,
                store_name,
                eng_name);
        }

        private void PrintDocButton_Click(object sender, EventArgs e)
        {
            if (custBox.Text == "")
            {
                MessageBox.Show("请选择保管员");
                return;
            }
            if (outDetailView.RowCount > 0)
                printDGV();
            else
                MessageBox.Show("没有可以打印的数据！");
        }

        private void printDGV()
        {
            if (MessageBox.Show("是否打印单据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PrintDialog dg = new PrintDialog();
                DGVPrintDocument doc = new DGVPrintDocument(outDetailView, "出库单据",new int[]{0});
                string amount = amountBox.Text;
                if (amount.Contains("￥"))
                    amount = amount.Substring(1);
                doc.Title = use_unitTableAdapter.GetName()+"出库单据";
                doc.SubTitle = new String[] { 
                    "出库日期："+showDateBox.Text,
                    "凭证号："+showOidBox.Text,
                    "客户："+showCusBox.Text,
                    "仓库名："+showStoreBox.Text
                };
                doc.Footer = new String[] {
                    "操作员："+((MainForm)this.MdiParent).MUser.Username,
                    "保管员："+custBox.Text,
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
            if (kuguanDataSet.out_management.Rows.Count < 0)
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
            kuguanDataSetTableAdapters.outTableAdapter ota = new kuguanDataSetTableAdapters.outTableAdapter();
            manager.stockTableAdapter.Fill(this.kuguanDataSet.stock);
            foreach (kuguanDataSet.out_managementRow r in kuguanDataSet.out_management.Rows)
            {
                if (i == 0)
                {
                    int? count = ata.Get0CountFromTime(r.time);
                    if (count > 0)
                    {
                        MessageBox.Show(this, "此单已过去太久了，不可作废！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DBUtil.changeStock(
                        r.product_id, r.product_type_id,
                        r.storage_num, r.out_price,
                        Decimal.Round(r.storage_num * r.out_price, 11), this.kuguanDataSet.stock);
                i++;
            }
            ata.DeleteRecord(showOidBox.Text, 2);
            ota.DeleteRecord(showOidBox.Text);
            manager.UpdateAll(this.kuguanDataSet);
            this.kuguanDataSet.stock.Rows.Clear();
            this.kuguanDataSet.out_management.Rows.Clear();
            search();
        }

        private void OutDocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    
    }
}
