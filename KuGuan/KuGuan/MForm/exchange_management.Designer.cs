namespace KuGuan.MForm
{
    partial class exchange_management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oIdBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.outengBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outstoreBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inengBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.instoreBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.exchange_managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.dataDataSet();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exchange_managementTableAdapter = new KuGuan.dataDataSetTableAdapters.exchange_managementTableAdapter();
            this.tableAdapterManager = new KuGuan.dataDataSetTableAdapters.TableAdapterManager();
            this.unitTableAdapter = new KuGuan.dataDataSetTableAdapters.unitTableAdapter();
            this.ProIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchange_managementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIdCol,
            this.productnameDataGridViewTextBoxColumn,
            this.specCol,
            this.getpriceDataGridViewTextBoxColumn,
            this.exchangenumDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exchange_managementBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(204, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(945, 189);
            this.dataGridView1.TabIndex = 29;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(505, 30);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 21);
            this.datePicker.TabIndex = 26;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_TabIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(155, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "凭证号：";
            // 
            // oIdBox
            // 
            this.oIdBox.BackColor = System.Drawing.SystemColors.Control;
            this.oIdBox.Location = new System.Drawing.Point(214, 30);
            this.oIdBox.Name = "oIdBox";
            this.oIdBox.ReadOnly = true;
            this.oIdBox.Size = new System.Drawing.Size(200, 21);
            this.oIdBox.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Image = global::KuGuan.Properties.Resources._13_2007522133019__conew1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(204, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 34);
            this.button4.TabIndex = 32;
            this.button4.Text = "清空所有项";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::KuGuan.Properties.Resources.no;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(315, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 31;
            this.button3.Text = "删除选中项";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::KuGuan.Properties.Resources.ok;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1044, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "确认保存单据";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proView);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 178);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // proView
            // 
            this.proView.AllowUserToAddRows = false;
            this.proView.AllowUserToDeleteRows = false;
            this.proView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.proView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.proView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProIdCol,
            this.ProNameCol,
            this.StockCol,
            this.NumCol});
            this.proView.GridColor = System.Drawing.SystemColors.Control;
            this.proView.Location = new System.Drawing.Point(7, 21);
            this.proView.Name = "proView";
            this.proView.RowHeadersVisible = false;
            this.proView.RowTemplate.Height = 23;
            this.proView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.proView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proView.Size = new System.Drawing.Size(415, 151);
            this.proView.TabIndex = 0;
            this.proView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.proView_CellBeginEdit);
            this.proView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proView_CellClick);
            this.proView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.proView_CellEndEdit);
            this.proView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.proView_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "选择货品";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.outengBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.outstoreBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(454, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 178);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // outengBox
            // 
            this.outengBox.Location = new System.Drawing.Point(92, 82);
            this.outengBox.Name = "outengBox";
            this.outengBox.ReadOnly = true;
            this.outengBox.Size = new System.Drawing.Size(114, 21);
            this.outengBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(24, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "工程：";
            // 
            // outstoreBox
            // 
            this.outstoreBox.Location = new System.Drawing.Point(92, 45);
            this.outstoreBox.Name = "outstoreBox";
            this.outstoreBox.ReadOnly = true;
            this.outstoreBox.Size = new System.Drawing.Size(114, 21);
            this.outstoreBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "仓库：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(454, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "调出仓库";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inengBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.instoreBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(704, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 178);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // inengBox
            // 
            this.inengBox.Location = new System.Drawing.Point(92, 82);
            this.inengBox.Name = "inengBox";
            this.inengBox.ReadOnly = true;
            this.inengBox.Size = new System.Drawing.Size(114, 21);
            this.inengBox.TabIndex = 8;
            this.inengBox.Click += new System.EventHandler(this.instoreBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(24, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "工程：";
            // 
            // instoreBox
            // 
            this.instoreBox.Location = new System.Drawing.Point(92, 45);
            this.instoreBox.Name = "instoreBox";
            this.instoreBox.ReadOnly = true;
            this.instoreBox.Size = new System.Drawing.Size(114, 21);
            this.instoreBox.TabIndex = 6;
            this.instoreBox.Click += new System.EventHandler(this.instoreBox_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(24, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "仓库：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(704, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "调入仓库";
            this.label3.Click += new System.EventHandler(this.instoreBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(204, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 236);
            this.panel2.TabIndex = 27;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(849, 204);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 27);
            this.addButton.TabIndex = 42;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.show_on_list);
            // 
            // exchange_managementBindingSource
            // 
            this.exchange_managementBindingSource.DataMember = "exchange_management";
            this.exchange_managementBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "unit";
            this.unitBindingSource.DataSource = this.dataDataSet;
            // 
            // exchange_managementTableAdapter
            // 
            this.exchange_managementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customer_typeTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.storehouseTableAdapter = null;
            this.tableAdapterManager.supplier_typeTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KuGuan.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // ProIdCol
            // 
            this.ProIdCol.HeaderText = "编号";
            this.ProIdCol.Name = "ProIdCol";
            this.ProIdCol.ReadOnly = true;
            this.ProIdCol.Width = 60;
            // 
            // ProNameCol
            // 
            this.ProNameCol.HeaderText = "产品名称";
            this.ProNameCol.Name = "ProNameCol";
            this.ProNameCol.ReadOnly = true;
            this.ProNameCol.Width = 80;
            // 
            // StockCol
            // 
            this.StockCol.HeaderText = "库存";
            this.StockCol.Name = "StockCol";
            this.StockCol.ReadOnly = true;
            this.StockCol.Width = 120;
            // 
            // NumCol
            // 
            this.NumCol.HeaderText = "数量";
            this.NumCol.Name = "NumCol";
            this.NumCol.Width = 110;
            // 
            // ProductIdCol
            // 
            this.ProductIdCol.DataPropertyName = "product_id";
            this.ProductIdCol.HeaderText = "货品编号";
            this.ProductIdCol.Name = "ProductIdCol";
            this.ProductIdCol.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "货品名称";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // specCol
            // 
            this.specCol.DataPropertyName = "spec";
            this.specCol.HeaderText = "规格";
            this.specCol.Name = "specCol";
            this.specCol.ReadOnly = true;
            // 
            // getpriceDataGridViewTextBoxColumn
            // 
            this.getpriceDataGridViewTextBoxColumn.DataPropertyName = "get_price";
            this.getpriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.getpriceDataGridViewTextBoxColumn.Name = "getpriceDataGridViewTextBoxColumn";
            this.getpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.getpriceDataGridViewTextBoxColumn.Width = 180;
            // 
            // exchangenumDataGridViewTextBoxColumn
            // 
            this.exchangenumDataGridViewTextBoxColumn.DataPropertyName = "exchange_num";
            this.exchangenumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.exchangenumDataGridViewTextBoxColumn.Name = "exchangenumDataGridViewTextBoxColumn";
            this.exchangenumDataGridViewTextBoxColumn.ReadOnly = true;
            this.exchangenumDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 72;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalpriceDataGridViewTextBoxColumn.Width = 180;
            // 
            // exchange_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 579);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oIdBox);
            this.HideOnClose = true;
            this.Name = "exchange_management";
            this.TabText = "调库管理";
            this.Text = "调库管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exchange_management_FormClosing);
            this.Load += new System.EventHandler(this.exchange_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchange_managementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oIdBox;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource exchange_managementBindingSource;
        private dataDataSetTableAdapters.exchange_managementTableAdapter exchange_managementTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private dataDataSetTableAdapters.unitTableAdapter unitTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView proView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox outengBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outstoreBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inengBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox instoreBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn getpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
    }
}