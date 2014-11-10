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
    public partial class choose_customer : Form
    {
        private kuguanDataSetTableAdapters.customer_typeTableAdapter custypeAdapter = new kuguanDataSetTableAdapters.customer_typeTableAdapter();
        private DataTable custypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String, int>();
        private int customer_id = -1;
        private string customer_name = "";
        public int Id { get { return this.customer_id; } }
        public string CusName { get { return this.customer_name; } }
        public choose_customer()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.customer”中。您可以根据需要移动或删除它。
            custypeTable = custypeAdapter.GetData();
            foreach (DataRow r in custypeTable.Rows)
            {
                String type_id = (String)r["customer_type_id"];
                String parent_id = (String)r["parent_id"];
                int type_class = (int)r["type_class"];
                String type_name = (String)r["customer_type"];

                TreeNode parent_node = new TreeNode(type_name);

                parent_node.Tag = type_id;
                if (type_class == 1)
                {
                    treeView.Nodes.Add(parent_node);
                    node_index.Add(type_id + "", parent_node.Index);
                }
                else
                {
                    treeView.Nodes[node_index[parent_id + ""]].Nodes.Add(parent_node);
                }
            }

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            tLabel.Text = node.Text;
            if (((String)(node.Tag)) != "-1")
                this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (int?)node.Tag, (int?)node.Tag);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            String cus = cusBox.Text.Trim();
            String addr = addrBox.Text.Trim();
            String linkman = linkmanBox.Text.Trim();
            this.customerTableAdapter.FillByCondition(this.dataDataSet.customer, cus, addr, linkman);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (int?)node.Tag, (int?)node.Tag);
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                KuGuan.kuguanDataSet.customerRow row = (KuGuan.kuguanDataSet.customerRow)this.dataDataSet.customer.Rows[index];
                this.customer_id = row.customer_id;
                this.customer_name = row.customer_name;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
