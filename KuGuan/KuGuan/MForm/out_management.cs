using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KuGuan.MForm
{
    public partial class out_management : Form
    {
        public out_management()
        {
            InitializeComponent();
        }
        private void choose_product(object sender, EventArgs e)
        {
            product P = new product();
            if (P.ShowDialog() == DialogResult.OK)
            {
                textBox8.Text = P.product_id;
                textBox6.Text = P.product_name;
                comboBox3.Text = P.product_unit;
                textBox7.Text = P.product_price;
            }
        }
        private static String[] b = new String[9];
        private List<String> to = new List<String>();

        private void out_management_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.unit”中。您可以根据需要移动或删除它。
            this.unitTableAdapter.Fill(this.dataDataSet.unit);
            // TODO: 这行代码将数据加载到表“dataDataSet.out_management”中。您可以根据需要移动或删除它。
            this.out_managementTableAdapter.Fill(this.dataDataSet.out_management);
            string date = dateTimePicker1.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            for (int i = 1; ; i++)
            {
                int? j = this.out_managementTableAdapter.find(date + i.ToString());
                if (j == 0)
                {
                    textBox1.Text = date + i.ToString();
                    break;
                }

            }
        }

        private bool isNumber(string s)
        {
            int Flag = 0;
            try
            {

                char[] str = s.ToCharArray();
                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsNumber(str[i]))
                    {
                        Flag++;
                    }
                    else
                    {
                        Flag = -1;
                        break;
                    }
                }
            }
            catch (System.Exception ex)
            {

            }
            if (Flag > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void show_on_list(object sender, MouseEventArgs e)
        {
            int add = 0;
            b[0] = textBox1.Text.ToString();
            b[1] = dateTimePicker1.Text.ToString();
            b[2] = comboBox1.Text.ToString();
            b[3] = comboBox2.Text.ToString();
            b[4] = textBox6.Text.ToString();
            b[5] = textBox7.Text.ToString();
            b[6] = comboBox3.Text.ToString();
            b[7] = numericUpDown2.Value.ToString();
            if (b[0] == "" || b[1] == "" || b[2] == "" || b[3] == "" || b[4] == "" || b[5] == "" || b[6] == "" || b[7] == "")
            {
                add = 1;
                if (b[2] == "")
                    System.Windows.Forms.MessageBox.Show("请您选择仓库");
                else if (b[3] == "")
                    System.Windows.Forms.MessageBox.Show("请您选择供应商");
                else if (b[4] == "")
                    System.Windows.Forms.MessageBox.Show("请您选择货品");
                else if (b[7] == "0")
                    System.Windows.Forms.MessageBox.Show("请您填写货品数量");
                else if (b[5] == "0")
                    System.Windows.Forms.MessageBox.Show("请您填写货品价格");
                else if (b[6] == "0")
                    System.Windows.Forms.MessageBox.Show("请您填写货品单位");
                else if (b[5] != "")
                    if (!isNumber(b[5]))
                        System.Windows.Forms.MessageBox.Show("请您填写正确货品价格");
                    else if (b[7] != "")
                        if (!isNumber(b[7]))
                            System.Windows.Forms.MessageBox.Show("请您填写正确货品数量");
                        else
                            System.Windows.Forms.MessageBox.Show("对不起！请您审核后再提交");
            }
            if (add != 1)
            {

                if (b[5] != "")
                    if (!isNumber(b[5]))
                    {
                        System.Windows.Forms.MessageBox.Show("请您填写正确货品价格");
                        add = 2;
                    }
                    else if (b[7] != "")
                        if (!isNumber(b[7]))
                        {
                            System.Windows.Forms.MessageBox.Show("请您填写正确货品数量");
                            add = 2;
                        }
            }

            if (add == 0)
            {
                int flag = 0;
                try
                {
                    if (b[7] != "0" && b[5] != "")
                    {
                        b[8] = (int.Parse(b[7]) * int.Parse(b[5])).ToString();
                    }
                    else
                    {
                        b[8] = "";
                    }
                }
                catch (System.Exception ex)
                {

                }
                try
                {
                    dataGridView1.Rows.Add(b);
                }
                catch (System.Exception ex)
                {

                }
                try
                {
                    textBox1.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
                    textBox2.Text = ""; textBox7.Text = ""; textBox8.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    numericUpDown2.Value = 0;
                    string date = dateTimePicker1.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
                    for (int i = 1; ; i++)
                    {
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            if (!r.IsNewRow)
                            {
                                //textBox2.Text = r.Cells[0].Value.ToString();
                                if (r.Cells[0].Value.ToString().Equals(date + i.ToString()))
                                {
                                    flag = 1;
                                }
                                else
                                {

                                }
                            }
                        }
                        if (flag == 0)
                        {
                            int? j = this.out_managementTableAdapter.find(date + i.ToString());
                            if (j == 0)
                            {
                                textBox1.Text = date + i.ToString();
                                break;
                            }
                        }
                        flag = 0;
                    }
                    int row_index = this.dataGridView1.SelectedCells[0].RowIndex;
                    this.dataGridView1.Rows[row_index].Selected = true;
                }
                catch (System.Exception ex)
                {

                }
                add = 0;
            }

        }

        private void choose_supplier(object sender, EventArgs e)
        {
            choose_supplier C = new choose_supplier();
            if (C.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = C.supplier_id;
                comboBox2.Text = C.supplier_name;
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
            catch (System.Exception ex)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row_index = this.dataGridView1.SelectedCells[0].RowIndex;
                this.dataGridView1.Rows[row_index].Selected = true;
            }
            catch (System.Exception ex)
            {

            }
        }

        private void dateTimePicker1_TabIndexChanged(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                string date = dateTimePicker1.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
                for (int i = 1; ; i++)
                {
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        if (!r.IsNewRow)
                        {
                            //textBox2.Text = r.Cells[0].Value.ToString();
                            if (r.Cells[0].Value.ToString().Equals(date + i.ToString()))
                            {
                                flag = 1;
                            }
                            else
                            {

                            }
                        }
                    }
                    if (flag == 0)
                    {
                        int? j = this.out_managementTableAdapter.find(date + i.ToString());
                        if (j == 0)
                        {
                            textBox1.Text = date + i.ToString();
                            break;
                        }
                    }
                    flag = 0;
                }
            }
            catch (System.Exception ex)
            {

            }
        }

    }
}
