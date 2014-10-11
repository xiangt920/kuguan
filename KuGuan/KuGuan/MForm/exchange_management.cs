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

        private choose_stock P = new choose_stock(true);
        private StoreForm S = new StoreForm(true);
        private bool CellValueTrue = true;
        private DataGridViewCell ErrorCell = null;
        private choose_customer C = new choose_customer();
        private List<dataDataSet.product_stockRow> willRows = new List<dataDataSet.product_stockRow>();
        public exchange_management()
        {
            InitializeComponent();
        }
        private void choose_product()
        {
            if (P.ShowDialog() == DialogResult.OK)
            {
                outstoreBox.Text = P.Store;
                proView.Rows.Clear();
                String t = "";
                foreach (dataDataSet.product_stockRow row in P.SelectedRows)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(proView, new object[] {row.product_id,row.product_name,row.stock_num,row.stock_num });
                    if (!t.Contains(row.product_type))
                        t += row.product_type + ";";

                    proView.Rows.Add(r);
                }
                outengBox.Text = t;
            }
        }
        private static String[] b = new String[9];
        private List<String> to = new List<String>();

        private void exchange_management_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.unit”中。您可以根据需要移动或删除它。
            this.unitTableAdapter.Fill(this.dataDataSet.unit);
            string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(date));
            new_id++;
            oIdBox.Text = new_id.ToString();
        }

        
        private void show_on_list(object sender, EventArgs e)
        {
            if (proView.Rows.Count == 0)
            {
                MessageBox.Show("请您选择需要调整的货品！");
                return;
            }
            if (instoreBox.Text == "")
            {
                MessageBox.Show("请您选择调入仓库！");
                return;
            }
            foreach (dataDataSet.product_stockRow r in P.SelectedRows)
            {
                if (r.product_type_id == S.Id)
                {
                    MessageBox.Show("编号为" + r.product_id + "的产品调出仓库与调入仓库冲突");
                    return;
                }
            }
            try
            {
                
                foreach (dataDataSet.product_stockRow r in P.SelectedRows)
                {
                    KuGuan.dataDataSet.exchange_managementRow row = (dataDataSet.exchange_managementRow)this.dataDataSet.exchange_management.NewRow();
                    row.BeginEdit();
                    row.time = datePicker.Value;
                    row.from_house_id = r.product_type_id;
                    row.to_house_id = S.Id;
                    row.from_eng = r.product_type;
                    row.to_eng = S.SName;
                    row.product_id = r.product_id;
                    row.product_name = r.product_name;
                    row.unit_id = r.unit_id;
                    row.unit = r.unit;
                    row.spec = r.spec;
                    var num = from DataGridViewRow r0 in proView.Rows
                              where (int)r0.Cells["ProIdCol"].Value == r.product_id
                              select Decimal.Parse(r0.Cells["NumCol"].Value+"");
                    row.exchange_num = num.ElementAt(0);
                    if (getPriceButton.Checked)
                    {
                        row.price = r.get_price;
                        row.total_price = r.get_price * num.ElementAt(0);
                    }
                    else
                    {
                        row.price = r.out_price;
                        row.total_price = r.out_price * num.ElementAt(0);
                    }
                    row.EndEdit();
                    if(!willRows.Contains(r))
                        willRows.Add(r);
                    this.dataDataSet.exchange_management.Addexchange_managementRow(row);
                }
                
                string date = datePicker.Value.ToString("yyyyMMdd");
                Decimal new_id = Decimal.Parse(oIdBox.Text) + 1;
                oIdBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.dataDataSet.exchange_management.Rows.Clear();
            willRows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = this.exchangeDocView.SelectedCells[0].RowIndex;
                exchangeDocView.Rows.RemoveAt(row_index);
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
                Decimal new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(date)) + 1;
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
            List<KuGuan.dataDataSet.exchange_managementRow> successedRows = new List<dataDataSet.exchange_managementRow>();
            Dictionary<int,string> fromIdList = new Dictionary<int,string>();
            string exchangeId = "";
            ISet<int> failedIdList = new SortedSet<int>();
            foreach (KuGuan.dataDataSet.exchange_managementRow row in this.dataDataSet.exchange_management.Rows)
            {
                if (fromIdList.Count == 0)
                {
                    exchangeId = oIdBox.Text;
                    fromIdList.Add(row.from_house_id, exchangeId);
                }
                else if (fromIdList.ContainsKey(row.from_house_id))
                {
                    exchangeId = fromIdList[row.from_house_id];
                }
                else
                {
                    string tmp_date = datePicker.Value.ToString("yyyyMMdd");
                    Decimal tmp_new_id = Decimal.Parse((String)this.exchange_managementTableAdapter.find(tmp_date)) + 1;
                    exchangeId = tmp_new_id + "";
                    fromIdList.Add(row.from_house_id, exchangeId);
                }
                int c = this.exchange_managementTableAdapter.AddExchange(
                    exchangeId,
                    row.time,
                    row.product_id,
                    row.exchange_num,
                    row.from_house_id,
                    row.to_house_id,
                    outpriceButton.Checked);
                if (c > 0)
                {
                    count += c;
                    successedRows.Add(row);
                }
                else
                {
                    if(!failedIdList.Contains(row.product_id))
                        failedIdList.Add(row.product_id);
                }
            }
            if (count == this.dataDataSet.exchange_management.Rows.Count)
            {
                MessageBox.Show("成功入库所有信息！");
                this.dataDataSet.exchange_management.Rows.Clear();
                willRows.Clear();
            }
            else
            {
                MessageBox.Show("提交入库信息条数:" + this.dataDataSet.exchange_management.Rows.Count
                    + "\n成功入库信息条数:" + count);
                foreach (KuGuan.dataDataSet.exchange_managementRow r in successedRows)
                {
                    this.dataDataSet.exchange_management.Rows.Remove(r);
                }

                willRows.RemoveAll(r0 => !failedIdList.Contains(r0.product_id));
            }
            string date = datePicker.Value.ToString("yyyyMMdd");
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

        private void instoreBox_Click(object sender, EventArgs e)
        {
            if (S.ShowDialog() == DialogResult.OK)
            {
                instoreBox.Text = S.ParentName;
                inengBox.Text = S.SName;
            }
        }

        private void proView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == NumCol.Index)
            {
                DataGridViewCell c = proView.CurrentCell;
                string s = c.Value+"";
                if (!isNum(s))
                {
                    CellValueTrue = false;
                    MessageBox.Show("数量格式不正确，请输入小数点位数为5位一下的正确数字！");
                    foreach (DataGridViewRow r in proView.Rows)
                        r.Selected = false;
                    c.Selected = true;
                    proView.CurrentCell = c;
                    ErrorCell = c;
                    c.Value = c.OwningRow.Cells["StockCol"].Value;
                }
                else
                {
                    CellValueTrue = true;
                    ErrorCell = null;
                }
            }
        }

        private bool isNum(string s)
        {
            Regex reg = new Regex("^\\d+(\\.\\d{1,5})?$");
            return reg.IsMatch(s);
        }

        private void proView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!CellValueTrue)
            {
                if (proView.CurrentCell != ErrorCell)
                {
                    e.Cancel = true;
                    proView.CurrentCell = ErrorCell;
                    proView.BeginEdit(true);
                }
            }
        }

        private void proView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != NumCol.Index)
                choose_product();
        }

        private void proView_MouseClick(object sender, MouseEventArgs e)
        {
            int width = 0;
            int height = proView.ColumnHeadersHeight;
            foreach(DataGridViewColumn col in proView.Columns)
                width += col.Width;
            foreach(DataGridViewRow row in proView.Rows)
                height += row.Height;

            if (e.X < width && e.Y < height)
                return;
            choose_product();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            choose_product();
        }

        private void getPriceButton_CheckedChanged(object sender, EventArgs e)
        {

            foreach (dataDataSet.exchange_managementRow row in dataDataSet.exchange_management.Rows)
            {
                var rs = from dataDataSet.product_stockRow r0 in willRows
                         where row.product_id == r0.product_id
                         select r0.get_price;
                decimal price = rs.ElementAt(0);
                row.price = price;
                row.total_price = row.exchange_num * price;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            foreach (dataDataSet.exchange_managementRow row in dataDataSet.exchange_management.Rows)
            {
                var rs = from dataDataSet.product_stockRow r0 in willRows
                         where row.product_id == r0.product_id
                         select r0.out_price;
                decimal price = rs.ElementAt(0);
                row.price = price;
                row.total_price = row.exchange_num * price;
            }
        }

    }
}
