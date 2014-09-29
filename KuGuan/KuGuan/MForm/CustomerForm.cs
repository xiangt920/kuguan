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
    public partial class CustomerForm : DockContent
    {
        private dataDataSetTableAdapters.customer_typeTableAdapter custypeAdapter = new dataDataSetTableAdapters.customer_typeTableAdapter();
        private DataTable custypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String, int>();
        public CustomerForm()
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
            addNextButton.Enabled = false;
            addSupButton.Enabled = false;
            addButton.Enabled = false;

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            addButton.Enabled = true;
            if (node.Level != 0)
            {
                addNextButton.Enabled = false;
                addSupButton.Enabled = true;
            }
            else
            {
                addNextButton.Enabled = true;
                addSupButton.Enabled = false;
            }
            tLabel.Text = node.Text;
            if (((String)(node.Tag)) != "-1")
                this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (String)node.Tag, (String)node.Tag);
        }

        private void treeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            String id = (String)e.Node.Tag;
            string name = (string)e.Label;
            if (id != "-1")
            {
                this.custypeAdapter.UpdateTypeById(name, id);
            }
            else
            {
                String new_id = DateTime.Now.ToFileTime().ToString();
                if (e.Node.Level == 0)
                    this.custypeAdapter.AddType(new_id, name, (int?)(e.Node.Level + 1), "0");
                else
                {
                    this.custypeAdapter.AddType(new_id, name, (int?)(e.Node.Level + 1), (String)e.Node.Parent.Tag);
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
                        this.customerTableAdapter.DeleteBy0(id);
                        this.custypeAdapter.DeleteByParent(id);
                        this.custypeAdapter.DeleteById(id);
                        treeView.Nodes.Remove(node);
                        if (treeView.Nodes.Count != 0)
                            treeView.SelectedNode = treeView.Nodes[0];
                        else
                            this.customerTableAdapter.Fill(this.dataDataSet.customer);
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
                        this.custypeAdapter.DeleteByParent(id);
                        this.custypeAdapter.DeleteById(id);
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
            String addr = addrBox.Text.Trim();
            String linkman = linkmanBox.Text.Trim();
            this.customerTableAdapter.FillByCondition(this.dataDataSet.customer, cus, addr, linkman);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (String)node.Tag, (String)node.Tag);
        }

        private void delSupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除该客户?", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                DataRowView SelectedRowView = (DataRowView)this.customerBindingSource.Current;
                dataDataSet.customerRow selectedRow = (dataDataSet.customerRow)SelectedRowView.Row;
                selectedRow.Delete();
                this.customerTableAdapter.Update(this.dataDataSet);

            }
        }

        private void addSupButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            if (node.Level == 0)
            {
                MessageBox.Show("第一级类别不能添加客户！");
            }
            else
            {
                ChgCusForm form = new ChgCusForm("新增客户", -1, (String)node.Tag);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (String)node.Tag, (String)node.Tag);
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgCusForm form = new ChgCusForm("修改客户", id, "0");
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (String)node.Tag, (String)node.Tag);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgCusForm form = new ChgCusForm("修改客户", id, "0");
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (String)node.Tag, (String)node.Tag);
            }
        }
    }
}
