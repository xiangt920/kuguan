namespace KuGuan.MForm
{
    partial class OutDocForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutDocForm));
            this.OutDocView = new System.Windows.Forms.DataGridView();
            this.oidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuguanDataSet = new KuGuan.kuguanDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveExcelButton = new System.Windows.Forms.Button();
            this.PrintDocButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oidBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cusBox = new System.Windows.Forms.TextBox();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.showEngBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.showStoreBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showOidBox = new System.Windows.Forms.TextBox();
            this.showCusBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showDateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outDetailView = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storagenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outmanagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.outDocTableAdapter = new KuGuan.kuguanDataSetTableAdapters.OutDocTableAdapter();
            this.out_managementTableAdapter = new KuGuan.kuguanDataSetTableAdapters.out_managementTableAdapter();
            this.use_unitTableAdapter = new KuGuan.kuguanDataSetTableAdapters.use_unitTableAdapter();
            this.manager = new KuGuan.kuguanDataSetTableAdapters.TableAdapterManager();
            this.label12 = new System.Windows.Forms.Label();
            this.custBox = new System.Windows.Forms.ComboBox();
            this.custodianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custodianTableAdapter = new KuGuan.kuguanDataSetTableAdapters.custodianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OutDocView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuguanDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outmanagementBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custodianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OutDocView
            // 
            this.OutDocView.AllowUserToAddRows = false;
            this.OutDocView.AllowUserToDeleteRows = false;
            this.OutDocView.AllowUserToResizeRows = false;
            this.OutDocView.AutoGenerateColumns = false;
            this.OutDocView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OutDocView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutDocView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oidDataGridViewTextBoxColumn,
            this.cusnameDataGridViewTextBoxColumn});
            this.OutDocView.DataSource = this.outDocBindingSource;
            this.OutDocView.Location = new System.Drawing.Point(3, 3);
            this.OutDocView.MultiSelect = false;
            this.OutDocView.Name = "OutDocView";
            this.OutDocView.ReadOnly = true;
            this.OutDocView.RowHeadersVisible = false;
            this.OutDocView.RowTemplate.Height = 23;
            this.OutDocView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutDocView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OutDocView.Size = new System.Drawing.Size(304, 190);
            this.OutDocView.TabIndex = 0;
            this.OutDocView.SelectionChanged += new System.EventHandler(this.StorageDocView_SelectionChanged);
            // 
            // oidDataGridViewTextBoxColumn
            // 
            this.oidDataGridViewTextBoxColumn.DataPropertyName = "o_id";
            this.oidDataGridViewTextBoxColumn.HeaderText = "凭证号";
            this.oidDataGridViewTextBoxColumn.Name = "oidDataGridViewTextBoxColumn";
            this.oidDataGridViewTextBoxColumn.ReadOnly = true;
            this.oidDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusnameDataGridViewTextBoxColumn
            // 
            this.cusnameDataGridViewTextBoxColumn.DataPropertyName = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.HeaderText = "客户";
            this.cusnameDataGridViewTextBoxColumn.Name = "cusnameDataGridViewTextBoxColumn";
            this.cusnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // outDocBindingSource
            // 
            this.outDocBindingSource.DataMember = "OutDoc";
            this.outDocBindingSource.DataSource = this.kuguanDataSet;
            // 
            // kuguanDataSet
            // 
            this.kuguanDataSet.DataSetName = "kuguanDataSet";
            this.kuguanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.OutDocView);
            this.panel1.Location = new System.Drawing.Point(212, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 201);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.custBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.saveExcelButton);
            this.groupBox2.Controls.Add(this.PrintDocButton);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Location = new System.Drawing.Point(313, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // saveExcelButton
            // 
            this.saveExcelButton.Image = global::KuGuan.Properties.Resources._1_conew1;
            this.saveExcelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveExcelButton.Location = new System.Drawing.Point(580, 20);
            this.saveExcelButton.Name = "saveExcelButton";
            this.saveExcelButton.Size = new System.Drawing.Size(119, 34);
            this.saveExcelButton.TabIndex = 2;
            this.saveExcelButton.Text = "导出Excel";
            this.saveExcelButton.UseVisualStyleBackColor = true;
            this.saveExcelButton.Click += new System.EventHandler(this.saveExcelButton_Click);
            // 
            // PrintDocButton
            // 
            this.PrintDocButton.Image = global::KuGuan.Properties.Resources._10_conew1;
            this.PrintDocButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintDocButton.Location = new System.Drawing.Point(416, 20);
            this.PrintDocButton.Name = "PrintDocButton";
            this.PrintDocButton.Size = new System.Drawing.Size(119, 34);
            this.PrintDocButton.TabIndex = 1;
            this.PrintDocButton.Text = "打印单据";
            this.PrintDocButton.UseVisualStyleBackColor = true;
            this.PrintDocButton.Click += new System.EventHandler(this.PrintDocButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::KuGuan.Properties.Resources._135_conew2;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(250, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(119, 34);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oidBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cusBox);
            this.groupBox1.Controls.Add(this.toTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fromTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(313, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // oidBox
            // 
            this.oidBox.Location = new System.Drawing.Point(65, 69);
            this.oidBox.Name = "oidBox";
            this.oidBox.Size = new System.Drawing.Size(200, 21);
            this.oidBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "凭证号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "客户：";
            // 
            // cusBox
            // 
            this.cusBox.Location = new System.Drawing.Point(587, 35);
            this.cusBox.Name = "cusBox";
            this.cusBox.Size = new System.Drawing.Size(112, 21);
            this.cusBox.TabIndex = 4;
            this.cusBox.Click += new System.EventHandler(this.supBox_Click);
            // 
            // toTimePicker
            // 
            this.toTimePicker.Location = new System.Drawing.Point(314, 35);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.Size = new System.Drawing.Size(200, 21);
            this.toTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "至";
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.Location = new System.Drawing.Point(65, 35);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(200, 21);
            this.fromTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.showEngBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.showStoreBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.showOidBox);
            this.panel2.Controls.Add(this.showCusBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.showDateBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(212, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 45);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(635, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "仓库：";
            // 
            // showEngBox
            // 
            this.showEngBox.Location = new System.Drawing.Point(861, 11);
            this.showEngBox.Name = "showEngBox";
            this.showEngBox.ReadOnly = true;
            this.showEngBox.Size = new System.Drawing.Size(135, 21);
            this.showEngBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(814, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "类别：";
            // 
            // showStoreBox
            // 
            this.showStoreBox.Location = new System.Drawing.Point(694, 11);
            this.showStoreBox.Name = "showStoreBox";
            this.showStoreBox.ReadOnly = true;
            this.showStoreBox.Size = new System.Drawing.Size(114, 21);
            this.showStoreBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "客户：";
            // 
            // showOidBox
            // 
            this.showOidBox.Location = new System.Drawing.Point(299, 11);
            this.showOidBox.Name = "showOidBox";
            this.showOidBox.ReadOnly = true;
            this.showOidBox.Size = new System.Drawing.Size(151, 21);
            this.showOidBox.TabIndex = 9;
            // 
            // showCusBox
            // 
            this.showCusBox.Location = new System.Drawing.Point(503, 11);
            this.showCusBox.Name = "showCusBox";
            this.showCusBox.ReadOnly = true;
            this.showCusBox.Size = new System.Drawing.Size(126, 21);
            this.showCusBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "凭证号：";
            // 
            // showDateBox
            // 
            this.showDateBox.Location = new System.Drawing.Point(50, 11);
            this.showDateBox.Name = "showDateBox";
            this.showDateBox.ReadOnly = true;
            this.showDateBox.Size = new System.Drawing.Size(184, 21);
            this.showDateBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "日期：";
            // 
            // outDetailView
            // 
            this.outDetailView.AllowUserToAddRows = false;
            this.outDetailView.AllowUserToDeleteRows = false;
            this.outDetailView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            this.outDetailView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.outDetailView.AutoGenerateColumns = false;
            this.outDetailView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.outDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.out_price,
            this.storagenumDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.outDetailView.DataSource = this.outmanagementBindingSource;
            this.outDetailView.Location = new System.Drawing.Point(212, 270);
            this.outDetailView.Name = "outDetailView";
            this.outDetailView.ReadOnly = true;
            this.outDetailView.RowHeadersVisible = false;
            this.outDetailView.RowTemplate.Height = 23;
            this.outDetailView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outDetailView.Size = new System.Drawing.Size(1030, 220);
            this.outDetailView.TabIndex = 3;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "货品编号";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 120;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "货品名称";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 140;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "规格";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.ReadOnly = true;
            this.specDataGridViewTextBoxColumn.Width = 110;
            // 
            // out_price
            // 
            this.out_price.DataPropertyName = "out_price";
            this.out_price.HeaderText = "单价";
            this.out_price.Name = "out_price";
            this.out_price.ReadOnly = true;
            this.out_price.Width = 200;
            // 
            // storagenumDataGridViewTextBoxColumn
            // 
            this.storagenumDataGridViewTextBoxColumn.DataPropertyName = "storage_num";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.storagenumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.storagenumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.storagenumDataGridViewTextBoxColumn.Name = "storagenumDataGridViewTextBoxColumn";
            this.storagenumDataGridViewTextBoxColumn.ReadOnly = true;
            this.storagenumDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 107;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalpriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // outmanagementBindingSource
            // 
            this.outmanagementBindingSource.DataMember = "out_management";
            this.outmanagementBindingSource.DataSource = this.kuguanDataSet;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Controls.Add(this.amountBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.numBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(212, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 39);
            this.panel3.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::KuGuan.Properties.Resources._13_2007522133019__conew1;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteButton.Location = new System.Drawing.Point(920, 1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 34);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "此单作废";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(358, 9);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.Size = new System.Drawing.Size(198, 21);
            this.amountBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "金额合计：";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(74, 9);
            this.numBox.Name = "numBox";
            this.numBox.ReadOnly = true;
            this.numBox.Size = new System.Drawing.Size(198, 21);
            this.numBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "数量合计：";
            // 
            // outDocTableAdapter
            // 
            this.outDocTableAdapter.ClearBeforeFill = true;
            // 
            // out_managementTableAdapter
            // 
            this.out_managementTableAdapter.ClearBeforeFill = true;
            // 
            // use_unitTableAdapter
            // 
            this.use_unitTableAdapter.ClearBeforeFill = true;
            // 
            // manager
            // 
            this.manager.accountTableAdapter = null;
            this.manager.BackupDataSetBeforeUpdate = false;
            this.manager.Connection = null;
            this.manager.custodianTableAdapter = null;
            this.manager.customer_typeTableAdapter = null;
            this.manager.customerTableAdapter = null;
            this.manager.exchangeTableAdapter = null;
            this.manager.outTableAdapter = null;
            this.manager.product_typeTableAdapter = null;
            this.manager.proTableAdapter = null;
            this.manager.remainTableAdapter = null;
            this.manager.stockTableAdapter = null;
            this.manager.storageTableAdapter = null;
            this.manager.supplier_typeTableAdapter = null;
            this.manager.supplierTableAdapter = null;
            this.manager.unitTableAdapter = null;
            this.manager.UpdateOrder = KuGuan.kuguanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.manager.use_unitTableAdapter = null;
            this.manager.userTableAdapter = null;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "保管员：";
            // 
            // custBox
            // 
            this.custBox.DataSource = this.custodianBindingSource;
            this.custBox.DisplayMember = "c_name";
            this.custBox.FormattingEnabled = true;
            this.custBox.Location = new System.Drawing.Point(65, 28);
            this.custBox.Name = "custBox";
            this.custBox.Size = new System.Drawing.Size(121, 20);
            this.custBox.TabIndex = 4;
            this.custBox.ValueMember = "id";
            // 
            // custodianBindingSource
            // 
            this.custodianBindingSource.DataMember = "custodian";
            this.custodianBindingSource.DataSource = this.kuguanDataSet;
            // 
            // custodianTableAdapter
            // 
            this.custodianTableAdapter.ClearBeforeFill = true;
            // 
            // OutDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KuGuan.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 578);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.outDetailView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OutDocForm";
            this.TabText = "出库单据查询";
            this.Text = "出库单据查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutDocForm_FormClosing);
            this.Load += new System.EventHandler(this.StorageDocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutDocView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuguanDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outmanagementBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custodianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OutDocView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cusBox;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.TextBox oidBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveExcelButton;
        private System.Windows.Forms.Button PrintDocButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox showEngBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox showOidBox;
        private System.Windows.Forms.TextBox showCusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox showDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView outDetailView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox showStoreBox;
        private kuguanDataSet kuguanDataSet;
        private System.Windows.Forms.BindingSource outDocBindingSource;
        private kuguanDataSetTableAdapters.OutDocTableAdapter outDocTableAdapter;
        private System.Windows.Forms.BindingSource outmanagementBindingSource;
        private kuguanDataSetTableAdapters.out_managementTableAdapter out_managementTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn storagenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private kuguanDataSetTableAdapters.use_unitTableAdapter use_unitTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private kuguanDataSetTableAdapters.TableAdapterManager manager;
        private System.Windows.Forms.ComboBox custBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource custodianBindingSource;
        private kuguanDataSetTableAdapters.custodianTableAdapter custodianTableAdapter;
    }
}