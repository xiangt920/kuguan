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
    public partial class ChgSupForm : Form
    {
        private int id;
        private String type;
        public ChgSupForm()
        {
            InitializeComponent();
        }
        public ChgSupForm(String title,int id,String type)
        {
            InitializeComponent();
            this.Text = title;
            this.id = id;
            this.type = type;
        }

        private void ChgSupForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.supplier”中。您可以根据需要移动或删除它。

            if (id == -1)
            {
                this.supplierBindingSource.AddNew();
            }
            else
            {
                this.supplierTableAdapter.FillById(this.dataDataSet.supplier, id);
            }
        }

        private void cfmButton_Click(object sender, EventArgs e)
        {
            if(id == -1)
                idBox.Text = (supplierTableAdapter.GetMaxId() + 1).ToString();
            this.Validate();
            this.supplierBindingSource.EndEdit();
            int count = this.tableAdapterManager.UpdateAll(this.dataDataSet);
            if (count > 0)
            {
                MessageBox.Show(id == -1 ? "新增成功！" : "修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(id == -1 ? "新增失败！" : "修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChgSupForm_Shown(object sender, EventArgs e)
        {
            if (id == -1)
            {
                typeBox.Text = type;
            }
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void supplier_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void supplier_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkmanLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkmanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone1Label_Click(object sender, EventArgs e)
        {

        }

        private void phone1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void faxLabel_Click(object sender, EventArgs e)
        {

        }

        private void faxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void urlLabel_Click(object sender, EventArgs e)
        {

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void opening_bankLabel_Click(object sender, EventArgs e)
        {

        }

        private void opening_bankTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bank_accountLabel_Click(object sender, EventArgs e)
        {

        }

        private void bank_accountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
