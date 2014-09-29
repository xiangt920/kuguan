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
    public partial class choose_supplier : Form
    {
        private dataDataSetTableAdapters.supplier_typeTableAdapter suptypeAdapter = new dataDataSetTableAdapters.supplier_typeTableAdapter();
        private DataTable suptypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String,int>();

        private int supplier_id = -1;
        private string supplier_name = "";
        public int Id { get { return this.supplier_id; } }
        public string SupName { get { return this.supplier_name; } }
        public choose_supplier()
        {
            InitializeComponent();
            suptypeTable = suptypeAdapter.GetData();
            foreach (DataRow r in suptypeTable.Rows)
            {
                String type_id = (String)r["supplier_type_id"];
                String parent_id = (String)r["parent_id"];
                int type_class = (int)r["type_class"];
                String type_name = (String)r["supplier_type"];

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

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.supplier”中。您可以根据需要移动或删除它。
            
            

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            tLabel.Text = node.Text;
            if(((String)(node.Tag)) != "-1")
                this.supplierTableAdapter.FillByParent(this.dataDataSet.supplier, (String)node.Tag, (String)node.Tag);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            this.supplierTableAdapter.FillByParent(this.dataDataSet.supplier, (String)node.Tag, (String)node.Tag);
        }

        private void search(object sender, EventArgs e)
        {
            String sup = supBox.Text.Trim();
            String addr = addrBox.Text.Trim();
            String linkman = linkmanBox.Text.Trim();
            this.supplierTableAdapter.FillByCondition(this.dataDataSet.supplier, sup, addr, linkman);
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                KuGuan.dataDataSet.supplierRow row = (KuGuan.dataDataSet.supplierRow)this.dataDataSet.supplier.Rows[index];
                this.supplier_id = row.supplier_id;
                this.supplier_name = row.supplier_name;
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
