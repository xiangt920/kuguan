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
    public partial class exchange_management : DockContent
    {

        private choose_product P = new choose_product();

        private choose_customer C = new choose_customer();
        private Dictionary<string, int> dateIdCount = new Dictionary<string, int>();
        public exchange_management()
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
                stockBox.Text = P.Count;
                this.numUpDown.Focus();
                this.numUpDown.Select(0, numUpDown.Value.ToString().Length);
            }
        }
        private static String[] b = new String[9];
        private List<String> to = new List<String>();

        private void exchange_management_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.storehouse”中。您可以根据需要移动或删除它。
            this.storehouseTableAdapter.Fill(this.dataDataSet.storehouse);
            // TODO: 这行代码将数据加载到表“dataDataSet.unit”中。您可以根据需要移动或删除它。
            this.unitTableAdapter.Fill(this.dataDataSet.unit);
            string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(date));
            new_id++;
            oIdBox.Text = new_id.ToString();
            dateIdCount.Add(date, 0);
        }

        
        private void show_on_list(object sender, EventArgs e)
        {
            if (fromHouseBox.SelectedIndex == toHouseBox.SelectedIndex)
            {
                MessageBox.Show("请您选择不同仓库进行调库！");
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
                KuGuan.dataDataSet.exchange_managementRow row = (dataDataSet.exchange_managementRow)this.dataDataSet.exchange_management.NewRow();
                row.BeginEdit();
                row.exchange_id = oIdBox.Text;
                row.time = datePicker.Value;
                row.from_house_id = (int)fromHouseBox.SelectedValue;
                row.to_house_id = (int)toHouseBox.SelectedValue;
                row.from_house = fromHouseBox.Text;
                row.to_house = toHouseBox.Text;
                row.product_id = Int32.Parse(proIdBox.Text);
                row.product_name = proNameBox.Text;
                row.unit_id = (int)unitBox.SelectedValue;
                row.unit = unitBox.Text;
                row.exchange_num = numUpDown.Value;
                row.get_price = Decimal.Parse(priceBox.Text);
                row.total_price = numUpDown.Value * Decimal.Parse(priceBox.Text);
                row.EndEdit();
                this.dataDataSet.exchange_management.Addexchange_managementRow(row);
            
                proNameBox.Text = "";
                fromHouseBox.Text = "";
                unitBox.Text = "";
                numUpDown.Value = 0;
                string date = datePicker.Value.ToString("yyyyMMdd");
                dateIdCount[date]++;
                Decimal new_id = Decimal.Parse(oIdBox.Text) + 1;
                oIdBox.Text = new_id.ToString();
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
                Decimal new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(date)) + 1 + dateIdCount[date];
                oIdBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (this.dataDataSet.exchange_management.Rows.Count == 0)
                return;
            List<KuGuan.dataDataSet.exchange_managementRow> failedRows = new List<dataDataSet.exchange_managementRow>();
            foreach (KuGuan.dataDataSet.exchange_managementRow row in this.dataDataSet.exchange_management.Rows)
            {
                int c = this.exchange_managementTableAdapter.AddExchange(
                    row.exchange_id,
                    row.time,
                    row.product_id,
                    row.exchange_num,
                    row.from_house_id,
                    row.to_house_id);
                if (c > 0)
                {
                    count += c;
                }
                else
                    failedRows.Add(row);
            }
            if (count == this.dataDataSet.exchange_management.Rows.Count)
            {
                MessageBox.Show("成功入库所有信息！");
                this.dataDataSet.exchange_management.Rows.Clear();

            }
            else
            {
                MessageBox.Show("提交入库信息条数:" + this.dataDataSet.exchange_management.Rows.Count
                    + "\n成功入库信息条数:" + count);
                foreach (KuGuan.dataDataSet.exchange_managementRow r in failedRows)
                    this.dataDataSet.exchange_management.Rows.Remove(r);
            }
            dateIdCount.Clear();
            string date = datePicker.Value.ToString("yyyyMMdd");
            dateIdCount.Add(date, 0);
            Decimal new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(date)) + 1;
            oIdBox.Text = new_id.ToString();
        }

        private void exchange_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dataDataSet.exchange_management.Rows.Count > 0)
            {
                if (MessageBox.Show(
                    "还有" + this.dataDataSet.exchange_management.Rows.Count + "入库信息尚未提交，确定放弃？",
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
