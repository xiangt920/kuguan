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
    public partial class choose_product : Form
    {
        private Dictionary<String, int> node_index = new Dictionary<String, int>();

        private string product_id;
        private string product_name;
        private string product_spec;
        private string product_in_price;
        private string product_out_price;
        private string product_unit;

        public string ID { get { return this.product_id; } }
        public string ProName { get { return this.product_name; } }
        public string ProSpec { get { return this.product_spec; } }
        public string InPrice { get { return this.product_in_price; } }
        public string OutPrice { get { return this.product_out_price; } }
        public string Unit { get { return this.product_unit; } }
        public choose_product()
        {
            InitializeComponent();
            this.productTableAdapter.Fill(this.dataDataSet.product);
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            String cus = cusBox.Text.Trim();
            this.productTableAdapter.FillByCondition(this.dataDataSet.product, cus);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.dataDataSet.product);
        }
        private void cnlButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                int id = (int)dataGridView.Rows[index].Cells[0].Value;
                foreach (KuGuan.dataDataSet.productRow row in this.dataDataSet.product.Rows)
                {
                    if (row.product_id == id) 
                    {

                        this.product_id = row.product_id.ToString();
                        this.product_name = row.product_name;
                        this.product_in_price = row.get_price.ToString();
                        this.product_out_price = row.out_price.ToString();
                        this.product_unit = row.unit;
                        this.product_spec = row.spec;
                        this.DialogResult = DialogResult.OK;
                        return;
                    }
                }
            }
        }

        private void addProButton_Click(object sender, EventArgs e)
        {
            ChgProForm form = new ChgProForm("新增产品", -1);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.productTableAdapter.Fill(this.dataDataSet.product);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgProForm form = new ChgProForm("修改产品", id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.productTableAdapter.Fill(this.dataDataSet.product);
            }
        }
    }
}
