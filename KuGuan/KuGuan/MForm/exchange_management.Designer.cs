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
            this.exchangeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromhouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tohouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchange_managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.dataDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proIdBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.proNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toHouseBox = new System.Windows.Forms.ComboBox();
            this.storehouseBindingSource_02 = new System.Windows.Forms.BindingSource(this.components);
            this.fromHouseBox = new System.Windows.Forms.ComboBox();
            this.storehouseBindingSource_01 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oIdBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exchange_managementTableAdapter = new KuGuan.dataDataSetTableAdapters.exchange_managementTableAdapter();
            this.tableAdapterManager = new KuGuan.dataDataSetTableAdapters.TableAdapterManager();
            this.unitTableAdapter = new KuGuan.dataDataSetTableAdapters.unitTableAdapter();
            this.storehouseTableAdapter = new KuGuan.dataDataSetTableAdapters.storehouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchange_managementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource_01)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exchangeidDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.exchangenumDataGridViewTextBoxColumn,
            this.getpriceDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.fromhouseDataGridViewTextBoxColumn,
            this.tohouseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exchange_managementBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(271, 309);
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
            this.dataGridView1.Size = new System.Drawing.Size(905, 189);
            this.dataGridView1.TabIndex = 29;
            // 
            // exchangeidDataGridViewTextBoxColumn
            // 
            this.exchangeidDataGridViewTextBoxColumn.DataPropertyName = "exchange_id";
            this.exchangeidDataGridViewTextBoxColumn.HeaderText = "凭证号";
            this.exchangeidDataGridViewTextBoxColumn.Name = "exchangeidDataGridViewTextBoxColumn";
            this.exchangeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "时间";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exchangenumDataGridViewTextBoxColumn
            // 
            this.exchangenumDataGridViewTextBoxColumn.DataPropertyName = "exchange_num";
            this.exchangenumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.exchangenumDataGridViewTextBoxColumn.Name = "exchangenumDataGridViewTextBoxColumn";
            this.exchangenumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getpriceDataGridViewTextBoxColumn
            // 
            this.getpriceDataGridViewTextBoxColumn.DataPropertyName = "get_price";
            this.getpriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.getpriceDataGridViewTextBoxColumn.Name = "getpriceDataGridViewTextBoxColumn";
            this.getpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromhouseDataGridViewTextBoxColumn
            // 
            this.fromhouseDataGridViewTextBoxColumn.DataPropertyName = "from_house";
            this.fromhouseDataGridViewTextBoxColumn.HeaderText = "调出仓库";
            this.fromhouseDataGridViewTextBoxColumn.Name = "fromhouseDataGridViewTextBoxColumn";
            this.fromhouseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tohouseDataGridViewTextBoxColumn
            // 
            this.tohouseDataGridViewTextBoxColumn.DataPropertyName = "to_house";
            this.tohouseDataGridViewTextBoxColumn.HeaderText = "调入仓库";
            this.tohouseDataGridViewTextBoxColumn.Name = "tohouseDataGridViewTextBoxColumn";
            this.tohouseDataGridViewTextBoxColumn.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Location = new System.Drawing.Point(271, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 238);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(384, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "选择货品";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proIdBox);
            this.groupBox1.Controls.Add(this.unitBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.stockBox);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numUpDown);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.proNameBox);
            this.groupBox1.Location = new System.Drawing.Point(384, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 153);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // proIdBox
            // 
            this.proIdBox.Location = new System.Drawing.Point(93, 30);
            this.proIdBox.Name = "proIdBox";
            this.proIdBox.ReadOnly = true;
            this.proIdBox.Size = new System.Drawing.Size(121, 21);
            this.proIdBox.TabIndex = 13;
            this.proIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.proIdBox.Click += new System.EventHandler(this.choose_product);
            // 
            // unitBox
            // 
            this.unitBox.DataSource = this.unitBindingSource;
            this.unitBox.DisplayMember = "unit";
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Location = new System.Drawing.Point(283, 108);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(121, 20);
            this.unitBox.TabIndex = 12;
            this.unitBox.ValueMember = "unit_id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "unit";
            this.unitBindingSource.DataSource = this.dataDataSet;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 6;
            this.label15.Text = "货品编号：";
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(283, 31);
            this.stockBox.Name = "stockBox";
            this.stockBox.ReadOnly = true;
            this.stockBox.Size = new System.Drawing.Size(121, 21);
            this.stockBox.TabIndex = 22;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(283, 67);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(121, 21);
            this.priceBox.TabIndex = 14;
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(236, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 21;
            this.label18.Text = "库存：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "单位：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "数量：";
            // 
            // numUpDown
            // 
            this.numUpDown.DecimalPlaces = 5;
            this.numUpDown.Location = new System.Drawing.Point(93, 108);
            this.numUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(121, 21);
            this.numUpDown.TabIndex = 15;
            this.numUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "单价：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "货品名称：";
            // 
            // proNameBox
            // 
            this.proNameBox.Location = new System.Drawing.Point(93, 67);
            this.proNameBox.Name = "proNameBox";
            this.proNameBox.ReadOnly = true;
            this.proNameBox.Size = new System.Drawing.Size(121, 21);
            this.proNameBox.TabIndex = 17;
            this.proNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.proNameBox.Click += new System.EventHandler(this.choose_product);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "仓库设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toHouseBox);
            this.groupBox2.Controls.Add(this.fromHouseBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(30, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 153);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // toHouseBox
            // 
            this.toHouseBox.DataSource = this.storehouseBindingSource_02;
            this.toHouseBox.DisplayMember = "storehouse_name";
            this.toHouseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toHouseBox.FormattingEnabled = true;
            this.toHouseBox.Location = new System.Drawing.Point(121, 79);
            this.toHouseBox.Name = "toHouseBox";
            this.toHouseBox.Size = new System.Drawing.Size(184, 20);
            this.toHouseBox.TabIndex = 29;
            this.toHouseBox.ValueMember = "storehouse_id";
            // 
            // storehouseBindingSource_02
            // 
            this.storehouseBindingSource_02.DataMember = "storehouse";
            this.storehouseBindingSource_02.DataSource = this.dataDataSet;
            // 
            // fromHouseBox
            // 
            this.fromHouseBox.DataSource = this.storehouseBindingSource_01;
            this.fromHouseBox.DisplayMember = "storehouse_name";
            this.fromHouseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromHouseBox.FormattingEnabled = true;
            this.fromHouseBox.Location = new System.Drawing.Point(121, 44);
            this.fromHouseBox.Name = "fromHouseBox";
            this.fromHouseBox.Size = new System.Drawing.Size(184, 20);
            this.fromHouseBox.TabIndex = 27;
            this.fromHouseBox.ValueMember = "storehouse_id";
            // 
            // storehouseBindingSource_01
            // 
            this.storehouseBindingSource_01.DataMember = "storehouse";
            this.storehouseBindingSource_01.DataSource = this.dataDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "调入仓库：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "调出仓库：";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(749, 189);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(131, 23);
            this.AddButton.TabIndex = 23;
            this.AddButton.Text = "添加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.show_on_list);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(633, 27);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 21);
            this.datePicker.TabIndex = 26;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_TabIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(269, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "凭证号：";
            // 
            // oIdBox
            // 
            this.oIdBox.BackColor = System.Drawing.SystemColors.Control;
            this.oIdBox.Location = new System.Drawing.Point(328, 27);
            this.oIdBox.Name = "oIdBox";
            this.oIdBox.ReadOnly = true;
            this.oIdBox.Size = new System.Drawing.Size(200, 21);
            this.oIdBox.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Image = global::KuGuan.Properties.Resources._13_2007522133019__conew1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(271, 504);
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
            this.button3.Location = new System.Drawing.Point(382, 504);
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
            this.button2.Location = new System.Drawing.Point(1071, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "确认保存单据";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // storehouseTableAdapter
            // 
            this.storehouseTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.exchange_managementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource_01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.BindingSource storehouseBindingSource_01;
        private dataDataSetTableAdapters.storehouseTableAdapter storehouseTableAdapter;
        public System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromhouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tohouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox toHouseBox;
        private System.Windows.Forms.ComboBox fromHouseBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource storehouseBindingSource_02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox proIdBox;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox proNameBox;
    }
}