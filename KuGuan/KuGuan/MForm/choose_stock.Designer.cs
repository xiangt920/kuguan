﻿namespace KuGuan.MForm
{
    partial class choose_stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose_stock));
            this.tLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.searchButton = new System.Windows.Forms.Button();
            this.cusBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ChooseColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.get_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productintroduceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.kuguanDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cnlButton = new System.Windows.Forms.Button();
            this.cfmButton = new System.Windows.Forms.Button();
            this.productStockAdapter = new KuGuan.kuguanDataSetTableAdapters.ProductStockAdapter();
            this.chooseAllButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLabel
            // 
            this.tLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tLabel.ForeColor = System.Drawing.Color.Red;
            this.tLabel.Location = new System.Drawing.Point(66, 505);
            this.tLabel.Name = "tLabel";
            this.tLabel.ReadOnly = true;
            this.tLabel.Size = new System.Drawing.Size(129, 21);
            this.tLabel.TabIndex = 2;
            this.tLabel.TabStop = false;
            this.tLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前类别";
            // 
            // treeView
            // 
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(6, 20);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(189, 457);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::KuGuan.Properties.Resources._135_conew2;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(667, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 38);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cusBox
            // 
            this.cusBox.Location = new System.Drawing.Point(112, 19);
            this.cusBox.Name = "cusBox";
            this.cusBox.Size = new System.Drawing.Size(106, 21);
            this.cusBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "产品名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.cusBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(228, 492);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(753, 54);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Image = global::KuGuan.Properties.Resources._11_conew3;
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshButton.Location = new System.Drawing.Point(987, 503);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(97, 38);
            this.refreshButton.TabIndex = 17;
            this.refreshButton.Text = "刷新列表";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChooseColumn,
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.spec,
            this.stock_num,
            this.get_price,
            this.out_price,
            this.unitDataGridViewTextBoxColumn,
            this.productintroduceDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.productstockBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(228, 29);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1114, 457);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // ChooseColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.NullValue = false;
            this.ChooseColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ChooseColumn.HeaderText = "选择";
            this.ChooseColumn.Name = "ChooseColumn";
            this.ChooseColumn.ReadOnly = true;
            this.ChooseColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChooseColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChooseColumn.Width = 41;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "编号";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "产品名称";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spec
            // 
            this.spec.DataPropertyName = "spec";
            this.spec.HeaderText = "规格";
            this.spec.Name = "spec";
            this.spec.ReadOnly = true;
            // 
            // stock_num
            // 
            this.stock_num.DataPropertyName = "stock_num";
            this.stock_num.HeaderText = "库存";
            this.stock_num.Name = "stock_num";
            this.stock_num.ReadOnly = true;
            // 
            // get_price
            // 
            this.get_price.DataPropertyName = "get_price";
            this.get_price.HeaderText = "进货价";
            this.get_price.Name = "get_price";
            this.get_price.ReadOnly = true;
            this.get_price.Width = 150;
            // 
            // out_price
            // 
            this.out_price.DataPropertyName = "out_price";
            this.out_price.HeaderText = "出货价";
            this.out_price.Name = "out_price";
            this.out_price.ReadOnly = true;
            this.out_price.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "计量单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productintroduceDataGridViewTextBoxColumn
            // 
            this.productintroduceDataGridViewTextBoxColumn.DataPropertyName = "product_introduce";
            this.productintroduceDataGridViewTextBoxColumn.HeaderText = "产品描述";
            this.productintroduceDataGridViewTextBoxColumn.Name = "productintroduceDataGridViewTextBoxColumn";
            this.productintroduceDataGridViewTextBoxColumn.ReadOnly = true;
            this.productintroduceDataGridViewTextBoxColumn.Width = 170;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productstockBindingSource
            // 
            this.productstockBindingSource.DataMember = "product_stock";
            this.productstockBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Location = new System.Drawing.Point(21, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 537);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仓库";
            // 
            // cnlButton
            // 
            this.cnlButton.Image = global::KuGuan.Properties.Resources.no;
            this.cnlButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cnlButton.Location = new System.Drawing.Point(1255, 503);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(87, 38);
            this.cnlButton.TabIndex = 22;
            this.cnlButton.Text = "取消";
            this.cnlButton.UseVisualStyleBackColor = true;
            this.cnlButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // cfmButton
            // 
            this.cfmButton.Image = global::KuGuan.Properties.Resources.ok;
            this.cfmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cfmButton.Location = new System.Drawing.Point(1162, 503);
            this.cfmButton.Name = "cfmButton";
            this.cfmButton.Size = new System.Drawing.Size(87, 38);
            this.cfmButton.TabIndex = 23;
            this.cfmButton.Text = "选择";
            this.cfmButton.UseVisualStyleBackColor = true;
            this.cfmButton.Click += new System.EventHandler(this.cfmButton_Click);
            // 
            // productStockAdapter
            // 
            this.productStockAdapter.ClearBeforeFill = true;
            // 
            // chooseAllButton
            // 
            this.chooseAllButton.Image = global::KuGuan.Properties.Resources.ok;
            this.chooseAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chooseAllButton.Location = new System.Drawing.Point(1090, 503);
            this.chooseAllButton.Name = "chooseAllButton";
            this.chooseAllButton.Size = new System.Drawing.Size(66, 38);
            this.chooseAllButton.TabIndex = 24;
            this.chooseAllButton.Text = "全选";
            this.chooseAllButton.UseVisualStyleBackColor = true;
            this.chooseAllButton.Click += new System.EventHandler(this.chooseAllButton_Click);
            // 
            // choose_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 578);
            this.Controls.Add(this.chooseAllButton);
            this.Controls.Add(this.cfmButton);
            this.Controls.Add(this.cnlButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "choose_stock";
            this.TabText = "货品设置";
            this.Text = "选择货品";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Shown += new System.EventHandler(this.choose_stock_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox cusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private kuguanDataSet dataDataSet;
        private System.Windows.Forms.Button cnlButton;
        private System.Windows.Forms.BindingSource productstockBindingSource;
        private kuguanDataSetTableAdapters.ProductStockAdapter productStockAdapter;
        private System.Windows.Forms.Button cfmButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChooseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn get_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productintroduceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button chooseAllButton;
    }
}