﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KuGuan.MForm
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.storehouse”中。您可以根据需要移动或删除它。
            this.storehouseTableAdapter.Fill(this.dataDataSet.storehouse);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? new_id = storehouseTableAdapter.GetNewId();
            foreach (DataGridViewRow row in storeDataGridView.Rows)
            {
                if (row.Cells[1].Value is DBNull)
                {
                    row.Cells[1].Value = new_id + "";
                    new_id++;
                }
            }
            this.Validate();
            this.storehouseBindingSource.EndEdit();
            int count = this.tableAdapterManager.UpdateAll(this.dataDataSet);
            if (count >= 0)
            {
                MessageBox.Show(this,"修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}