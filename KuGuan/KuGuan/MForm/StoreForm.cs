using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class StoreForm : DockContent
    {
        private kuguanDataSetTableAdapters.product_typeTableAdapter protypeAdapter = new kuguanDataSetTableAdapters.product_typeTableAdapter();

        private DataTable protypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String, int>();
        private bool isChoose = false;
        private int parent_id;
        private string parent_name;
        private int id;
        private string sname;

        public int ParentId { get { return parent_id; } }
        public int Id { get { return id; } }
        public string ParentName { get { return parent_name; } }
        public string SName { get { return sname; } }
        public StoreForm()
        {
            InitializeComponent();
        }
        public StoreForm(bool isChoose)
        {
            InitializeComponent();
            treeView.LabelEdit = false;
            this.isChoose = isChoose;
            if(isChoose)
            {
                initTree();
                addNextButton.Enabled = false;
                addButton.Enabled = false;
            }
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            if(!isChoose)
            {
                initTree();
                addNextButton.Enabled = false;
                addButton.Enabled = false;
            }
        }

        private void noneFunc(object p) { }

        private void addButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;

            TreeNode newNode = new TreeNode("【新类别】");
            newNode.Tag = -1;
            if (node == null || node.Level == 0)
            {
                newNode.ImageIndex = 0;
                treeView.Nodes.Add(newNode);

            }
            else
            {
                newNode.ImageIndex = 1;
                node.Parent.Nodes.Add(newNode);
            }
            treeView.SelectedNode = newNode;
            newNode.BeginEdit();
        }

        private void addNextButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;

            TreeNode newNode = new TreeNode("【新类别】");
            newNode.ImageIndex = 1;
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
                        kuguanDataSetTableAdapters.ProductStockAdapter psta = new kuguanDataSetTableAdapters.ProductStockAdapter();
                        kuguanDataSetTableAdapters.accountTableAdapter ata = new kuguanDataSetTableAdapters.accountTableAdapter();
                        kuguanDataSetTableAdapters.outTableAdapter ota = new kuguanDataSetTableAdapters.outTableAdapter();
                        kuguanDataSetTableAdapters.storageTableAdapter sta = new kuguanDataSetTableAdapters.storageTableAdapter();
                        kuguanDataSetTableAdapters.exchangeTableAdapter eta = new kuguanDataSetTableAdapters.exchangeTableAdapter();
                        psta.DeleteBySid(id);
                        ata.DeleteBySid(id);
                        ota.DeleteBySid(id);
                        sta.DeleteBySid(id);
                        eta.DeleteBySid(id);
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
                        kuguanDataSetTableAdapters.ProductStockAdapter psta = new kuguanDataSetTableAdapters.ProductStockAdapter();
                        kuguanDataSetTableAdapters.accountTableAdapter ata = new kuguanDataSetTableAdapters.accountTableAdapter();
                        kuguanDataSetTableAdapters.outTableAdapter ota = new kuguanDataSetTableAdapters.outTableAdapter();
                        kuguanDataSetTableAdapters.storageTableAdapter sta = new kuguanDataSetTableAdapters.storageTableAdapter();
                        kuguanDataSetTableAdapters.exchangeTableAdapter eta = new kuguanDataSetTableAdapters.exchangeTableAdapter();
                        psta.DeleteByTid(id);
                        ata.DeleteByTid(id);
                        ota.DeleteByTid(id);
                        sta.DeleteByTid(id);
                        eta.DeleteByTid(id);

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
                parent_node.BackColor = Color.Bisque;
                parent_node.ImageIndex = type_class - 1;
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
            if (id != -1 && name != "" && name != e.Node.Text)
            {
                this.protypeAdapter.UpdateTypeById(name, id);
            }
            else
            {
                if (e.Node.Level == 0)
                    this.protypeAdapter.AddType(name, 1, 0);
                else
                {
                    this.protypeAdapter.AddType(name, 2, (int)e.Node.Parent.Tag);
                }
                e.Node.Tag = this.protypeAdapter.GetNewId();
            }
        }

        private void treeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {


            Rectangle imgBounds = new Rectangle(new Point(0, e.Bounds.Top), new Size(treeView.Width, 22));
            Point textPoint = new Point(imgBounds.Left + 16+10*e.Node.Level, imgBounds.Top + 1);  //节点文本左上角坐标，预留了节点前加减号的位置。
            e.Graphics.DrawImage(imageList.Images[e.Node.Level], imgBounds);     
            Pen pen = new Pen(Brushes.Black);      //根节点字体颜色

            e.Graphics.DrawString(e.Node.Text, new Font("宋体", 12), Brushes.Black, textPoint);

        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 1)
            { 
                TreeNode n = e.Node;
                this.parent_id = (int)n.Parent.Tag;
                this.parent_name = n.Parent.Text;
                this.id = (int)n.Tag;
                this.sname = n.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    
    }
}
