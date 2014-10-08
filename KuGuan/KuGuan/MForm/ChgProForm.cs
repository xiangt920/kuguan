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
        public ChgProForm()
        {
            InitializeComponent();
        }

        public ChgProForm(String title, int id)
        {
            InitializeComponent();
            this.Text = title;
            this.id = id;
        }

        private void ChgProForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.unit”中。您可以根据需要移动或删除它。
            this.unitTableAdapter.Fill(this.dataDataSet.unit);
            if (id == -1)
            {
                this.productBindingSource.AddNew();
                try
                {
                    unitBox.SelectedValue = this.dataDataSet.unit.Rows[0]["unit_id"];
                }
                catch (Exception) { }
            }
            else
            {
                this.productTableAdapter.FillById(this.dataDataSet.product, id);
                this.unitBox.Text = (string)this.dataDataSet.product.Rows[0]["unit"];
            }
        }

        private void cfmButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            int count = 0;
            try
            {
                if (id == -1)
                {
                    count = this.productTableAdapter.AddProduct(
                        product_nameTextBox.Text,
                        Decimal.Parse(get_priceTextBox.Text),
                        Decimal.Parse(out_priceTextBox.Text),
                        (int)unitBox.SelectedValue,
                        introBox.Text,
                        remarkTextBox.Text,
                        specBox.Text
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
                        specBox.Text,
                        Int32.Parse(idBox.Text)
                        );
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("价格输入错误!");
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
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
