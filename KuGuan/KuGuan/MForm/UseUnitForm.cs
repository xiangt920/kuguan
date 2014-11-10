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
    public partial class UseUnitForm : Form
    {
        public UseUnitForm()
        {
            InitializeComponent();
        }

        private void UseUnitForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“kuguanDataSet.use_unit”中。您可以根据需要移动或删除它。
            this.use_unitTableAdapter.Fill(this.kuguanDataSet.use_unit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.use_unitBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.kuguanDataSet);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
