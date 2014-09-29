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
            int? new_id = unitTableAdapter.GetNewId();
            foreach(DataGridViewRow row in unitDataGridView.Rows)
            {
                if (row.Cells[1].Value is DBNull)
                {
                    row.Cells[1].Value = new_id + "";
                    new_id++;
                }
            }
            this.Validate();
            this.unitBindingSource.EndEdit();
            int count = this.tableAdapterManager.UpdateAll(this.dataDataSet);
            if (count >= 0) {
                MessageBox.Show(this,"修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
