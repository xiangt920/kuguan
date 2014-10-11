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
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime fromTime = fromTimePicker.Value;
            DateTime toTime = toTimePicker.Value;
            string eid = oidBox.Text;
            this.exchangeDocTableAdapter.FillByCondition(dataDataSet.ExchangeDoc,
                    fromTime.Date.AddDays(-0.0001),toTime.AddDays(1).Date.AddDays(-0.000001),eid);
        }


        private void StorageDocForm_Load(object sender, EventArgs e)
        {
            fromTimePicker.Value = DateTime.Now.Date.AddDays(-7);
        
        }

        private void StorageDocView_SelectionChanged(object sender, EventArgs e)
        {
            if(ExchangeDocView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ExchangeDocView.SelectedRows[0];
                string eid = (string)row.Cells["eidDataGridViewTextBoxColumn"].Value;
                if(eid != null && eid != "")
                {
                    var rs = from dataDataSet.ExchangeDocRow r1 in this.dataDataSet.ExchangeDoc.Rows
                            where r1.e_id == eid
                            select r1;
                    dataDataSet.ExchangeDocRow r = rs.ElementAt(0);
                    showEidBox.Text = r.e_id + "";
                    showDateBox.Text = r.time.ToString("yyyy-MM-dd");
                    showFStoreBox.Text = r.from_store;
                    showFEngBox.Text = r.from_eng;
                    showTStoreBox.Text = r.to_store;
                    showTEngBox.Text = r.to_eng;
                    this.exchange_managementTableAdapter.FillById(dataDataSet.exchange_management,eid);
                    var result = from dataDataSet.exchange_managementRow r2 in dataDataSet.exchange_management.Rows
                                 select r2;
                    numBox.Text = result.Sum(r3 => r3.exchange_num) + "";
                    amountBox.Text = "￥ "+result.Sum(r4 => r4.total_price);
                }
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

            ExcelOperate excel = new ExcelOperate("调库记录-" + eid);
            excel.ExchangeExport(exchangeDetailView,
                "["+eid+"]",
                time,
                out_store_name,
                out_eng_name,
                in_store_name,
                in_eng_name);
        }
    }
}
