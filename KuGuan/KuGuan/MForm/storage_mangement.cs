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
    public partial class storage_mangement : Form
    {
        public storage_mangement()
        {
            InitializeComponent();
        }

        private void storage_mangement_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.dataDataSet.product);
            // TODO: 这行代码将数据加载到表“dataDataSet.storage_management”中。您可以根据需要移动或删除它。
            this.storage_managementTableAdapter.Fill(this.dataDataSet.storage_management);


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void storage_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
