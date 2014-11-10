namespace KuGuan.MForm
{
    partial class out_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(out_management));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storagenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.kuguanDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.engBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.storeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cusIdBox = new System.Windows.Forms.TextBox();
            this.cusNameBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proIdBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.proNameBox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.oIdBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.out_managementTableAdapter = new KuGuan.kuguanDataSetTableAdapters.out_managementTableAdapter();
            this.tableAdapterManager = new KuGuan.kuguanDataSetTableAdapters.TableAdapterManager();
            this.stockTableAdapter = new KuGuan.kuguanDataSetTableAdapters.stockTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custBox = new System.Windows.Forms.ComboBox();
            this.custodianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.sumBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.accountTableAdapter = new KuGuan.kuguanDataSetTableAdapters.accountTableAdapter();
            this.use_unitTableAdapter = new KuGuan.kuguanDataSetTableAdapters.use_unitTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.custodianTableAdapter = new KuGuan.kuguanDataSetTableAdapters.custodianTableAdapter();
            this.undoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out_managementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custodianBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.productnameDataGridViewTextBoxColumn,
            this.spec,
            this.out_price,
            this.storagenumDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.out_managementBindingSource;
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
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(945, 165);
            this.dataGridView1.TabIndex = 29;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "货品编号";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "货品名称";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // spec
            // 
            this.spec.DataPropertyName = "spec";
            this.spec.HeaderText = "规格";
            this.spec.Name = "spec";
            this.spec.ReadOnly = true;
            // 
            // out_price
            // 
            this.out_price.DataPropertyName = "out_price";
            this.out_price.HeaderText = "单价";
            this.out_price.Name = "out_price";
            this.out_price.ReadOnly = true;
            this.out_price.Width = 180;
            // 
            // storagenumDataGridViewTextBoxColumn
            // 
            this.storagenumDataGridViewTextBoxColumn.DataPropertyName = "storage_num";
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
            this.unitDataGridViewTextBoxColumn.Width = 72;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "总价格";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalpriceDataGridViewTextBoxColumn.Width = 180;
            // 
            // out_managementBindingSource
            // 
            this.out_managementBindingSource.DataMember = "out_management";
            this.out_managementBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(204, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 236);
            this.panel2.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(704, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "选择仓库";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(450, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "选择客户";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.engBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.storeBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(704, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 196);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // engBox
            // 
            this.engBox.Location = new System.Drawing.Point(92, 82);
            this.engBox.Name = "engBox";
            this.engBox.ReadOnly = true;
            this.engBox.Size = new System.Drawing.Size(114, 21);
            this.engBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(24, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "类别：";
            // 
            // storeBox
            // 
            this.storeBox.Location = new System.Drawing.Point(92, 45);
            this.storeBox.Name = "storeBox";
            this.storeBox.ReadOnly = true;
            this.storeBox.Size = new System.Drawing.Size(114, 21);
            this.storeBox.TabIndex = 6;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cusIdBox);
            this.groupBox2.Controls.Add(this.cusNameBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(450, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 196);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // cusIdBox
            // 
            this.cusIdBox.Location = new System.Drawing.Point(108, 45);
            this.cusIdBox.Name = "cusIdBox";
            this.cusIdBox.ReadOnly = true;
            this.cusIdBox.Size = new System.Drawing.Size(103, 21);
            this.cusIdBox.TabIndex = 8;
            this.cusIdBox.Click += new System.EventHandler(this.choose_customer);
            // 
            // cusNameBox
            // 
            this.cusNameBox.FormattingEnabled = true;
            this.cusNameBox.Location = new System.Drawing.Point(108, 82);
            this.cusNameBox.Name = "cusNameBox";
            this.cusNameBox.Size = new System.Drawing.Size(103, 20);
            this.cusNameBox.TabIndex = 7;
            this.cusNameBox.Click += new System.EventHandler(this.choose_customer);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "客户编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "客户名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "选择货品";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proIdBox);
            this.groupBox1.Controls.Add(this.unitBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.stockBox);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numUpDown);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.proNameBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 196);
            this.groupBox1.TabIndex = 28;
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
            this.unitBox.Location = new System.Drawing.Point(283, 108);
            this.unitBox.Name = "unitBox";
            this.unitBox.ReadOnly = true;
            this.unitBox.Size = new System.Drawing.Size(121, 21);
            this.unitBox.TabIndex = 12;
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
            // button1
            // 
            this.button1.Image = global::KuGuan.Properties.Resources._0_conew3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(283, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_on_list);
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
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(354, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 21);
            this.datePicker.TabIndex = 26;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_TabIndexChanged);
            // 
            // oIdBox
            // 
            this.oIdBox.BackColor = System.Drawing.SystemColors.Control;
            this.oIdBox.Location = new System.Drawing.Point(63, 12);
            this.oIdBox.Name = "oIdBox";
            this.oIdBox.ReadOnly = true;
            this.oIdBox.Size = new System.Drawing.Size(200, 21);
            this.oIdBox.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Image = global::KuGuan.Properties.Resources._13_2007522133019__conew1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(204, 520);
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
            this.button3.Location = new System.Drawing.Point(315, 520);
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
            this.button2.Location = new System.Drawing.Point(1044, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "保存单据";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // out_managementTableAdapter
            // 
            this.out_managementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.custodianTableAdapter = null;
            this.tableAdapterManager.customer_typeTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.exchangeTableAdapter = null;
            this.tableAdapterManager.outTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.proTableAdapter = null;
            this.tableAdapterManager.remainTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.storageTableAdapter = null;
            this.tableAdapterManager.supplier_typeTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KuGuan.kuguanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.use_unitTableAdapter = null;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.custBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sumBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.amountBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(204, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 35);
            this.panel1.TabIndex = 34;
            // 
            // custBox
            // 
            this.custBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.custodianBindingSource, "id", true));
            this.custBox.DataSource = this.custodianBindingSource;
            this.custBox.DisplayMember = "c_name";
            this.custBox.FormattingEnabled = true;
            this.custBox.Location = new System.Drawing.Point(433, 8);
            this.custBox.Name = "custBox";
            this.custBox.Size = new System.Drawing.Size(121, 20);
            this.custBox.TabIndex = 14;
            this.custBox.ValueMember = "id";
            // 
            // custodianBindingSource
            // 
            this.custodianBindingSource.DataMember = "custodian";
            this.custodianBindingSource.DataSource = this.dataDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(384, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "保管员：";
            // 
            // sumBox
            // 
            this.sumBox.Location = new System.Drawing.Point(637, 8);
            this.sumBox.Name = "sumBox";
            this.sumBox.ReadOnly = true;
            this.sumBox.Size = new System.Drawing.Size(114, 21);
            this.sumBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(578, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "总数量：";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(825, 8);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.Size = new System.Drawing.Size(114, 21);
            this.amountBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(766, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "总金额：";
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // use_unitTableAdapter
            // 
            this.use_unitTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.oIdBox);
            this.panel3.Controls.Add(this.datePicker);
            this.panel3.Location = new System.Drawing.Point(204, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 43);
            this.panel3.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(4, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "凭证号：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(307, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "日期：";
            // 
            // custodianTableAdapter
            // 
            this.custodianTableAdapter.ClearBeforeFill = true;
            // 
            // undoButton
            // 
            this.undoButton.Enabled = false;
            this.undoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.undoButton.Location = new System.Drawing.Point(933, 520);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(105, 34);
            this.undoButton.TabIndex = 35;
            this.undoButton.Text = "撤销保存";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // out_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KuGuan.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 578);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "out_management";
            this.TabText = "出库管理";
            this.Text = "出库管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.out_management_FormClosing);
            this.Load += new System.EventHandler(this.out_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out_managementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custodianBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cusIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cusNameBox;
        private System.Windows.Forms.TextBox proNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.TextBox proIdBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox oIdBox;
        private kuguanDataSet dataDataSet;
        private System.Windows.Forms.BindingSource out_managementBindingSource;
        private kuguanDataSetTableAdapters.out_managementTableAdapter out_managementTableAdapter;
        private kuguanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox engBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox storeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn storagenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private kuguanDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sumBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label9;
        private kuguanDataSetTableAdapters.accountTableAdapter accountTableAdapter;
        private kuguanDataSetTableAdapters.use_unitTableAdapter use_unitTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox custBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource custodianBindingSource;
        private kuguanDataSetTableAdapters.custodianTableAdapter custodianTableAdapter;
        private System.Windows.Forms.Button undoButton;
    }
}