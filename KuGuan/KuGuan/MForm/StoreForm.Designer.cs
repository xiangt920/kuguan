namespace KuGuan.MForm
{
    partial class StoreForm
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
            this.storeDataGridView = new System.Windows.Forms.DataGridView();
            this.storehousenameDataGridViewImageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.dataDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.storehouseTableAdapter = new KuGuan.dataDataSetTableAdapters.storehouseTableAdapter();
            this.tableAdapterManager = new KuGuan.dataDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // storeDataGridView
            // 
            this.storeDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.storeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storehousenameDataGridViewImageColumn,
            this.storehouseidDataGridViewTextBoxColumn});
            this.storeDataGridView.DataSource = this.storehouseBindingSource;
            this.storeDataGridView.Location = new System.Drawing.Point(540, 146);
            this.storeDataGridView.Name = "storeDataGridView";
            this.storeDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.storeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.storeDataGridView.RowTemplate.Height = 23;
            this.storeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.storeDataGridView.Size = new System.Drawing.Size(207, 217);
            this.storeDataGridView.TabIndex = 6;
            // 
            // storehousenameDataGridViewImageColumn
            // 
            this.storehousenameDataGridViewImageColumn.DataPropertyName = "storehouse_name";
            dataGridViewCellStyle2.NullValue = "(点击添加仓库)";
            this.storehousenameDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.storehousenameDataGridViewImageColumn.HeaderText = "仓库名称";
            this.storehousenameDataGridViewImageColumn.Name = "storehousenameDataGridViewImageColumn";
            this.storehousenameDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.storehousenameDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.storehousenameDataGridViewImageColumn.Width = 220;
            // 
            // storehouseidDataGridViewTextBoxColumn
            // 
            this.storehouseidDataGridViewTextBoxColumn.DataPropertyName = "storehouse_id";
            this.storehouseidDataGridViewTextBoxColumn.FillWeight = 5F;
            this.storehouseidDataGridViewTextBoxColumn.HeaderText = "id";
            this.storehouseidDataGridViewTextBoxColumn.Name = "storehouseidDataGridViewTextBoxColumn";
            this.storehouseidDataGridViewTextBoxColumn.ReadOnly = true;
            this.storehouseidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.storehouseidDataGridViewTextBoxColumn.Visible = false;
            this.storehouseidDataGridViewTextBoxColumn.Width = 5;
            // 
            // storehouseBindingSource
            // 
            this.storehouseBindingSource.DataMember = "storehouse";
            this.storehouseBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "确认修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // storehouseTableAdapter
            // 
            this.storehouseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_typeTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.storehouseTableAdapter = this.storehouseTableAdapter;
            this.tableAdapterManager.supplier_typeTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KuGuan.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 578);
            this.Controls.Add(this.storeDataGridView);
            this.Controls.Add(this.button3);
            this.HideOnClose = true;
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "仓库设置";
            this.Text = "仓库设置";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView storeDataGridView;
        private System.Windows.Forms.Button button3;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource storehouseBindingSource;
        private dataDataSetTableAdapters.storehouseTableAdapter storehouseTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn storehousenameDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storehouseidDataGridViewTextBoxColumn;
    }
}