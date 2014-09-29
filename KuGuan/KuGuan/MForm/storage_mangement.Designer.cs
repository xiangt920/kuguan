namespace KuGuan.MForm
{
    partial class storage_mangement
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
            System.Windows.Forms.Label storage_idLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label storehouse_idLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label customer_id1Label;
            System.Windows.Forms.Label customer_nameLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label get_priceLabel;
            System.Windows.Forms.Label storage_numLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storage_mangement));
            this.dataDataSet = new KuGuan.dataDataSet();
            this.tableAdapterManager = new KuGuan.dataDataSetTableAdapters.TableAdapterManager();
            this.storage_managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storage_managementTableAdapter = new KuGuan.dataDataSetTableAdapters.storage_managementTableAdapter();
            this.storage_idTextBox = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.storehouse_idTextBox = new System.Windows.Forms.TextBox();
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.customer_id1TextBox = new System.Windows.Forms.TextBox();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.get_priceTextBox = new System.Windows.Forms.TextBox();
            this.storage_numTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.productTableAdapter = new KuGuan.dataDataSetTableAdapters.productTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            storage_idLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            storehouse_idLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            customer_id1Label = new System.Windows.Forms.Label();
            customer_nameLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            get_priceLabel = new System.Windows.Forms.Label();
            storage_numLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storage_managementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // storage_idLabel
            // 
            storage_idLabel.AutoSize = true;
            storage_idLabel.Location = new System.Drawing.Point(12, 9);
            storage_idLabel.Name = "storage_idLabel";
            storage_idLabel.Size = new System.Drawing.Size(71, 12);
            storage_idLabel.TabIndex = 2;
            storage_idLabel.Text = "storage id:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(12, 47);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(35, 12);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "time:";
            // 
            // storehouse_idLabel
            // 
            storehouse_idLabel.AutoSize = true;
            storehouse_idLabel.Location = new System.Drawing.Point(12, 94);
            storehouse_idLabel.Name = "storehouse_idLabel";
            storehouse_idLabel.Size = new System.Drawing.Size(89, 12);
            storehouse_idLabel.TabIndex = 8;
            storehouse_idLabel.Text = "storehouse id:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(382, 12);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(71, 12);
            product_idLabel.TabIndex = 10;
            product_idLabel.Text = "product id:";
            // 
            // customer_id1Label
            // 
            customer_id1Label.AutoSize = true;
            customer_id1Label.Location = new System.Drawing.Point(12, 134);
            customer_id1Label.Name = "customer_id1Label";
            customer_id1Label.Size = new System.Drawing.Size(77, 12);
            customer_id1Label.TabIndex = 12;
            customer_id1Label.Text = "customer id:";
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.Location = new System.Drawing.Point(382, 134);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(89, 12);
            customer_nameLabel.TabIndex = 14;
            customer_nameLabel.Text = "customer name:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(382, 47);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(83, 12);
            product_nameLabel.TabIndex = 20;
            product_nameLabel.Text = "product name:";
            // 
            // get_priceLabel
            // 
            get_priceLabel.AutoSize = true;
            get_priceLabel.Location = new System.Drawing.Point(382, 94);
            get_priceLabel.Name = "get_priceLabel";
            get_priceLabel.Size = new System.Drawing.Size(65, 12);
            get_priceLabel.TabIndex = 22;
            get_priceLabel.Text = "get price:";
            // 
            // storage_numLabel
            // 
            storage_numLabel.AutoSize = true;
            storage_numLabel.Location = new System.Drawing.Point(12, 168);
            storage_numLabel.Name = "storage_numLabel";
            storage_numLabel.Size = new System.Drawing.Size(77, 12);
            storage_numLabel.TabIndex = 26;
            storage_numLabel.Text = "storage num:";
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customer_typeTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KuGuan.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //this.tableAdapterManager.userTableAdapter = null;
            // 
            // storage_managementBindingSource
            // 
            this.storage_managementBindingSource.DataMember = "storage_management";
            this.storage_managementBindingSource.DataSource = this.dataDataSet;
            // 
            // storage_managementTableAdapter
            // 
            this.storage_managementTableAdapter.ClearBeforeFill = true;
            // 
            // storage_idTextBox
            // 
            this.storage_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storage_managementBindingSource, "storage_id", true));
            this.storage_idTextBox.Location = new System.Drawing.Point(124, 9);
            this.storage_idTextBox.Name = "storage_idTextBox";
            this.storage_idTextBox.Size = new System.Drawing.Size(200, 21);
            this.storage_idTextBox.TabIndex = 3;
            this.storage_idTextBox.TextChanged += new System.EventHandler(this.storage_idTextBox_TextChanged);
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storage_managementBindingSource, "time", true));
            this.timeDateTimePicker.Location = new System.Drawing.Point(124, 47);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.timeDateTimePicker.TabIndex = 5;
            // 
            // storehouse_idTextBox
            // 
            this.storehouse_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storage_managementBindingSource, "storehouse_id", true));
            this.storehouse_idTextBox.Location = new System.Drawing.Point(124, 91);
            this.storehouse_idTextBox.Name = "storehouse_idTextBox";
            this.storehouse_idTextBox.Size = new System.Drawing.Size(200, 21);
            this.storehouse_idTextBox.TabIndex = 9;
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storage_managementBindingSource, "product_id", true));
            this.product_idTextBox.Location = new System.Drawing.Point(478, 9);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(200, 21);
            this.product_idTextBox.TabIndex = 11;
            // 
            // customer_id1TextBox
            // 
            this.customer_id1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storage_managementBindingSource, "customer_id1", true));
            this.customer_id1TextBox.Location = new System.Drawing.Point(124, 131);
            this.customer_id1TextBox.Name = "customer_id1TextBox";
            this.customer_id1TextBox.Size = new System.Drawing.Size(200, 21);
            this.customer_id1TextBox.TabIndex = 13;
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storage_managementBindingSource, "customer_name", true));
            this.customer_nameTextBox.Location = new System.Drawing.Point(478, 131);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(200, 21);
            this.customer_nameTextBox.TabIndex = 15;
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storage_managementBindingSource, "product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(478, 47);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(200, 21);
            this.product_nameTextBox.TabIndex = 21;
            // 
            // get_priceTextBox
            // 
            this.get_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storage_managementBindingSource, "get_price", true));
            this.get_priceTextBox.Location = new System.Drawing.Point(478, 91);
            this.get_priceTextBox.Name = "get_priceTextBox";
            this.get_priceTextBox.Size = new System.Drawing.Size(200, 21);
            this.get_priceTextBox.TabIndex = 23;
            // 
            // storage_numTextBox
            // 
            this.storage_numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storage_managementBindingSource, "storage_num", true));
            this.storage_numTextBox.Location = new System.Drawing.Point(124, 165);
            this.storage_numTextBox.Name = "storage_numTextBox";
            this.storage_numTextBox.Size = new System.Drawing.Size(200, 21);
            this.storage_numTextBox.TabIndex = 27;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(31, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = null;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = null;
            this.productBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 496);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(698, 25);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.dataDataSet;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(14, 192);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 23;
            this.productDataGridView.Size = new System.Drawing.Size(664, 220);
            this.productDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "get_price";
            this.dataGridViewTextBoxColumn3.HeaderText = "get_price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "out_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "out_price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "unit_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "unit_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "product_introduce";
            this.dataGridViewTextBoxColumn6.HeaderText = "product_introduce";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "unit_id1";
            this.dataGridViewTextBoxColumn7.HeaderText = "unit_id1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "unit";
            this.dataGridViewTextBoxColumn8.HeaderText = "unit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // storage_mangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 521);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(storage_idLabel);
            this.Controls.Add(this.storage_idTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeDateTimePicker);
            this.Controls.Add(storehouse_idLabel);
            this.Controls.Add(this.storehouse_idTextBox);
            this.Controls.Add(product_idLabel);
            this.Controls.Add(this.product_idTextBox);
            this.Controls.Add(customer_id1Label);
            this.Controls.Add(this.customer_id1TextBox);
            this.Controls.Add(customer_nameLabel);
            this.Controls.Add(this.customer_nameTextBox);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(get_priceLabel);
            this.Controls.Add(this.get_priceTextBox);
            this.Controls.Add(storage_numLabel);
            this.Controls.Add(this.storage_numTextBox);
            this.Controls.Add(this.productBindingNavigator);
            this.Name = "storage_mangement";
            this.Text = "storage_mangement";
            this.Load += new System.EventHandler(this.storage_mangement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storage_managementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataDataSet dataDataSet;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource storage_managementBindingSource;
        private dataDataSetTableAdapters.storage_managementTableAdapter storage_managementTableAdapter;
        private System.Windows.Forms.TextBox storage_idTextBox;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
        private System.Windows.Forms.TextBox storehouse_idTextBox;
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.TextBox customer_id1TextBox;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox get_priceTextBox;
        private System.Windows.Forms.TextBox storage_numTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.BindingSource productBindingSource;
        private dataDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}