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
    public partial class product : Form
    {
        public string product_id;
        public string product_name;
        public string product_price;
        public string product_unit;

        public product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product_id = this.productDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void product_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.dataDataSet.product);
            int row_index = this.productDataGridView.SelectedCells[0].RowIndex;
            this.productDataGridView.Rows[row_index].Selected = true;
            product_id = this.productDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            product_name = this.productDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            product_price = this.productDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            product_unit = this.productDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            this.show_name.Text = product_name;

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = this.productDataGridView.SelectedCells[0].RowIndex;
            this.productDataGridView.Rows[row_index].Selected = true;
            product_id = this.productDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            product_name = this.productDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            product_price = this.productDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            product_unit = this.productDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            this.show_name.Text = product_name;
            
        }
    }
}
