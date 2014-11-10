namespace KuGuan.MForm
{
    partial class custodian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(custodian));
            this.button3 = new System.Windows.Forms.Button();
            this.unitDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custodianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.kuguanDataSet();
            this.tableAdapterManager = new KuGuan.kuguanDataSetTableAdapters.TableAdapterManager();
            this.custodianTableAdapter = new KuGuan.kuguanDataSetTableAdapters.custodianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = global::KuGuan.Properties.Resources.ok;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(12, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "确认修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Save_Click);
            // 
            // unitDataGridView
            // 
            this.unitDataGridView.AllowUserToDeleteRows = false;
            this.unitDataGridView.AllowUserToResizeRows = false;
            this.unitDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.unitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn});
            this.unitDataGridView.DataSource = this.custodianBindingSource;
            this.unitDataGridView.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.unitDataGridView.Location = new System.Drawing.Point(12, 28);
            this.unitDataGridView.MultiSelect = false;
            this.unitDataGridView.Name = "unitDataGridView";
            this.unitDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.unitDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.unitDataGridView.RowTemplate.Height = 23;
            this.unitDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unitDataGridView.Size = new System.Drawing.Size(207, 217);
            this.unitDataGridView.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            dataGridViewCellStyle2.NullValue = "(点击添加新保管员)";
            this.cnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cnameDataGridViewTextBoxColumn.HeaderText = "保管员";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 204;
            // 
            // custodianBindingSource
            // 
            this.custodianBindingSource.DataMember = "custodian";
            this.custodianBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.custodianTableAdapter = this.custodianTableAdapter;
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
            // custodianTableAdapter
            // 
            this.custodianTableAdapter.ClearBeforeFill = true;
            // 
            // custodian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 324);
            this.Controls.Add(this.unitDataGridView);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "custodian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "保管员";
            this.Text = "保管员";
            this.Load += new System.EventHandler(this.custodian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private kuguanDataSet dataDataSet;
        private kuguanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView unitDataGridView;
        private System.Windows.Forms.BindingSource custodianBindingSource;
        private kuguanDataSetTableAdapters.custodianTableAdapter custodianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
    }
}