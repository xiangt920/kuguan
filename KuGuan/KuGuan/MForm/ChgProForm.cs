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
    public partial class ChgProForm : Form
    {

        private int id;
        private String type;
        public ChgProForm()
        {
            InitializeComponent();
        }

        public ChgProForm(String title, int id, String type)
        {
            InitializeComponent();
            this.Text = title;
            this.id = id;
            this.type = type;
        }

        private void ChgProForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.unit”中。您可以根据需要移动或删除它。
            this.unitTableAdapter.Fill(this.dataDataSet.unit);
            if (id == -1)
            {
                this.productBindingSource.AddNew();
            }
            else
            {
                this.productTableAdapter.FillById(this.dataDataSet.product, id);
            }
        }

        private void cfmButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            int count = 0;
            if (id == -1)
            {
                count = this.productTableAdapter.AddProduct(
                    System.Int32.Parse(productTableAdapter.GetNewId().ToString()),
                    typeBox.Text,
                    product_nameTextBox.Text,
                    Decimal.Parse(get_priceTextBox.Text),
                    Decimal.Parse(out_priceTextBox.Text),
                    (int)unitBox.SelectedValue,
                    introBox.Text,
                    remarkTextBox.Text
                    );
            }
            else
            {
                count = this.productTableAdapter.UpdateById(
                    product_nameTextBox.Text,
                    remarkTextBox.Text,
                    introBox.Text,
                    (int)unitBox.SelectedValue,
                    Decimal.Parse(get_priceTextBox.Text),
                    Decimal.Parse(out_priceTextBox.Text),
                    Int32.Parse(idBox.Text)
                    );
            }
            if (count > 0)
            {
                MessageBox.Show(id == -1 ? "新增成功！" : "修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(id == -1 ? "新增失败！" : "修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChgProForm_Shown(object sender, EventArgs e)
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
