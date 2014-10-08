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
        private SupplierForm C = new SupplierForm(true);
        private StoreForm S = new StoreForm(true);
        private choose_product P = new choose_product();
        private int engId;
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
            // TODO:  这行代码将数据加载到表“dataDataSet.product_type”中。您可以根据需要移动或删除它。
            this.product_typeTableAdapter.Fill0(this.dataDataSet.product_type);
            // TODO: 这行代码将数据加载到表“dataDataSet.unit”中。您可以根据需要移动或删除它。
            this.unitTableAdapter.Fill(this.dataDataSet.unit);
            string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date));
            new_id++;
            sidBox.Text = new_id.ToString();
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
                row.product_id = Int32.Parse(proIdBox.Text);
                row.pro_name = proNameBox.Text;
                row.unit_id = (int)unitBox.SelectedValue;
                row.unit_name = unitBox.Text;
                row.num = numUpDown.Value;
                row.get_price = Decimal.Parse(priceBox.Text);
                row.total_price = numUpDown.Value * Decimal.Parse(priceBox.Text);
                row.EndEdit();
                this.dataDataSet.storage_management.Addstorage_managementRow(row);
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
                Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date)) + 1;
                sidBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {
                
            }
        }

        private void storage_management_Shown(object sender, EventArgs e)
        {
            unitBox.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (supNameBox.Text == "")
            {
                MessageBox.Show("请您选择供应商");
                return;
            }

            if (storeBox.Text.Trim() == "" || engBox.Text.Trim() == "")
            {
                MessageBox.Show("请您选择仓库");
                return;
            }
            int count = 0;
            if (this.dataDataSet.storage_management.Rows.Count == 0)
                return;
            List<KuGuan.dataDataSet.storage_managementRow> failedRows = new List<dataDataSet.storage_managementRow>();

            foreach (KuGuan.dataDataSet.storage_managementRow row in this.dataDataSet.storage_management.Rows)
            {
                int c = this.storage_managementTableAdapter.AddStorage(
                    sidBox.Text,
                    datePicker.Value,
                    Int32.Parse(supIdBox.Text),  
                    row.product_id, 
                    row.num,
                    this.engId);
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
        }


        private void storeBox_Click(object sender, EventArgs e)
        {
            if (S.ShowDialog() == DialogResult.OK)
            {
                this.engId = S.Id;
                storeBox.Text = S.ParentName;
                engBox.Text = S.SName;
            }
        }

        private void storeBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
