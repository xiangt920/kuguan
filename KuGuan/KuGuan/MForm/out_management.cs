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
    public partial class out_management : DockContent
    {

        private choose_stock P = new choose_stock();

        private CustomerForm C = new CustomerForm(true);
        public out_management()
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
                KuGuan.dataDataSet.out_managementRow row = (dataDataSet.out_managementRow)this.dataDataSet.out_management.NewRow();
                row.BeginEdit();
                row.product_id = Int32.Parse(proIdBox.Text);
                row.product_type_id = P.TypeId;
                row.product_name = proNameBox.Text;
                row.unit_id = P.UnitId;
                row.unit = unitBox.Text;
                row.storage_num = numUpDown.Value;
                row.out_price = Decimal.Parse(priceBox.Text);
                row.total_price = numUpDown.Value * Decimal.Parse(priceBox.Text);
                row.EndEdit();
                this.dataDataSet.out_management.Addout_managementRow(row);
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
                Decimal new_id = Decimal.Parse((String)this.out_managementTableAdapter.find(date)) + 1;
                oIdBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            string reason = "";
            if (this.dataDataSet.out_management.Rows.Count == 0)
                return;
            List<KuGuan.dataDataSet.out_managementRow> successedRows = new List<dataDataSet.out_managementRow>();

            int cus_id = -1;
            if (cusNameBox.Text.Trim() != "")
            {

                cus_id = Int32.Parse(cusIdBox.Text);
            }
            int typeId = -1;
            foreach (KuGuan.dataDataSet.out_managementRow row in this.dataDataSet.out_management.Rows)
            {
                if (typeId == -1)
                    typeId = row.product_type_id;
                else
                {
                    if (typeId != row.product_type_id)
                    {
                        if (!reason.Contains("多条记录所在仓库不一致；"))
                            reason += "多条记录所在仓库不一致；";
                        
                        continue;
                    }
                }
                int c = this.out_managementTableAdapter.AddOut(
                    oIdBox.Text,
                    datePicker.Value,
                    cus_id,
                    P.TypeId,
                    row.product_id,
                    row.storage_num);
                if (c > 0)
                {
                    count += c;
                    successedRows.Add(row);
                }
                else
                {
                    reason += "存入数据库失败;";
                }
            }
            if (count == this.dataDataSet.out_management.Rows.Count)
            {
                MessageBox.Show("成功入库所有信息！");
                this.dataDataSet.out_management.Rows.Clear();

            }
            else
            {
                MessageBox.Show("提交入库信息条数:" + this.dataDataSet.out_management.Rows.Count
                    + "\n成功入库信息条数:" + count+"\n其他信息："+reason);
                foreach (KuGuan.dataDataSet.out_managementRow r in successedRows)
                    this.dataDataSet.out_management.Rows.Remove(r);
            }
            string date = datePicker.Value.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.out_managementTableAdapter.find(date)) + 1;
            oIdBox.Text = new_id.ToString();
        }

        private void out_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dataDataSet.out_management.Rows.Count > 0)
            {
                if (MessageBox.Show(
                    "还有" + this.dataDataSet.out_management.Rows.Count + "入库信息尚未提交，确定放弃？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }

    }
}
