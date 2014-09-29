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
    public partial class choose_product : Form
    {
        private dataDataSetTableAdapters.product_typeTableAdapter protypeAdapter = new dataDataSetTableAdapters.product_typeTableAdapter();
        private DataTable protypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String, int>();

        private string product_id;
        private string product_name;
        private string product_in_price;
        private string product_out_price;
        private string product_unit;
        private string product_count;

        public string ID { get { return this.product_id; } }
        public string ProName { get { return this.product_name; } }
        public string InPrice { get { return this.product_in_price; } }
        public string OutPrice { get { return this.product_out_price; } }
        public string Unit { get { return this.product_unit; } }
        public string Count { get { return this.product_count; } }
        public choose_product()
        {
            InitializeComponent();
            protypeTable = protypeAdapter.GetData();
            foreach (DataRow r in protypeTable.Rows)
            {
                String type_id = (String)r["product_type_id"];
                String parent_id = (String)r["parent_id"];
                int type_class = (int)r["type_class"];
                String type_name = (String)r["product_type"];

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

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.product”中。您可以根据需要移动或删除它。
            
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            tLabel.Text = node.Text;
            if (((String)(node.Tag)) != "-1")
                this.productTableAdapter.FillByParent(this.dataDataSet.product, (String)node.Tag, (String)node.Tag);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String cus = cusBox.Text.Trim();
            this.productTableAdapter.FillByCondition(this.dataDataSet.product, cus);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            this.productTableAdapter.FillByParent(this.dataDataSet.product, (String)node.Tag, (String)node.Tag);
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
                KuGuan.dataDataSet.productRow row = (KuGuan.dataDataSet.productRow)this.dataDataSet.product.Rows[index];
                this.product_id = row.product_id.ToString();
                this.product_name = row.product_name;
                this.product_in_price = row.get_price.ToString();
                this.product_out_price = row.out_price.ToString();
                this.product_unit = row.unit;
                this.product_count = row.count.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
