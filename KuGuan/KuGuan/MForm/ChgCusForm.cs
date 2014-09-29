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
    public partial class ChgCusForm : Form
    {
        private int id;
        private String type;
        public ChgCusForm()
        {
            InitializeComponent();
        }
        public ChgCusForm(String title,int id,String type)
        {
            InitializeComponent();
            this.Text = title;
            this.id = id;
            this.type = type;
        }
        private void ChgCusForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.customer”中。您可以根据需要移动或删除它。
            if (id == -1)
            {
                this.customerBindingSource.AddNew();
            }
            else
            {
                this.customerTableAdapter.FillById(this.dataDataSet.customer, id);
            }
        }

        private void cfmButton_Click(object sender, EventArgs e)
        {
            if(id == -1)
                idBox.Text = customerTableAdapter.GetNewId().ToString();
            this.Validate();
            this.customerBindingSource.EndEdit();
            int count = this.tableAdapterManager.UpdateAll(this.dataDataSet);
            if (count > 0)
            {
                MessageBox.Show(id == -1 ? "新增成功！" : "修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(id == -1 ? "新增失败！" : "修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ChgCusForm_Shown(object sender, EventArgs e)
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
    }
}
