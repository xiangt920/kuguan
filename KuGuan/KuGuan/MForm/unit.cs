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
    public partial class unit : Form
    {
        public unit()
        {
            InitializeComponent();
        }

        private void unit_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.unit”中。您可以根据需要移动或删除它。
            this.unitTableAdapter.Fill(this.dataDataSet.unit);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDataSet);

        }
    }
}
