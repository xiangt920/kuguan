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
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime fromTime = fromTimePicker.Value;
            DateTime toTime = toTimePicker.Value;
            string oid = oidBox.Text;
            int cusId = -1;
            if(cusBox.Text != "")
                cusId = C.Id;
            this.outDocTableAdapter.FillByCondition(dataDataSet.OutDoc,
                    fromTime.Date.AddDays(-0.0001),toTime.AddDays(1).Date.AddDays(-0.000001),oid,cusId);
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
            fromTimePicker.Value = DateTime.Now.Date.AddDays(-7);
        }

        private void StorageDocView_SelectionChanged(object sender, EventArgs e)
        {
            if(OutDocView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = OutDocView.SelectedRows[0];
                string oid = (string)row.Cells["oidDataGridViewTextBoxColumn"].Value;
                if(oid != null && oid != "")
                {
                    var rs = from dataDataSet.OutDocRow r1 in this.dataDataSet.OutDoc.Rows
                            where r1.o_id == oid
                            select r1;
                    dataDataSet.OutDocRow r = rs.ElementAt(0);
                    showDateBox.Text = r.time.ToString("yyyy-MM-dd");
                    showCusBox.Text = r.cus_name;
                    showOidBox.Text = r.o_id;
                    showEngBox.Text = r.product_type;
                    showStoreBox.Text = r.store_name;
                    this.out_managementTableAdapter.FillById(dataDataSet.out_management,oid);
                    var result = from dataDataSet.out_managementRow r2 in dataDataSet.out_management.Rows
                                 select r2;
                    numBox.Text = result.Sum(r3 => r3.storage_num) + "";
                    amountBox.Text = "￥ "+result.Sum(r4 => r4.total_price);
                }
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

            ExcelOperate excel = new ExcelOperate("出库记录-" + oid);
            excel.OutExport(outDetailView,
                "["+oid+"]",
                time,
                store_name,
                eng_name);
        }
    }
}
