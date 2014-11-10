using KuGuan.Utils;
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
        private kuguanDataSetTableAdapters.customer_typeTableAdapter custypeAdapter = new kuguanDataSetTableAdapters.customer_typeTableAdapter();
        private DataTable custypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String, int>();
        private bool isChoose = false;
        private int customer_id = -1;
        private string customer_name = "";
        private bool importing = false;
        public int Id { get { return this.customer_id; } }
        public string CusName { get { return this.customer_name; } }
        public ProgressBar Bar { get { return this.progressBar1; } }
        public bool Importing { set { this.importing = value; } }
        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(bool isChoose)
        {
            InitializeComponent();
            this.isChoose = isChoose;
            if (isChoose)
            {
                custypeTable = custypeAdapter.GetData();
                foreach (DataRow r in custypeTable.Rows)
                {
                    int type_id = (int)r["customer_type_id"];
                    int parent_id = (int)r["parent_id"];
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
                importButton.Enabled = false;
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.customer”中。您可以根据需要移动或删除它。
            if (!isChoose)
            {
                if (custypeTable != null)
                    custypeTable.Rows.Clear();
                custypeTable = custypeAdapter.GetData();
                foreach (DataRow r in custypeTable.Rows)
                {
                    try
                    {
                        int type_id = (int)r["customer_type_id"];
                        int parent_id = (int)r["parent_id"];
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
                    catch (Exception)
                    { }
                }
                addNextButton.Enabled = false;
                addSupButton.Enabled = false;
                addButton.Enabled = false;
                importButton.Enabled = false;
            }

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            addButton.Enabled = true;
            if (node.Level != 0)
            {
                addNextButton.Enabled = false;
                addSupButton.Enabled = true;
                importButton.Enabled = true;
            }
            else
            {
                addNextButton.Enabled = true;
                addSupButton.Enabled = false;
                importButton.Enabled = false;
            }
            tLabel.Text = node.Text;
            if (((int)(node.Tag)) != -1)
                this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (int)node.Tag, (int)node.Tag);
        }

        private void treeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            int id = (int)e.Node.Tag;
            string name = (string)e.Label;
            if (id != -1 &&name != null && name != "" && name != e.Node.Text)
            {
                this.custypeAdapter.UpdateTypeById(name, id);
            }
            else if(name != null)
            {
                if (e.Node.Level == 0)
                    this.custypeAdapter.AddType(name, 1, 0);
                else
                {
                    this.custypeAdapter.AddType(name, 2, (int)e.Node.Parent.Tag);
                }
                e.Node.Tag = this.custypeAdapter.GetNewId();
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

        private void delButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            int id = (int)node.Tag;

            if (node != null)
            {
                if (node.Level == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "确定删除此类别及所有子类别中的所有客户？",
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
                        "确定删除此类别及此类别中的所有客户？",
                        "删除 '" + node.Text + "' 类别",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        this.customerTableAdapter.DeleteBy1(id);
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
            this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (int)node.Tag, (int)node.Tag);
        }

        private void delSupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除该客户?", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                DataRowView SelectedRowView = (DataRowView)this.customerBindingSource.Current;
                kuguanDataSet.customerRow selectedRow = (kuguanDataSet.customerRow)SelectedRowView.Row;
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
                ChgCusForm form = new ChgCusForm("新增客户", -1, (int)node.Tag);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (int)node.Tag, (int)node.Tag);
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgCusForm form = new ChgCusForm("修改客户", id, 0);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (int)node.Tag, (int)node.Tag);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TreeNode node = treeView.SelectedNode;

            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            if (isChoose)
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    foreach (KuGuan.kuguanDataSet.customerRow row in this.dataDataSet.customer.Rows) 
                    {
                        if (row.customer_id == id)
                        {
                            this.customer_id = row.customer_id;
                            this.customer_name = row.customer_name;
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                    }
                }
                return;
            }
            ChgCusForm form = new ChgCusForm("修改客户", id, 0);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.customerTableAdapter.FillByParent(this.dataDataSet.customer, (int)node.Tag, (int)node.Tag);
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            if (node == null)
            {
                MessageBox.Show("请先选择一个客户类别！");
                return;
            }
            if (node.Level == 0)
            {
                MessageBox.Show("第一级类别不能添加客户！");
            }
            else
            {
                if (this.importing)
                {
                    MessageBox.Show("正在进行其它导入操作！\n请耐心等待导入完成后再进行此操作！");
                    return;
                }
                ExcelOperate excel = new ExcelOperate(this);
                excel.ImportSupplier(node.Tag, false);
            }
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.importing)
            {
                MessageBox.Show("正在导入数据，无法关闭窗口");
                e.Cancel = true;
            }
        }
    }
}
