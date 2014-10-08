using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class StockForm : DockContent
    {
        private dataDataSetTableAdapters.product_typeTableAdapter protypeAdapter = new dataDataSetTableAdapters.product_typeTableAdapter();
        private Dictionary<String, int> node_index = new Dictionary<String, int>();
        private DataTable protypeTable;
        public StockForm()
        {
            InitializeComponent();
            
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.product_type”中。您可以根据需要移动或删除它。
            this.product_typeTableAdapter.Fill0(this.dataDataSet.product_type);
            // TODO:  这行代码将数据加载到表“dataDataSet.StockSumTable”中。您可以根据需要移动或删除它。
            this.stockSumTableAdapter.Fill(this.dataDataSet.StockSumTable);

            this.storeBox.SelectedIndex = -1;
            initTree();
            TreeNode node = treeView.TopNode;
            if (node != null)
            {
                node.Expand();
                TreeNode n = node.FirstNode;
                if (n != null)
                    treeView.SelectedNode = n;
                else
                    treeView.SelectedNode = node;
            }
        }
        private void showSum() 
        {
            var rows = from KuGuan.dataDataSet.product_stockRow row in this.dataDataSet.product_stock.Rows
                       select row;
            tNumBox.Text = rows.Sum(row => row.stock_num) + "";
            if (this.getPriceButton.Checked)
                tAmoutBox.Text = rows.Sum(row => row.get_amount) + "";
            else
                tAmoutBox.Text = rows.Sum(row => row.out_amount) + "";
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = ((TreeView)sender).SelectedNode;
            tLabel.Text = node.Text;
            this.productStockAdapter.FillByType(this.dataDataSet.product_stock, (int)node.Tag);
            showSum();

        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            String cus = nameBox.Text.Trim();
            decimal minPrice = 0;
            decimal maxPrice = 0;
            decimal minNum = 0;
            decimal maxNum = 0;
            try
            {
                minPrice = Decimal.Parse(minPriceBox.Text);
            }
            catch (FormatException)
            {

            }
            try
            {
                maxPrice = Decimal.Parse(maxPriceBox.Text);
            }
            catch (FormatException)
            {

            }
            try
            {
                minNum = Decimal.Parse(minNumBox.Text);
            }
            catch (FormatException)
            {

            }
            try
            {
                maxNum = Decimal.Parse(maxNumBox.Text);
            }
            catch (FormatException)
            {

            }

            if (minPrice > maxPrice && maxPrice > 0|| minNum > maxNum && maxNum > 0)
            {
                MessageBox.Show("价格或数量的最小值大于最大值!");
                return;
            }
            TreeNode node = this.treeView.SelectedNode;
            if (node != null)
            {
                if(getPriceButton.Checked)
                    productStockAdapter.FillByCondition1(this.dataDataSet.product_stock, 
                        (int)node.Tag, cus, 
                        minPrice, maxPrice,
                        minNum,maxNum);
                else
                    productStockAdapter.FillByCondition2(this.dataDataSet.product_stock,
                        (int)node.Tag, cus,
                        minPrice, maxPrice,
                        minNum, maxNum);

                showSum();
            }
           

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            minNumBox.Text = "";
            maxNumBox.Text = "";
            minPriceBox.Text = "";
            maxPriceBox.Text = "";
            TreeNode node = this.treeView.SelectedNode;
            if (node != null)
            {
                this.productStockAdapter.FillByType(this.dataDataSet.product_stock, (int)node.Tag);
                showSum();
            }
           
        }


        private void getPriceButton_CheckedChanged(object sender, EventArgs e)
        {
            this.sumpriceBox.DataBindings.Clear();
            this.sumpriceBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockSumTableBindingSource, "get_sum", true));
            PriceColumn.DataPropertyName = "get_price";
            AmountColumn.DataPropertyName = "get_amount";
            showSum();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            this.sumpriceBox.DataBindings.Clear();
            this.sumpriceBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockSumTableBindingSource, "out_sum", true));
            PriceColumn.DataPropertyName = "out_price";
            AmountColumn.DataPropertyName = "out_amount";
            showSum();
        }

        private void allcalcButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allcalcButton.Checked)
            {
                this.storeBox.SelectedValue = -1;
                this.stockSumTableAdapter.Fill(this.dataDataSet.StockSumTable);
            }
            
        }

        private void singlecalcButton_CheckedChanged(object sender, EventArgs e)
        {
            if (singlecalcButton.Checked == true)
            {
                this.storeBox.Focus();
                if(this.storeBox.SelectedValue == null)
                    this.storeBox.DroppedDown = true;
                
            }
        }

        private void storeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int store_id = -1;
            if (storeBox.SelectedValue != null)
                store_id = (int)storeBox.SelectedValue;
            if (store_id != -1)
            {
                singlecalcButton.Checked = true;
                this.stockSumTableAdapter.FillById(this.dataDataSet.StockSumTable, store_id);
            }
            else
            {
                allcalcButton.Checked = true;
            }
        }

        private void storeBox_DropDownClosed(object sender, EventArgs e)
        {
            if (storeBox.SelectedValue == null)
                allcalcButton.Checked = true;
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

        private bool isNum(string s)
        {
            Regex reg = new Regex("^\\d+(\\.\\d{0,11})?$");
            return reg.IsMatch(s);
        }
        private void minPriceBox_TextChanged(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            if (b.Text == "")
                return;
            if (!isNum(b.Text))
                b.Text = "";
        }

        private void minPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == '.' || e.KeyChar == '\b'))
                e.Handled = true; 
        }

    }
}
