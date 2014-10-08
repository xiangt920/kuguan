namespace KuGuan.MForm
{
    partial class StockForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxNumBox = new System.Windows.Forms.TextBox();
            this.minNumBox = new System.Windows.Forms.TextBox();
            this.maxPriceBox = new System.Windows.Forms.TextBox();
            this.minPriceBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.dataDataSet();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.getPriceButton = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.singlecalcButton = new System.Windows.Forms.RadioButton();
            this.allcalcButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.storeBox = new System.Windows.Forms.ComboBox();
            this.producttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sumpriceBox = new System.Windows.Forms.TextBox();
            this.stockSumTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumnumBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productTableAdapter = new KuGuan.dataDataSetTableAdapters.productTableAdapter();
            this.stockSumTableAdapter = new KuGuan.dataDataSetTableAdapters.StockSumTableAdapter();
            this.product_typeTableAdapter = new KuGuan.dataDataSetTableAdapters.product_typeTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocknumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productintroduceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.productStockAdapter = new KuGuan.dataDataSetTableAdapters.ProductStockAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tAmoutBox = new System.Windows.Forms.TextBox();
            this.tNumBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockSumTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstockBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxNumBox);
            this.groupBox2.Controls.Add(this.minNumBox);
            this.groupBox2.Controls.Add(this.maxPriceBox);
            this.groupBox2.Controls.Add(this.minPriceBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(215, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(1021, 54);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // maxNumBox
            // 
            this.maxNumBox.Location = new System.Drawing.Point(689, 19);
            this.maxNumBox.Name = "maxNumBox";
            this.maxNumBox.Size = new System.Drawing.Size(111, 21);
            this.maxNumBox.TabIndex = 20;
            this.maxNumBox.TextChanged += new System.EventHandler(this.minPriceBox_TextChanged);
            this.maxNumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minPriceBox_KeyPress);
            // 
            // minNumBox
            // 
            this.minNumBox.Location = new System.Drawing.Point(550, 19);
            this.minNumBox.Name = "minNumBox";
            this.minNumBox.Size = new System.Drawing.Size(111, 21);
            this.minNumBox.TabIndex = 19;
            this.minNumBox.TextChanged += new System.EventHandler(this.minPriceBox_TextChanged);
            this.minNumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minPriceBox_KeyPress);
            // 
            // maxPriceBox
            // 
            this.maxPriceBox.Location = new System.Drawing.Point(378, 19);
            this.maxPriceBox.Name = "maxPriceBox";
            this.maxPriceBox.Size = new System.Drawing.Size(111, 21);
            this.maxPriceBox.TabIndex = 18;
            this.maxPriceBox.TextChanged += new System.EventHandler(this.minPriceBox_TextChanged);
            this.maxPriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minPriceBox_KeyPress);
            // 
            // minPriceBox
            // 
            this.minPriceBox.Location = new System.Drawing.Point(238, 19);
            this.minPriceBox.Name = "minPriceBox";
            this.minPriceBox.Size = new System.Drawing.Size(111, 21);
            this.minPriceBox.TabIndex = 17;
            this.minPriceBox.TextChanged += new System.EventHandler(this.minPriceBox_TextChanged);
            this.minPriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minPriceBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(666, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "~~";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(503, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "数量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "~~";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "单价：";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(935, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 38);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(87, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(84, 21);
            this.nameBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "产品名称：";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1242, 487);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(87, 38);
            this.refreshButton.TabIndex = 24;
            this.refreshButton.Text = "刷新列表";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.storeBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(977, 100);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.getPriceButton);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(522, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 36);
            this.panel2.TabIndex = 12;
            // 
            // getPriceButton
            // 
            this.getPriceButton.AutoSize = true;
            this.getPriceButton.Checked = true;
            this.getPriceButton.Location = new System.Drawing.Point(15, 9);
            this.getPriceButton.Name = "getPriceButton";
            this.getPriceButton.Size = new System.Drawing.Size(95, 16);
            this.getPriceButton.TabIndex = 5;
            this.getPriceButton.TabStop = true;
            this.getPriceButton.Text = "按进货价核算";
            this.getPriceButton.UseVisualStyleBackColor = true;
            this.getPriceButton.CheckedChanged += new System.EventHandler(this.getPriceButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(116, 9);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 16);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "按出货价核算";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.singlecalcButton);
            this.panel1.Controls.Add(this.allcalcButton);
            this.panel1.Location = new System.Drawing.Point(207, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 36);
            this.panel1.TabIndex = 11;
            // 
            // singlecalcButton
            // 
            this.singlecalcButton.AutoSize = true;
            this.singlecalcButton.Location = new System.Drawing.Point(15, 9);
            this.singlecalcButton.Name = "singlecalcButton";
            this.singlecalcButton.Size = new System.Drawing.Size(95, 16);
            this.singlecalcButton.TabIndex = 5;
            this.singlecalcButton.Text = "单个仓库核算";
            this.singlecalcButton.UseVisualStyleBackColor = true;
            this.singlecalcButton.CheckedChanged += new System.EventHandler(this.singlecalcButton_CheckedChanged);
            // 
            // allcalcButton
            // 
            this.allcalcButton.AutoSize = true;
            this.allcalcButton.Checked = true;
            this.allcalcButton.Location = new System.Drawing.Point(116, 9);
            this.allcalcButton.Name = "allcalcButton";
            this.allcalcButton.Size = new System.Drawing.Size(119, 16);
            this.allcalcButton.TabIndex = 6;
            this.allcalcButton.TabStop = true;
            this.allcalcButton.Text = "所有仓库汇总核算";
            this.allcalcButton.UseVisualStyleBackColor = true;
            this.allcalcButton.CheckedChanged += new System.EventHandler(this.allcalcButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "仓库：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storeBox
            // 
            this.storeBox.DataSource = this.producttypeBindingSource;
            this.storeBox.DisplayMember = "product_type";
            this.storeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeBox.FormattingEnabled = true;
            this.storeBox.Location = new System.Drawing.Point(54, 20);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(141, 20);
            this.storeBox.TabIndex = 0;
            this.storeBox.ValueMember = "product_type_id";
            this.storeBox.SelectedIndexChanged += new System.EventHandler(this.storeBox_SelectedIndexChanged);
            this.storeBox.DropDownClosed += new System.EventHandler(this.storeBox_DropDownClosed);
            // 
            // producttypeBindingSource
            // 
            this.producttypeBindingSource.DataMember = "product_type";
            this.producttypeBindingSource.DataSource = this.dataDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sumpriceBox);
            this.groupBox4.Controls.Add(this.sumnumBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(991, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 100);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // sumpriceBox
            // 
            this.sumpriceBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockSumTableBindingSource, "get_sum", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00000000000"));
            this.sumpriceBox.Location = new System.Drawing.Point(83, 58);
            this.sumpriceBox.Name = "sumpriceBox";
            this.sumpriceBox.ReadOnly = true;
            this.sumpriceBox.Size = new System.Drawing.Size(203, 21);
            this.sumpriceBox.TabIndex = 3;
            this.sumpriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stockSumTableBindingSource
            // 
            this.stockSumTableBindingSource.DataMember = "StockSumTable";
            this.stockSumTableBindingSource.DataSource = this.dataDataSet;
            // 
            // sumnumBox
            // 
            this.sumnumBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockSumTableBindingSource, "num_sum", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00000"));
            this.sumnumBox.Location = new System.Drawing.Point(83, 20);
            this.sumnumBox.Name = "sumnumBox";
            this.sumnumBox.ReadOnly = true;
            this.sumnumBox.Size = new System.Drawing.Size(203, 21);
            this.sumnumBox.TabIndex = 2;
            this.sumnumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "库存总金额：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "库存总数量：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // stockSumTableAdapter
            // 
            this.stockSumTableAdapter.ClearBeforeFill = true;
            // 
            // product_typeTableAdapter
            // 
            this.product_typeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.PriceColumn,
            this.stocknumDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.AmountColumn,
            this.productintroduceDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.productstockBindingSource;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView.Location = new System.Drawing.Point(215, 139);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1114, 286);
            this.dataGridView.TabIndex = 32;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "货品编号";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "货品名称";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "get_price";
            this.PriceColumn.HeaderText = "单价";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 150;
            // 
            // stocknumDataGridViewTextBoxColumn
            // 
            this.stocknumDataGridViewTextBoxColumn.DataPropertyName = "stock_num";
            this.stocknumDataGridViewTextBoxColumn.HeaderText = "库存";
            this.stocknumDataGridViewTextBoxColumn.Name = "stocknumDataGridViewTextBoxColumn";
            this.stocknumDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocknumDataGridViewTextBoxColumn.Width = 120;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "计量单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "get_amount";
            this.AmountColumn.HeaderText = "总金额";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 150;
            // 
            // productintroduceDataGridViewTextBoxColumn
            // 
            this.productintroduceDataGridViewTextBoxColumn.DataPropertyName = "product_introduce";
            this.productintroduceDataGridViewTextBoxColumn.HeaderText = "描述";
            this.productintroduceDataGridViewTextBoxColumn.Name = "productintroduceDataGridViewTextBoxColumn";
            this.productintroduceDataGridViewTextBoxColumn.ReadOnly = true;
            this.productintroduceDataGridViewTextBoxColumn.Width = 270;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarkDataGridViewTextBoxColumn.Width = 121;
            // 
            // productstockBindingSource
            // 
            this.productstockBindingSource.DataMember = "product_stock";
            this.productstockBindingSource.DataSource = this.dataDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Location = new System.Drawing.Point(8, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 453);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仓库";
            // 
            // tLabel
            // 
            this.tLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tLabel.ForeColor = System.Drawing.Color.Red;
            this.tLabel.Location = new System.Drawing.Point(66, 424);
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
            this.label1.Location = new System.Drawing.Point(7, 428);
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
            this.treeView.Size = new System.Drawing.Size(189, 387);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // productStockAdapter
            // 
            this.productStockAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tAmoutBox);
            this.panel3.Controls.Add(this.tNumBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(215, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1114, 41);
            this.panel3.TabIndex = 33;
            // 
            // tAmoutBox
            // 
            this.tAmoutBox.Location = new System.Drawing.Point(340, 9);
            this.tAmoutBox.Name = "tAmoutBox";
            this.tAmoutBox.ReadOnly = true;
            this.tAmoutBox.Size = new System.Drawing.Size(139, 21);
            this.tAmoutBox.TabIndex = 3;
            // 
            // tNumBox
            // 
            this.tNumBox.Location = new System.Drawing.Point(86, 9);
            this.tNumBox.Name = "tNumBox";
            this.tNumBox.ReadOnly = true;
            this.tNumBox.Size = new System.Drawing.Size(139, 21);
            this.tNumBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "本类金额合计";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "本类数量合计";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.refreshButton);
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "库存查询";
            this.Text = "库存查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockSumTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstockBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dataDataSetTableAdapters.productTableAdapter productTableAdapter;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox storeBox;
        private System.Windows.Forms.TextBox sumpriceBox;
        private System.Windows.Forms.TextBox sumnumBox;
        private System.Windows.Forms.BindingSource stockSumTableBindingSource;
        private dataDataSetTableAdapters.StockSumTableAdapter stockSumTableAdapter;
        private System.Windows.Forms.RadioButton allcalcButton;
        private System.Windows.Forms.RadioButton singlecalcButton;
        private System.Windows.Forms.RadioButton getPriceButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource producttypeBindingSource;
        private dataDataSetTableAdapters.product_typeTableAdapter product_typeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.BindingSource productstockBindingSource;
        private dataDataSetTableAdapters.ProductStockAdapter productStockAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tAmoutBox;
        private System.Windows.Forms.TextBox tNumBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productintroduceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxNumBox;
        private System.Windows.Forms.TextBox minNumBox;
        private System.Windows.Forms.TextBox maxPriceBox;
        private System.Windows.Forms.TextBox minPriceBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}