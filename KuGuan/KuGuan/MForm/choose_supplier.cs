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
    public partial class choose_supplier : Form
    {
        public choose_supplier()
        {
            InitializeComponent();
        }
        public string supplier_id;
        public string supplier_name;
        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }

        private void choose_supplier_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.supplier”中。您可以根据需要移动或删除它。
            this.supplierTableAdapter.Fill(this.dataDataSet.supplier);
            int row_index = this.supplierDataGridView.SelectedCells[0].RowIndex;
            this.supplierDataGridView.Rows[row_index].Selected = true;
            supplier_id = this.supplierDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            supplier_name = this.supplierDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            this.label2.Text = supplier_name;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void supplierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = this.supplierDataGridView.SelectedCells[0].RowIndex;
            this.supplierDataGridView.Rows[row_index].Selected = true;
            supplier_id = this.supplierDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            supplier_name = this.supplierDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            this.label2.Text = supplier_name;
        }
    }
}
