using KuGuan.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class ProductForm : DockContent
    {
        private kuguanDataSetTableAdapters.product_typeTableAdapter protypeAdapter = new kuguanDataSetTableAdapters.product_typeTableAdapter();
        private kuguanDataSetTableAdapters.productTableAdapter productTableAdapter = new kuguanDataSetTableAdapters.productTableAdapter();
        private DataTable protypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String, int>();
        private bool importing = false;

        public bool Importing 
        {
            get { return this.importing; }
            set { this.importing = value; }
        }

        public ProgressBar Bar
        {
            get { return this.importBar; }
        }

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
            // TODO: 这行代码将数据加载到表“dataDataSet.product_stock”中。您可以根据需要移动或删除它。
            this.productStockAdapter.Fill(this.dataDataSet.product_stock);
            // TODO:  这行代码将数据加载到表“dataDataSet.product”中。您可以根据需要移动或删除它。
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
            this.productStockAdapter.FillByType(this.dataDataSet.product_stock, (int)node.Tag);
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
                if (e.Node.Level == 0)
                    this.protypeAdapter.AddType(name, 1, 0);
                else
                {
                    this.protypeAdapter.AddType(name, 2, (int)e.Node.Parent.Tag);
                }
                e.Node.Tag = this.protypeAdapter.GetNewId();
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
                        "确定删除此类别与其所有子类别及其中全部货品？",
                        "删除 '" + node.Text + "' 类别",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        this.protypeAdapter.DeleteByParent(id);
                        this.protypeAdapter.DeleteById(id);
                        this.productStockAdapter.DeleteBySid(id);
                        kuguanDataSetTableAdapters.accountTableAdapter ata = new kuguanDataSetTableAdapters.accountTableAdapter();
                        kuguanDataSetTableAdapters.outTableAdapter ota = new kuguanDataSetTableAdapters.outTableAdapter();
                        kuguanDataSetTableAdapters.storageTableAdapter sta = new kuguanDataSetTableAdapters.storageTableAdapter();
                        kuguanDataSetTableAdapters.exchangeTableAdapter eta = new kuguanDataSetTableAdapters.exchangeTableAdapter();
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
                        "确定删除此类别及其中所有货品？",
                        "删除 '" + node.Text + "' 类别",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        this.protypeAdapter.DeleteById(id);
                        this.productStockAdapter.DeleteByTid(id);
                        kuguanDataSetTableAdapters.accountTableAdapter ata = new kuguanDataSetTableAdapters.accountTableAdapter();
                        kuguanDataSetTableAdapters.outTableAdapter ota = new kuguanDataSetTableAdapters.outTableAdapter();
                        kuguanDataSetTableAdapters.storageTableAdapter sta = new kuguanDataSetTableAdapters.storageTableAdapter();
                        kuguanDataSetTableAdapters.exchangeTableAdapter eta = new kuguanDataSetTableAdapters.exchangeTableAdapter();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            String cus = cusBox.Text.Trim();
            TreeNode node = this.treeView.SelectedNode;
            if(node == null)
            {
                MessageBox.Show(this,"请先选择货品类别！","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            
            this.productStockAdapter.FillByCondition(this.dataDataSet.product_stock,(int)node.Tag, cus);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            initTree();
        }

        private void addSupButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            if (node == null)
            {
                MessageBox.Show(this, "请先选择货品类别！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (node.Level == 0)
            {
                MessageBox.Show(this, "请先选择货品类别而不是仓库！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ChgProForm form = new ChgProForm("新增产品", -1,(int)node.Tag);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.productStockAdapter.FillByType(this.dataDataSet.product_stock,(int)node.Tag);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
            ChgProForm form = new ChgProForm("修改产品", id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                TreeNode node = this.treeView.SelectedNode;
                if (node == null)
                {
                    return;
                }
                this.productStockAdapter.FillByType(this.dataDataSet.product_stock, (int)node.Tag);
            }
        }

        private void delSupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除该产品?", "信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRowView SelectedRowView = (DataRowView)this.productstockBindingSource.Current;
                kuguanDataSet.product_stockRow selectedRow = (kuguanDataSet.product_stockRow)SelectedRowView.Row;
                kuguanDataSetTableAdapters.accountTableAdapter ata = new kuguanDataSetTableAdapters.accountTableAdapter();
                kuguanDataSetTableAdapters.outTableAdapter ota = new kuguanDataSetTableAdapters.outTableAdapter();
                kuguanDataSetTableAdapters.storageTableAdapter sta = new kuguanDataSetTableAdapters.storageTableAdapter();
                kuguanDataSetTableAdapters.exchangeTableAdapter eta = new kuguanDataSetTableAdapters.exchangeTableAdapter();
                ata.DeleteByPid(selectedRow.product_id, selectedRow.product_type_id);
                ota.DeleteByPid(selectedRow.product_id, selectedRow.product_type_id);
                sta.DeleteByPid(selectedRow.product_id, selectedRow.product_type_id);
                eta.DeleteByPid(selectedRow.product_id, selectedRow.product_type_id);
                this.productStockAdapter.DeleteById(selectedRow.product_id,selectedRow.product_type_id);
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

        public void initTree() 
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

        private void fromExcelButton_Click(object sender, EventArgs e)
        {
            if (this.importing)
            {
                MessageBox.Show("正在进行其它导入操作！\n请耐心等待导入完成后再进行此操作！");
                return;
            }
            Util.deleteBak();
            try
            {
                File.Copy(@"data\kuguan.sdf", @"data\kuguan.sdf.bak", true);
                undoButton.Enabled = true;
            }
            catch { }
            ExcelOperate excel = new ExcelOperate(this);
            excel.ImportProduct();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.importing)
            {
                MessageBox.Show("正在导入数据，无法关闭窗口");
                e.Cancel = true;
            }
            try
            {
                File.Delete(@"data\kuguan.sdf.bak");
            }
            catch { }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(@"data\kuguan.sdf.bak", @"data\kuguan.sdf", true);
                undoButton.Enabled = false;
                File.Delete(@"data\kuguan.sdf.bak");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("已进行其它操作，不可撤销！");
                undoButton.Enabled = false;
            }
            catch { }
        }

    
    }
}
