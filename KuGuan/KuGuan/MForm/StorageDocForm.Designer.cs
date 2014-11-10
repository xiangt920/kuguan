namespace KuGuan.MForm
{
    partial class StorageDocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageDocForm));
            this.StorageDocView = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.kuguanDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveExcelButton = new System.Windows.Forms.Button();
            this.PrintDocButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SidBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supBox = new System.Windows.Forms.TextBox();
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
            this.showSidBox = new System.Windows.Forms.TextBox();
            this.showSupBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showDateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storageDetailView = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storagemanagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storage_managementTableAdapter = new KuGuan.kuguanDataSetTableAdapters.storage_managementTableAdapter();
            this.storageDocTableAdapter = new KuGuan.kuguanDataSetTableAdapters.StorageDocTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.use_unitTableAdapter = new KuGuan.kuguanDataSetTableAdapters.use_unitTableAdapter();
            this.manager = new KuGuan.kuguanDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.StorageDocView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagemanagementBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StorageDocView
            // 
            this.StorageDocView.AllowUserToAddRows = false;
            this.StorageDocView.AllowUserToDeleteRows = false;
            this.StorageDocView.AllowUserToResizeRows = false;
            this.StorageDocView.AutoGenerateColumns = false;
            this.StorageDocView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.StorageDocView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageDocView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.supnameDataGridViewTextBoxColumn});
            this.StorageDocView.DataSource = this.storageDocBindingSource;
            this.StorageDocView.Location = new System.Drawing.Point(3, 3);
            this.StorageDocView.MultiSelect = false;
            this.StorageDocView.Name = "StorageDocView";
            this.StorageDocView.ReadOnly = true;
            this.StorageDocView.RowHeadersVisible = false;
            this.StorageDocView.RowTemplate.Height = 23;
            this.StorageDocView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StorageDocView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StorageDocView.Size = new System.Drawing.Size(304, 190);
            this.StorageDocView.TabIndex = 0;
            this.StorageDocView.SelectionChanged += new System.EventHandler(this.StorageDocView_SelectionChanged);
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "凭证号";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sidDataGridViewTextBoxColumn.Width = 150;
            // 
            // supnameDataGridViewTextBoxColumn
            // 
            this.supnameDataGridViewTextBoxColumn.DataPropertyName = "sup_name";
            this.supnameDataGridViewTextBoxColumn.HeaderText = "供应商";
            this.supnameDataGridViewTextBoxColumn.Name = "supnameDataGridViewTextBoxColumn";
            this.supnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // storageDocBindingSource
            // 
            this.storageDocBindingSource.DataMember = "StorageDoc";
            this.storageDocBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.StorageDocView);
            this.panel1.Location = new System.Drawing.Point(212, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 201);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
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
            this.saveExcelButton.Location = new System.Drawing.Point(414, 20);
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
            this.PrintDocButton.Location = new System.Drawing.Point(244, 20);
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
            this.searchButton.Location = new System.Drawing.Point(65, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(119, 34);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SidBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.supBox);
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
            // SidBox
            // 
            this.SidBox.Location = new System.Drawing.Point(65, 69);
            this.SidBox.Name = "SidBox";
            this.SidBox.Size = new System.Drawing.Size(200, 21);
            this.SidBox.TabIndex = 7;
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
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "供应商：";
            // 
            // supBox
            // 
            this.supBox.Location = new System.Drawing.Point(599, 35);
            this.supBox.Name = "supBox";
            this.supBox.Size = new System.Drawing.Size(100, 21);
            this.supBox.TabIndex = 4;
            this.supBox.Click += new System.EventHandler(this.supBox_Click);
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
            this.panel2.Controls.Add(this.showSidBox);
            this.panel2.Controls.Add(this.showSupBox);
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
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "供应商：";
            // 
            // showSidBox
            // 
            this.showSidBox.Location = new System.Drawing.Point(299, 11);
            this.showSidBox.Name = "showSidBox";
            this.showSidBox.ReadOnly = true;
            this.showSidBox.Size = new System.Drawing.Size(151, 21);
            this.showSidBox.TabIndex = 9;
            // 
            // showSupBox
            // 
            this.showSupBox.Location = new System.Drawing.Point(515, 11);
            this.showSupBox.Name = "showSupBox";
            this.showSupBox.ReadOnly = true;
            this.showSupBox.Size = new System.Drawing.Size(114, 21);
            this.showSupBox.TabIndex = 8;
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
            // storageDetailView
            // 
            this.storageDetailView.AllowUserToAddRows = false;
            this.storageDetailView.AllowUserToDeleteRows = false;
            this.storageDetailView.AllowUserToResizeRows = false;
            this.storageDetailView.AutoGenerateColumns = false;
            this.storageDetailView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.storageDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.pronameDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.getpriceDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.unitnameDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.storageDetailView.DataSource = this.storagemanagementBindingSource;
            this.storageDetailView.Location = new System.Drawing.Point(212, 270);
            this.storageDetailView.Name = "storageDetailView";
            this.storageDetailView.ReadOnly = true;
            this.storageDetailView.RowHeadersVisible = false;
            this.storageDetailView.RowTemplate.Height = 23;
            this.storageDetailView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.storageDetailView.Size = new System.Drawing.Size(1030, 220);
            this.storageDetailView.TabIndex = 3;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "货品编号";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 120;
            // 
            // pronameDataGridViewTextBoxColumn
            // 
            this.pronameDataGridViewTextBoxColumn.DataPropertyName = "pro_name";
            this.pronameDataGridViewTextBoxColumn.HeaderText = "货品名称";
            this.pronameDataGridViewTextBoxColumn.Name = "pronameDataGridViewTextBoxColumn";
            this.pronameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pronameDataGridViewTextBoxColumn.Width = 140;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "规格";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.ReadOnly = true;
            this.specDataGridViewTextBoxColumn.Width = 110;
            // 
            // getpriceDataGridViewTextBoxColumn
            // 
            this.getpriceDataGridViewTextBoxColumn.DataPropertyName = "get_price";
            this.getpriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.getpriceDataGridViewTextBoxColumn.Name = "getpriceDataGridViewTextBoxColumn";
            this.getpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.getpriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitnameDataGridViewTextBoxColumn
            // 
            this.unitnameDataGridViewTextBoxColumn.DataPropertyName = "unit_name";
            this.unitnameDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitnameDataGridViewTextBoxColumn.Name = "unitnameDataGridViewTextBoxColumn";
            this.unitnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitnameDataGridViewTextBoxColumn.Width = 107;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "金额";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalpriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // storagemanagementBindingSource
            // 
            this.storagemanagementBindingSource.DataMember = "storage_management";
            this.storagemanagementBindingSource.DataSource = this.dataDataSet;
            // 
            // storage_managementTableAdapter
            // 
            this.storage_managementTableAdapter.ClearBeforeFill = true;
            // 
            // storageDocTableAdapter
            // 
            this.storageDocTableAdapter.ClearBeforeFill = true;
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
            this.deleteButton.TabIndex = 21;
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
            // use_unitTableAdapter
            // 
            this.use_unitTableAdapter.ClearBeforeFill = true;
            // 
            // manager
            // 
            this.manager.accountTableAdapter = null;
            this.manager.BackupDataSetBeforeUpdate = false;
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
            this.manager.use_unitTableAdapter = this.use_unitTableAdapter;
            this.manager.userTableAdapter = null;
            // 
            // StorageDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KuGuan.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 578);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.storageDetailView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StorageDocForm";
            this.TabText = "入库单据查询";
            this.Text = "入库单据查询";
            this.Load += new System.EventHandler(this.StorageDocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorageDocView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagemanagementBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StorageDocView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supBox;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.TextBox SidBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveExcelButton;
        private System.Windows.Forms.Button PrintDocButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox showEngBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox showSidBox;
        private System.Windows.Forms.TextBox showSupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox showDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView storageDetailView;
        private kuguanDataSet dataDataSet;
        private System.Windows.Forms.BindingSource storagemanagementBindingSource;
        private kuguanDataSetTableAdapters.storage_managementTableAdapter storage_managementTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storageDocBindingSource;
        private kuguanDataSetTableAdapters.StorageDocTableAdapter storageDocTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox showStoreBox;
        private kuguanDataSetTableAdapters.use_unitTableAdapter use_unitTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private kuguanDataSetTableAdapters.TableAdapterManager manager;
    }
}