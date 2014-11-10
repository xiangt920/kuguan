namespace KuGuan.MForm
{
    partial class UseUnitForm
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
            System.Windows.Forms.Label unit_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseUnitForm));
            this.kuguanDataSet = new KuGuan.kuguanDataSet();
            this.use_unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.use_unitTableAdapter = new KuGuan.kuguanDataSetTableAdapters.use_unitTableAdapter();
            this.tableAdapterManager = new KuGuan.kuguanDataSetTableAdapters.TableAdapterManager();
            this.unit_nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            unit_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuguanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.use_unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kuguanDataSet
            // 
            this.kuguanDataSet.DataSetName = "kuguanDataSet";
            this.kuguanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // use_unitBindingSource
            // 
            this.use_unitBindingSource.DataMember = "use_unit";
            this.use_unitBindingSource.DataSource = this.kuguanDataSet;
            // 
            // use_unitTableAdapter
            // 
            this.use_unitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.use_unitTableAdapter = this.use_unitTableAdapter;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // unit_nameLabel
            // 
            unit_nameLabel.AutoSize = true;
            unit_nameLabel.Location = new System.Drawing.Point(10, 15);
            unit_nameLabel.Name = "unit_nameLabel";
            unit_nameLabel.Size = new System.Drawing.Size(65, 12);
            unit_nameLabel.TabIndex = 1;
            unit_nameLabel.Text = "使用单位：";
            // 
            // unit_nameTextBox
            // 
            this.unit_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.use_unitBindingSource, "unit_name", true));
            this.unit_nameTextBox.Location = new System.Drawing.Point(81, 12);
            this.unit_nameTextBox.Name = "unit_nameTextBox";
            this.unit_nameTextBox.Size = new System.Drawing.Size(230, 21);
            this.unit_nameTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(219, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UseUnitForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(323, 83);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(unit_nameLabel);
            this.Controls.Add(this.unit_nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UseUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "使用单位设置";
            this.Load += new System.EventHandler(this.UseUnitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kuguanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.use_unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kuguanDataSet kuguanDataSet;
        private System.Windows.Forms.BindingSource use_unitBindingSource;
        private kuguanDataSetTableAdapters.use_unitTableAdapter use_unitTableAdapter;
        private kuguanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox unit_nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}