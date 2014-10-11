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
    public partial class choose_stock : DockContent
    {
        private dataDataSetTableAdapters.product_typeTableAdapter protypeAdapter = new dataDataSetTableAdapters.product_typeTableAdapter();
        private dataDataSetTableAdapters.QueriesTableAdapter procAdapter = new dataDataSetTableAdapters.QueriesTableAdapter();
        private DataTable protypeTable;
        private Dictionary<String, int> node_index = new Dictionary<String, int>();
        private List<dataDataSet.product_stockRow> selectedRows = new List<dataDataSet.product_stockRow>();
        private bool isMultiSelect = false;
        private string product_id;
        private string product_name;
        private string product_in_price;
        private string product_out_price;
        private string product_unit;
        private int product_unit_id;
        private string type;
        private string pro_spec;
        private string store;
        private decimal stock;
        private int type_id;
        public string ID { get { return this.product_id; } }
        public string ProName { get { return this.product_name; } }
        public string ProSpec { get { return this.pro_spec; } }
        public string InPrice { get { return this.product_in_price; } }
        public string OutPrice { get { return this.product_out_price; } }
        public string Unit { get { return this.product_unit; } }
        public int UnitId { get { return this.product_unit_id; } }
        public string Type { get { return this.type; } }
        public string Store { get { return this.store; } }

        public int TypeId { get { return this.type_id; } }
        public decimal Stock { get { return this.stock; } }
        public List<dataDataSet.product_stockRow> SelectedRows { get { return this.selectedRows; } }
        public choose_stock()
        {
            InitializeComponent();
            ChooseColumn.Visible = false;
            initTree();
            TreeNode node = treeView.TopNode;
            if (node != null)
            {
                node.Expand();
                TreeNode n = node.FirstNode;
                if (n != null)
                    treeView.SelectedNode = n;
            }
        }
        public choose_stock(bool isMultiSelect)
        {
            InitializeComponent();
            this.isMultiSelect = isMultiSelect;
            if (isMultiSelect)
            {
                dataGridView.RowHeadersVisible = false;
                dataGridView.ReadOnly = false;
                foreach(DataGridViewColumn col in dataGridView.Columns)
                {
                    col.ReadOnly = true;
                }

                ChooseColumn.ReadOnly = false ;
                ChooseColumn.Visible = true;
                dataGridView.CellDoubleClick -= dataGridView_CellDoubleClick;
            }
            initTree();
            TreeNode node = treeView.TopNode;
            if (node != null)
            {
                node.Expand();
                TreeNode n = node.FirstNode;
                if (n != null)
                    treeView.SelectedNode = n;
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.product_stock”中。您可以根据需要移动或删除它。
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            tLabel.Text = node.Text;
            this.productStockAdapter.FillByType(this.dataDataSet.product_stock, (int)node.Tag);
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells["ChooseColumn"].Value = true;
            }
            cfmButton.Text = "选择(" + dataGridView.Rows.Count + ")";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String cus = cusBox.Text.Trim();
            TreeNode node = this.treeView.SelectedNode;
            if (node != null)
            {
                this.productStockAdapter.FillByCondition(this.dataDataSet.product_stock,(int)node.Tag, cus);
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Cells["ChooseColumn"].Value = true;
                }
                cfmButton.Text = "选择(" + dataGridView.Rows.Count + ")";
            }
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView.SelectedNode;
            if (node != null) 
            {
                this.productStockAdapter.FillByType(this.dataDataSet.product_stock, (int)node.Tag);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells["ChooseColumn"].Value = true;
            }
            cfmButton.Text = "选择(" + dataGridView.Rows.Count + ")";
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
            if (index >= 0)
            {

                var select_rows = from dataDataSet.product_stockRow r2 in this.dataDataSet.product_stock.Rows
                                  where r2.product_id == (int)dataGridView.Rows[index].Cells["productidDataGridViewTextBoxColumn"].Value
                                  select r2;
                dataDataSet.product_stockRow row = select_rows.ElementAt(0);
                this.product_id = row.product_id+"";
                this.type_id = row.product_type_id;
                this.product_unit = row.unit;
                this.product_unit_id = row.unit_id;
                this.product_name = row.product_name;
                this.product_in_price = row.get_price+"";
                this.product_out_price = row.out_price+"";
                this.pro_spec = row.spec;
                this.stock = row.stock_num;
                this.type = row.product_type;
                TreeNode n = treeView.SelectedNode;
                if (n.Level == 0)
                    this.store = n.Text;
                else
                    this.store = n.Parent.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
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

        private void cnlButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cfmButton_Click(object sender, EventArgs e)
        {
            if (isMultiSelect)
            {
                
                TreeNode n = treeView.SelectedNode;
                if (n.Level == 0)
                    this.store = n.Text;
                else
                    this.store = n.Parent.Text;
                type = "";
                var select_rows = from DataGridViewRow r1 in dataGridView.Rows
                                    join dataDataSet.product_stockRow r2 in this.dataDataSet.product_stock.Rows on (int)r1.Cells["productidDataGridViewTextBoxColumn"].Value equals r2.product_id 
                                    where r1.Cells["ChooseColumn"].Value != null && (bool)r1.Cells["ChooseColumn"].Value == true
                                    select r2;
                if (select_rows.Count() > 0)
                {
                    selectedRows.Clear();
                    selectedRows.AddRange(select_rows);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("请先一件或多件选择货品！");
                }
            }
            else
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;
                    if (index >= 0)
                    {
                        var select_rows = from dataDataSet.product_stockRow r2 in this.dataDataSet.product_stock.Rows
                                          where r2.product_id == (int)dataGridView.Rows[index].Cells["productidDataGridViewTextBoxColumn"].Value
                                          select r2;
                        dataDataSet.product_stockRow row = select_rows.ElementAt(0);
                        this.product_id = row.product_id + "";
                        this.type_id = row.product_type_id;
                        this.product_unit = row.unit;
                        this.product_name = row.product_name;
                        this.product_in_price = row.get_price + "";
                        this.product_out_price = row.out_price + "";
                        this.stock = row.stock_num;
                        this.product_unit_id = row.unit_id;
                        this.type = row.product_type;
                        this.pro_spec = row.spec;
                        TreeNode n = treeView.SelectedNode;
                        if (n.Level == 0)
                            this.store = n.Text;
                        else
                            this.store = n.Parent.Text;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("请先选择货品！");
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isMultiSelect) 
            {
                int index = e.RowIndex;
                if(index >= 0)
                {
                    DataGridViewCheckBoxCell c = (DataGridViewCheckBoxCell)dataGridView.Rows[index].Cells["ChooseColumn"];
                    if (c.Value == null)
                        c.Value = true;
                    else
                        c.Value = !(bool)c.Value;
                }
                var select_rows = from DataGridViewRow row in dataGridView.Rows
                        where row.Cells["ChooseColumn"].Value != null && (bool)row.Cells["ChooseColumn"].Value == true
                        select row;
                cfmButton.Text = "选择(" + select_rows.Count() + ")";
            }
        }

        private void choose_stock_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells["ChooseColumn"].Value = true;
            }
            cfmButton.Text = "选择(" + dataGridView.Rows.Count + ")";
        }
    
    }
}
