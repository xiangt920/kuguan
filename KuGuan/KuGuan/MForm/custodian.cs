using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class custodian : DockContent
    {
        public custodian()
        {
            InitializeComponent();
        }

        private void custodian_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataDataSet.custodian”中。您可以根据需要移动或删除它。
            this.custodianTableAdapter.Fill(this.dataDataSet.custodian);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.custodianBindingSource.EndEdit();
            int count = this.tableAdapterManager.UpdateAll(this.dataDataSet);
            if (count >= 0) {
                MessageBox.Show(this,"修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
