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
    public partial class SupplierForm : DockContent
    {
        private dataDataSetTableAdapters.supplier_typeTableAdapter suptypeAdapter = new dataDataSetTableAdapters.supplier_typeTableAdapter();
        private dataDataSetTableAdapters.QueriesTableAdapter procAdapter = new dataDataSetTableAdapters.QueriesTableAdapter();
        private DataTable suptypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String,int>();
        private bool isChoose = false;
        private int supplier_id = -1;
        private string supplier_name = "";
        public int Id { get { return this.supplier_id; } }
        public string SupName { get { return this.supplier_name; } }
        public SupplierForm()
        {
            InitializeComponent();
        }
        public SupplierForm(bool isChoose)
        {
            InitializeComponent();
            this.isChoose = isChoose;
            this.Text = "选择供货商";
            suptypeTable = suptypeAdapter.GetData();
            foreach (DataRow r in suptypeTable.Rows)
            {
                int type_id = (int)r["supplier_type_id"];
                int parent_id = (int)r["parent_id"];
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
            addNextButton.Enabled = false;
            addSupButton.Enabled = false;
            addButton.Enabled = false;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.customer”中。您可以根据需要移动或删除它。
            if (!isChoose)
            {
                suptypeTable = suptypeAdapter.GetData();
                foreach (DataRow r in suptypeTable.Rows)
                {
                    int type_id = (int)r["supplier_type_id"];
                    int parent_id = (int)r["parent_id"];
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
                addNextButton.Enabled = false;
                addSupButton.Enabled = false;
                addButton.Enabled = false;
            }
            

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;

            TreeNode newNode = new TreeNode("【新类别】");
            newNode.Tag = -1;
            if (node == null ||node.Level == 0)
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
                        "确定删除此类别及所有子类别中的所有供应商？",
                        "删除 '" + node.Text + "' 类别",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        this.supplierTableAdapter.DeleteBy0(id);
                        this.suptypeAdapter.DeleteByParent(id);
                        this.suptypeAdapter.DeleteById(id);
                        treeView.Nodes.Remove(node);
                        if (treeView.Nodes.Count != 0)
                            treeView.SelectedNode = treeView.Nodes[0];
                        else
                            this.supplierTableAdapter.Fill(this.dataDataSet.supplier);
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
                        this.supplierTableAdapter.DeleteBy1(id);
                        this.suptypeAdapter.DeleteByParent(id);
                        this.suptypeAdapter.DeleteById(id);
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
            if(((int)(node.Tag)) != -1)
                this.supplierTableAdapter.FillByParent(this.dataDataSet.supplier, (int)node.Tag, (int)node.Tag);
        }

        private void treeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            int id = (int)e.Node.Tag;
            string name = e.Label;
            if (id != -1 && name != "" && name != e.Node.Text)
            {
                MessageBox.Show(id+"");
                this.suptypeAdapter.UpdateTypeById(name, id);
            }
            else
            {
                int? new_id = -1;
                if (e.Node.Level == 0)
                    this.procAdapter.AddSupType(ref new_id, name, 1, 0);
                else
                {
                    this.procAdapter.AddSupType(ref new_id, name, 2, (int)e.Node.Parent.Tag);
                }
                e.Node.Tag = new_id;
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

        private void addSupButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            if (node.Level == 0)
            {
                MessageBox.Show("第一级类别不能添加供应商！");
            }
            else
            {
                ChgSupForm form = new ChgSupForm("新增供货商", -1, (int)node.Tag);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.supplierTableAdapter.FillByParent(this.dataDataSet.supplier, (int)node.Tag, (int)node.Tag);
                }
            }
            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgSupForm form = new ChgSupForm("修改供货商", id, 0);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.supplierTableAdapter.FillByParent(this.dataDataSet.supplier, (int)node.Tag, (int)node.Tag);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            this.supplierTableAdapter.FillByParent(this.dataDataSet.supplier, (int)node.Tag, (int)node.Tag);
        }

        private void delSupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除该供应商?", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                DataRowView SelectedRowView = (DataRowView)this.supplierBindingSource.Current;
                dataDataSet.supplierRow selectedRow = (dataDataSet.supplierRow)SelectedRowView.Row;
                selectedRow.Delete();
                //this.supplierTableAdapter.Update(this.dataDataSet);

            }
        }

        private void search(object sender, EventArgs e)
        {
            String sup = supBox.Text.Trim();
            String addr = addrBox.Text.Trim();
            String linkman = linkmanBox.Text.Trim();
            this.supplierTableAdapter.FillByCondition(this.dataDataSet.supplier, sup, addr, linkman);
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
                    var rows = from KuGuan.dataDataSet.supplierRow row in this.dataDataSet.supplier.Rows
                              where row.supplier_id == id
                              select row;
                    
                    this.supplier_id = rows.ElementAt(0).supplier_id;
                    this.supplier_name = rows.ElementAt(0).supplier_name;
                    this.DialogResult = DialogResult.OK;
                    return;
                }
                return;
            }
            ChgSupForm form = new ChgSupForm("修改供货商", id, 0);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.supplierTableAdapter.FillByParent(this.dataDataSet.supplier, (int)node.Tag, (int)node.Tag);
            }
        }

    }
}
