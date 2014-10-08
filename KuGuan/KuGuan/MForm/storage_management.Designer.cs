namespace KuGuan.MForm
{
    partial class storage_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storage_management));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.producttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.dataDataSet();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.get_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storage_managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.storage_managementTableAdapter = new KuGuan.dataDataSetTableAdapters.storage_managementTableAdapter();
            this.tableAdapterManager = new KuGuan.dataDataSetTableAdapters.TableAdapterManager();
            this.unitTableAdapter = new KuGuan.dataDataSetTableAdapters.unitTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.engBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.storeBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supIdBox = new System.Windows.Forms.TextBox();
            this.supNameBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proIdBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.specBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.proNameBox = new System.Windows.Forms.TextBox();
            this.product_typeTableAdapter = new KuGuan.dataDataSetTableAdapters.product_typeTableAdapter();
            this.stockTableAdapter = new KuGuan.dataDataSetTableAdapters.stockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storage_managementBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sidBox
            // 
            this.sidBox.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.sidBox, "sidBox");
            this.sidBox.Name = "sidBox";
            this.sidBox.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // datePicker
            // 
            resources.ApplyResources(this.datePicker, "datePicker");
            this.datePicker.Name = "datePicker";
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_TabIndexChanged);
            this.datePicker.TabIndexChanged += new System.EventHandler(this.dateTimePicker1_TabIndexChanged);
            this.datePicker.TabStopChanged += new System.EventHandler(this.dateTimePicker1_TabIndexChanged);
            // 
            // producttypeBindingSource
            // 
            this.producttypeBindingSource.DataMember = "product_type";
            this.producttypeBindingSource.DataSource = this.dataDataSet;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProIdCol,
            this.pronameDataGridViewTextBoxColumn,
            this.spec,
            this.get_price,
            this.numDataGridViewTextBoxColumn,
            this.unitnameDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storage_managementBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // ProIdCol
            // 
            this.ProIdCol.DataPropertyName = "product_id";
            resources.ApplyResources(this.ProIdCol, "ProIdCol");
            this.ProIdCol.Name = "ProIdCol";
            this.ProIdCol.ReadOnly = true;
            // 
            // pronameDataGridViewTextBoxColumn
            // 
            this.pronameDataGridViewTextBoxColumn.DataPropertyName = "pro_name";
            resources.ApplyResources(this.pronameDataGridViewTextBoxColumn, "pronameDataGridViewTextBoxColumn");
            this.pronameDataGridViewTextBoxColumn.Name = "pronameDataGridViewTextBoxColumn";
            this.pronameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spec
            // 
            this.spec.DataPropertyName = "spec";
            resources.ApplyResources(this.spec, "spec");
            this.spec.Name = "spec";
            this.spec.ReadOnly = true;
            // 
            // get_price
            // 
            this.get_price.DataPropertyName = "get_price";
            resources.ApplyResources(this.get_price, "get_price");
            this.get_price.Name = "get_price";
            this.get_price.ReadOnly = true;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            resources.ApplyResources(this.numDataGridViewTextBoxColumn, "numDataGridViewTextBoxColumn");
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitnameDataGridViewTextBoxColumn
            // 
            this.unitnameDataGridViewTextBoxColumn.DataPropertyName = "unit_name";
            resources.ApplyResources(this.unitnameDataGridViewTextBoxColumn, "unitnameDataGridViewTextBoxColumn");
            this.unitnameDataGridViewTextBoxColumn.Name = "unitnameDataGridViewTextBoxColumn";
            this.unitnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            resources.ApplyResources(this.totalpriceDataGridViewTextBoxColumn, "totalpriceDataGridViewTextBoxColumn");
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storage_managementBindingSource
            // 
            this.storage_managementBindingSource.DataMember = "storage_management";
            this.storage_managementBindingSource.DataSource = this.dataDataSet;
            // 
            // button2
            // 
            this.button2.Image = global::KuGuan.Properties.Resources.ok;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::KuGuan.Properties.Resources.no;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::KuGuan.Properties.Resources._13_2007522133019__conew1;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // storage_managementTableAdapter
            // 
            this.storage_managementTableAdapter.ClearBeforeFill = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Name = "label7";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.engBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.storeBox);
            this.groupBox3.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // engBox
            // 
            resources.ApplyResources(this.engBox, "engBox");
            this.engBox.Name = "engBox";
            this.engBox.ReadOnly = true;
            this.engBox.Click += new System.EventHandler(this.storeBox_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // storeBox
            // 
            resources.ApplyResources(this.storeBox, "storeBox");
            this.storeBox.Name = "storeBox";
            this.storeBox.ReadOnly = true;
            this.storeBox.Click += new System.EventHandler(this.storeBox_Click);
            this.storeBox.TextChanged += new System.EventHandler(this.storeBox_TextChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Name = "label17";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supIdBox);
            this.groupBox2.Controls.Add(this.supNameBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // supIdBox
            // 
            resources.ApplyResources(this.supIdBox, "supIdBox");
            this.supIdBox.Name = "supIdBox";
            this.supIdBox.ReadOnly = true;
            this.supIdBox.Click += new System.EventHandler(this.choose_supplier);
            // 
            // supNameBox
            // 
            this.supNameBox.FormattingEnabled = true;
            resources.ApplyResources(this.supNameBox, "supNameBox");
            this.supNameBox.Name = "supNameBox";
            this.supNameBox.Click += new System.EventHandler(this.choose_supplier);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Name = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proIdBox);
            this.groupBox1.Controls.Add(this.unitBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.specBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numUpDown);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.proNameBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // proIdBox
            // 
            resources.ApplyResources(this.proIdBox, "proIdBox");
            this.proIdBox.Name = "proIdBox";
            this.proIdBox.ReadOnly = true;
            this.proIdBox.Click += new System.EventHandler(this.choose_product);
            // 
            // unitBox
            // 
            this.unitBox.DataSource = this.unitBindingSource;
            this.unitBox.DisplayMember = "unit";
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            resources.ApplyResources(this.unitBox, "unitBox");
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Name = "unitBox";
            this.unitBox.ValueMember = "unit_id";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // specBox
            // 
            resources.ApplyResources(this.specBox, "specBox");
            this.specBox.Name = "specBox";
            this.specBox.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_on_list);
            // 
            // priceBox
            // 
            resources.ApplyResources(this.priceBox, "priceBox");
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // numUpDown
            // 
            this.numUpDown.DecimalPlaces = 5;
            resources.ApplyResources(this.numUpDown, "numUpDown");
            this.numUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // proNameBox
            // 
            resources.ApplyResources(this.proNameBox, "proNameBox");
            this.proNameBox.Name = "proNameBox";
            this.proNameBox.ReadOnly = true;
            this.proNameBox.Click += new System.EventHandler(this.choose_product);
            // 
            // product_typeTableAdapter
            // 
            this.product_typeTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // storage_management
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sidBox);
            this.HideOnClose = true;
            this.Name = "storage_management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.storage_management_FormClosing);
            this.Load += new System.EventHandler(this.storage_management_Load);
            this.Shown += new System.EventHandler(this.storage_management_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storage_managementBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sidBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource storage_managementBindingSource;
        private dataDataSetTableAdapters.storage_managementTableAdapter storage_managementTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dataDataSetTableAdapters.unitTableAdapter unitTableAdapter;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox supIdBox;
        private System.Windows.Forms.ComboBox supNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox proIdBox;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox specBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox proNameBox;
        private System.Windows.Forms.BindingSource producttypeBindingSource;
        private dataDataSetTableAdapters.product_typeTableAdapter product_typeTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox engBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox storeBox;
        private dataDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn get_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
    }
}