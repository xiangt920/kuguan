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
    public partial class ProductForm : DockContent
    {
        private dataDataSetTableAdapters.product_typeTableAdapter protypeAdapter = new dataDataSetTableAdapters.product_typeTableAdapter();
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
            newNode.Tag = "-1";
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
            addNextButton.Enabled = false;
            addProButton.Enabled = false;
            addButton.Enabled = false;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            addButton.Enabled = true;
            if (node.Level != 0)
            {
                addNextButton.Enabled = false;
                addProButton.Enabled = true;
            }
            else
            {
                addNextButton.Enabled = true;
                addProButton.Enabled = false;
            }
            tLabel.Text = node.Text;
            if (((String)(node.Tag)) != "-1")
                this.productTableAdapter.FillByParent(this.dataDataSet.product, (String)node.Tag, (String)node.Tag);
        }

        private void treeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            String id = (String)e.Node.Tag;
            string name = (string)e.Label;
            if (id != "-1")
            {
                this.protypeAdapter.UpdateTypeById(name, id);
            }
            else
            {
                String new_id = DateTime.Now.ToFileTime().ToString();
                if (e.Node.Level == 0)
                    this.protypeAdapter.AddType(new_id, name, (int?)(e.Node.Level + 1), "0");
                else
                {
                    this.protypeAdapter.AddType(new_id, name, (int?)(e.Node.Level + 1), (String)e.Node.Parent.Tag);
                }
                e.Node.Tag = new_id;
            }
        }

        private void addNextButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;

            TreeNode newNode = new TreeNode("【新类别】");
            newNode.Tag = "-1";
            node.Nodes.Add(newNode);
            treeView.SelectedNode = newNode;
            newNode.BeginEdit();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            String id = (String)node.Tag;

            if (node != null)
            {
                if (node.Level == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "确定删除此类别及所有子类别中的所有供应商？",
                        "删除 '" + node.Text + "' 类别",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        this.productTableAdapter.DeleteBy0(id);
                        this.protypeAdapter.DeleteByParent(id);
                        this.protypeAdapter.DeleteById(id);
                        treeView.Nodes.Remove(node);
                        if (treeView.Nodes.Count != 0)
                            treeView.SelectedNode = treeView.Nodes[0];
                        else
                            this.productTableAdapter.Fill(this.dataDataSet.product);
                    }
                }
                else
                {
                    DialogResult r = MessageBox.Show(
                        "确定删除此类别及此类别中的所有供应商？",
                        "删除 '" + node.Text + "' 类别",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        this.protypeAdapter.DeleteByParent(id);
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
            TreeNode node = treeView.SelectedNode;
            this.productTableAdapter.FillByParent(this.dataDataSet.product, (String)node.Tag, (String)node.Tag);
        }

        private void addSupButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            if (node.Level == 0)
            {
                MessageBox.Show("第一级类别不能添加产品！");
            }
            else
            {
                ChgProForm form = new ChgProForm("新增产品", -1, (String)node.Tag);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.productTableAdapter.FillByParent(this.dataDataSet.product, (String)node.Tag, (String)node.Tag);
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgProForm form = new ChgProForm("修改产品", id, "0");
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.productTableAdapter.FillByParent(this.dataDataSet.product, (String)node.Tag, (String)node.Tag);
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
            ChgProForm form = new ChgProForm("修改产品", id, "0");
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.productTableAdapter.FillByParent(this.dataDataSet.product, (String)node.Tag, (String)node.Tag);
            }
        }
    }
}
