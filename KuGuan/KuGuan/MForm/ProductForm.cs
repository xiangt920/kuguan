using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class ProductForm : DockContent
    {
        private dataDataSetTableAdapters.product_typeTableAdapter protypeAdapter = new dataDataSetTableAdapters.product_typeTableAdapter();
        private dataDataSetTableAdapters.QueriesTableAdapter procAdapter = new dataDataSetTableAdapters.QueriesTableAdapter();
        private DataTable protypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String, int>();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;

            TreeNode newNode = new TreeNode("【新类别】");
            newNode.Tag = -1;
            if (node == null || node.Level == 0)
            {
                treeView.Nodes.Add(newNode);
            }
            else
            {
                node.Parent.Nodes.Add(newNode);
            }
            treeView.SelectedNode = newNode;
            newNode.BeginEdit();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.dataDataSet.product);
            initTree();
            addNextButton.Enabled = false;
            addButton.Enabled = false;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            addButton.Enabled = true;
            if (node.Level != 0)
            {
                addNextButton.Enabled = false;
            }
            else
            {
                addNextButton.Enabled = true;
            }
            tLabel.Text = node.Text;
        }

        private void treeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            int id = (int)e.Node.Tag;
            string name = (string)e.Label;
            if (name == null)
                return;
            if (id != -1)
            {
                this.protypeAdapter.UpdateTypeById(name, id);
            }
            else
            {
                int? new_id = -1;
                if (e.Node.Level == 0)
                    this.procAdapter.AddProType(name, 1, 0,ref new_id);
                else
                {
                    this.procAdapter.AddProType(name, 2, (int)e.Node.Parent.Tag, ref new_id);
                }
                e.Node.Tag = (int)new_id;
            }
        }

        private void addNextButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;

            TreeNode newNode = new TreeNode("【新类别】");
            newNode.Tag = -1;
            node.Nodes.Add(newNode);
            treeView.SelectedNode = newNode;
            newNode.BeginEdit();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            int id = (int)node.Tag;

            if (node != null)
            {
                if (node.Level == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "确定删除此类别及其所有子类别？",
                        "删除 '" + node.Text + "' 类别",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        this.protypeAdapter.DeleteByParent(id);
                        this.protypeAdapter.DeleteById(id);
                        treeView.Nodes.Remove(node);
                        if (treeView.Nodes.Count != 0)
                            treeView.SelectedNode = treeView.Nodes[0];
                    }
                }
                else
                {
                    DialogResult r = MessageBox.Show(
                        "确定删除此类别？",
                        "删除 '" + node.Text + "' 类别",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        this.protypeAdapter.DeleteById(id);
                        treeView.SelectedNode = node.Parent;
                        treeView.Nodes.Remove(node);

                    }
                }
                if (treeView.Nodes.Count == 0)
                {
                    addNextButton.Enabled = false;
                    tLabel.Text = "";
                }


            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String cus = cusBox.Text.Trim();
            this.productTableAdapter.FillByCondition(this.dataDataSet.product, cus);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.dataDataSet.product);
        }

        private void addSupButton_Click(object sender, EventArgs e)
        {
            ChgProForm form = new ChgProForm("新增产品", -1);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.productTableAdapter.Fill(this.dataDataSet.product);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgProForm form = new ChgProForm("修改产品", id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.productTableAdapter.Fill(this.dataDataSet.product);
            }
        }

        private void delSupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除该产品?", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                DataRowView SelectedRowView = (DataRowView)this.productBindingSource.Current;
                dataDataSet.productRow selectedRow = (dataDataSet.productRow)SelectedRowView.Row;
                this.productTableAdapter.DeleteById(selectedRow.product_id);
                selectedRow.Delete();
                
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgProForm form = new ChgProForm("修改产品", id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.productTableAdapter.Fill(this.dataDataSet.product);
            }
        }

        private void initTree() 
        {
            clearTree(treeView);
            node_index.Clear();
            protypeTable = protypeAdapter.GetData();
            foreach (DataRow r in protypeTable.Rows)
            {
                int type_id = (int)r["product_type_id"];
                int parent_id = (int)r["parent_id"];
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

        private void clearTree(TreeView tree)
        {
            if (tree.Nodes.Count > 0)
            {
                foreach (TreeNode node in tree.Nodes)
                    clearNode(node);
                tree.Nodes.Clear();
            }
        }

        private void clearNode(TreeNode node) 
        {
            if (node != null && node.Nodes.Count != 0)
            {
                foreach (TreeNode n in node.Nodes)
                    clearNode(n);
                node.Nodes.Clear();
            }
        }
    
    }
}
