using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class storage_management : DockContent
    {
        private choose_supplier C = new choose_supplier();
        private choose_product P = new choose_product();
        private Dictionary<string, int> dateIdCount = new Dictionary<string, int>();
        public storage_management()
        {
            InitializeComponent();
        }

        private void choose_product(object sender, EventArgs e)
        {
            if (P.ShowDialog() == DialogResult.OK)
            {
                proIdBox.Text = P.ID;
                proNameBox.Text = P.ProName;
                unitBox.Text = P.Unit;
                priceBox.Text = P.InPrice;
                this.numUpDown.Focus();
                this.numUpDown.Select(0, numUpDown.Value.ToString().Length);
            }
        }
        private List<String> to = new List<String>();
        private void storage_management_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.storehouse”中。您可以根据需要移动或删除它。
            this.storehouseTableAdapter.Fill(this.dataDataSet.storehouse);
            // TODO: 这行代码将数据加载到表“dataDataSet.unit”中。您可以根据需要移动或删除它。
            this.unitTableAdapter.Fill(this.dataDataSet.unit);
            string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date));
            new_id++;
            sidBox.Text = new_id.ToString();
            dateIdCount.Add(date, 0);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (P.ShowDialog() == DialogResult.OK)
            {
                proIdBox.Text = P.ID;
                proNameBox.Text = P.ProName;
                unitBox.SelectedText = P.Unit;
                priceBox.Text = P.OutPrice;
                numUpDown.Focus();
            }
            numUpDown.Focus();
        }

        private bool isPrice(string s)
        {
            Regex reg = new Regex("\\d+\\.\\d{11}");
            return reg.IsMatch(s);
        }
        private void show_on_list(object sender, EventArgs e)
        {

            if (sidBox.Text == "")
            {
                MessageBox.Show("请您选择仓库");
                return;
            }
            if (supNameBox.Text == "")
            {
                MessageBox.Show("请您选择供应商");
                return;
            }
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
            if (!isPrice(priceBox.Text))
            {
                MessageBox.Show("请您填写货品价格");
                return;
            }
            if (unitBox.Text == "")
            {
                MessageBox.Show("请您填写货品单位");
                return;
            }
            try
            {
                KuGuan.dataDataSet.storage_managementRow row = (dataDataSet.storage_managementRow)this.dataDataSet.storage_management.NewRow();
                row.BeginEdit();
                row.s_id = sidBox.Text;
                row.t = datePicker.Value;
                row.storehouse_id = (int)storeBox.SelectedValue;
                row.store_name = storeBox.Text;
                row.supplier_id = Int32.Parse(supIdBox.Text);
                row.cust_name = supNameBox.Text;
                row.product_id = Int32.Parse(proIdBox.Text);
                row.pro_name = proNameBox.Text;
                row.unit_id = (int)unitBox.SelectedValue;
                row.unit_name = unitBox.Text;
                row.num = numUpDown.Value;
                row._out = Decimal.Parse(priceBox.Text);
                row.total_price = numUpDown.Value * Decimal.Parse(priceBox.Text);
                row.EndEdit();
                this.dataDataSet.storage_management.Addstorage_managementRow(row);
            }
            catch (System.Exception)
            {
            }
            try
            {
                proNameBox.Text = "";
                supIdBox.Text = ""; priceBox.Text = ""; proIdBox.Text = "";
                storeBox.Text = "";
                supNameBox.Text = "";
                unitBox.Text = "";
                numUpDown.Value = 0;
                string date = datePicker.Value.ToString("yyyyMMdd");
                dateIdCount[date]++;
                Decimal new_id = Decimal.Parse(sidBox.Text) + 1;
                sidBox.Text = new_id.ToString();
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
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (!r.IsNewRow)
                {
                    dataGridView1.Rows.Remove(r);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = this.dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(row_index);
            }
            catch (System.Exception)
            {
                
            }
        }

        private void dateTimePicker1_TabIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
                if (!dateIdCount.ContainsKey(date))
                {
                    dateIdCount.Add(date, 0);
                }
                Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date)) + 1 + dateIdCount[date];
                sidBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {
                
            }
        }

        private void storage_management_Shown(object sender, EventArgs e)
        {
            storeBox.SelectedIndex = 1;
            unitBox.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (this.dataDataSet.storage_management.Rows.Count == 0)
                return;
            List<KuGuan.dataDataSet.storage_managementRow> failedRows = new List<dataDataSet.storage_managementRow>();
            foreach (KuGuan.dataDataSet.storage_managementRow row in this.dataDataSet.storage_management.Rows)
            {
                int c = this.storage_managementTableAdapter.AddStorage(
                    row.s_id, 
                    row.t, 
                    row.supplier_id, 
                    row.storehouse_id, 
                    row.product_id, 
                    row.num);
                if(c > 0){
                    count+=c;
                }
                else
                    failedRows.Add(row);
            }
            if (count == this.dataDataSet.storage_management.Rows.Count)
            {
                MessageBox.Show("成功入库所有信息！");
                this.dataDataSet.storage_management.Rows.Clear();

            }
            else
            {
                MessageBox.Show("提交入库信息条数:" + this.dataDataSet.storage_management.Rows.Count
                    +"\n成功入库信息条数:"+count);
                foreach (KuGuan.dataDataSet.storage_managementRow r in failedRows)
                    this.dataDataSet.storage_management.Rows.Remove(r);
            }
            dateIdCount.Clear();
            string date = datePicker.Value.ToString("yyyyMMdd");
            dateIdCount.Add(date, 0);
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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
