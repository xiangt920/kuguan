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
        private int type;
        public ChgSupForm()
        {
            InitializeComponent();
        }
        public ChgSupForm(String title,int id,int type)
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
                typeBox.Text = type+"";
            }
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
