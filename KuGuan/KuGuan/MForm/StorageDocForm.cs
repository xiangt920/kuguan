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
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime fromTime = fromTimePicker.Value;
            DateTime toTime = toTimePicker.Value;
            string sid = SidBox.Text;
            int supId = -1;
            if(supBox.Text != "")
                supId = C.Id;
            this.storageDocTableAdapter.FillByCondition(dataDataSet.StorageDoc,
                fromTime.Date.AddDays(-0.0001), toTime.AddDays(1).Date.AddDays(-0.000001), 
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
            if(StorageDocView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = StorageDocView.SelectedRows[0];
                string sid = (string)row.Cells["sidDataGridViewTextBoxColumn"].Value;
                if(sid != null && sid != "")
                {
                    var rs = from dataDataSet.StorageDocRow r1 in this.dataDataSet.StorageDoc.Rows
                            where r1.s_id == sid
                            select r1;
                    dataDataSet.StorageDocRow r = rs.ElementAt(0);
                    showDateBox.Text = r.time.ToString("yyyy-MM-dd");
                    showSupBox.Text = r.sup_name;
                    showSidBox.Text = r.s_id;
                    showEngBox.Text = r.product_type;
                    showStoreBox.Text = r.store_name;
                    this.storage_managementTableAdapter.FillById(dataDataSet.storage_management,sid);
                    var result = from dataDataSet.storage_managementRow r2 in dataDataSet.storage_management.Rows
                                 select r2;
                    numBox.Text = result.Sum(r3 => r3.num) + "";
                    amountBox.Text = "￥ "+result.Sum(r4 => r4.total_price);
                }
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

            ExcelOperate excel = new ExcelOperate("入库记录-" + sid);
            excel.StorageExport(storageDetailView,
                "["+sid+"]",
                time,
                store_name,
                eng_name,
                supplier);
        }
    }
}
