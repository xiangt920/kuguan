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
    public partial class ExchangeDocForm : DockContent
    {
        public ExchangeDocForm()
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
            string eid = oidBox.Text;
            this.exchangeDocTableAdapter.FillByCondition(kuguanDataSet.ExchangeDoc,
                    fromTime.Date.AddDays(-0.0001), toTime.AddDays(1).Date.AddDays(-0.000001), eid); 
        }

        private void StorageDocForm_Load(object sender, EventArgs e)
        {
            fromTimePicker.Value = DateTime.Now.Date.AddDays(-7);
        
        }

        private void StorageDocView_SelectionChanged(object sender, EventArgs e)
        {
            if (ExchangeDocView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ExchangeDocView.SelectedRows[0];
                string eid = (string)row.Cells["eidDataGridViewTextBoxColumn"].Value;
                if (eid != null && eid != "")
                {
                    var rs = from kuguanDataSet.ExchangeDocRow r1 in this.kuguanDataSet.ExchangeDoc.Rows
                             where r1.e_id == eid
                             select r1;
                    kuguanDataSet.ExchangeDocRow r = rs.ElementAt(0);
                    showEidBox.Text = r.e_id + "";
                    showDateBox.Text = r.time.ToString("yyyy-MM-dd");
                    this.exchange_managementTableAdapter.FillById(kuguanDataSet.exchange_management, eid);
                    var result = from kuguanDataSet.exchange_managementRow r2 in kuguanDataSet.exchange_management.Rows
                                 select r2;
                    numBox.Text = result.Sum(r3 => r3.exchange_num) + "";
                    amountBox.Text = "￥ " + Decimal.Round(result.Sum(r4 => r4.total_price), 2);
                    String f_store_s = "";
                    String f_eng_s = "";
                    String t_store_s = "";
                    String t_eng_s = "";
                    foreach (kuguanDataSet.exchange_managementRow r3 in result)
                    {
                        if (!f_store_s.Contains(r3.from_store))
                            f_store_s += r3.from_store + ";";
                        if (!f_eng_s.Contains(r3.from_eng))
                            f_eng_s += r3.from_eng + ";";
                        if (!t_store_s.Contains(r3.to_store))
                            t_store_s += r3.to_store + ";";
                        if (!t_eng_s.Contains(r3.to_eng))
                            t_eng_s += r3.to_eng + ";";
                    }
                    showFStoreBox.Text = f_store_s.Substring(0, f_store_s.Length - 1);
                    showFEngBox.Text = f_eng_s.Substring(0, f_eng_s.Length - 1);
                    showTStoreBox.Text = t_store_s.Substring(0, t_store_s.Length - 1);
                    showTEngBox.Text = t_eng_s.Substring(0, t_eng_s.Length - 1);
                }
            }
            else
            {
                showEidBox.Text = "";
                showDateBox.Text = "";
                showFStoreBox.Text = "";
                showFEngBox.Text = "";
                showTStoreBox.Text = "";
                showTEngBox.Text = "";
                numBox.Text = "";
                amountBox.Text = "";
            }
        }

        private void saveExcelButton_Click(object sender, EventArgs e)
        {
            if (exchangeDetailView.Rows.Count == 0) 
            {
                MessageBox.Show("没有可导出的数据！");
                return;
            }
            String eid = showEidBox.Text;
            String time = showDateBox.Text;
            String out_store_name = showFStoreBox.Text;
            String out_eng_name = showFEngBox.Text;
            String in_store_name = showTStoreBox.Text;
            String in_eng_name = showTEngBox.Text;

            ExcelOperate excel = new ExcelOperate(this,"调库记录-" + eid);
            excel.ExchangeExport(exchangeDetailView,
                "["+eid+"]",
                time,
                out_store_name,
                out_eng_name,
                in_store_name,
                in_eng_name);
        }

        private void PrintDocButton_Click(object sender, EventArgs e)
        {
            if (exchangeDetailView.RowCount > 0)
                printDGV();
            else
                MessageBox.Show("没有可以打印的数据！");
        }
        
        private void printDGV()
        {
            if (MessageBox.Show("是否打印单据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string amount = amountBox.Text;
                if (amount.Contains("￥"))
                    amount = amount.Substring(1);
                PrintDialog dg = new PrintDialog();
                DGVPrintDocument doc = new DGVPrintDocument(exchangeDetailView, 
                    "调库单据",new int[]{0});
                doc.Title = use_unitTableAdapter.GetName()+"调库单据";
                doc.SubTitle = new String[] { 
                    "出库日期："+showDateBox.Text,
                    "凭证号："+showEidBox.Text,
                    "调出仓库："+showFStoreBox.Text,
                    "调入仓库："+showTStoreBox.Text
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
            if (kuguanDataSet.exchange_management.Rows.Count < 0)
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
            kuguanDataSetTableAdapters.exchangeTableAdapter eta = new kuguanDataSetTableAdapters.exchangeTableAdapter();
            manager.stockTableAdapter.Fill(this.kuguanDataSet.stock);
            foreach (kuguanDataSet.exchange_managementRow r in kuguanDataSet.exchange_management.Rows)
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
                        r.product_id, r.from_house_id,
                        r.exchange_num, r.price,
                        Decimal.Round(r.exchange_num * r.price, 11), this.kuguanDataSet.stock);
                DBUtil.changeStock(
                        r.product_id, r.to_house_id,
                        -r.exchange_num, r.price,
                        -Decimal.Round(r.exchange_num * r.price, 11), this.kuguanDataSet.stock);
                i++;
            }
            ata.DeleteRecord(showEidBox.Text, 3);
            eta.DeleteRecord(showEidBox.Text);
            manager.UpdateAll(this.kuguanDataSet);
            this.kuguanDataSet.stock.Rows.Clear();
            this.kuguanDataSet.exchange_management.Rows.Clear();
            search();
        }

    }
}
