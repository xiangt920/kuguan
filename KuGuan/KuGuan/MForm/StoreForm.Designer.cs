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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.dataDataSet = new KuGuan.kuguanDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addNextButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.product_typeTableAdapter = new KuGuan.kuguanDataSetTableAdapters.product_typeTableAdapter();
            this.producttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new KuGuan.kuguanDataSetTableAdapters.TableAdapterManager();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNextButton);
            this.groupBox1.Controls.Add(this.delButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.tLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Location = new System.Drawing.Point(294, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 568);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仓库";
            // 
            // addNextButton
            // 
            this.addNextButton.Location = new System.Drawing.Point(70, 525);
            this.addNextButton.Name = "addNextButton";
            this.addNextButton.Size = new System.Drawing.Size(63, 35);
            this.addNextButton.TabIndex = 5;
            this.addNextButton.Text = "增加下层";
            this.addNextButton.UseVisualStyleBackColor = true;
            this.addNextButton.Click += new System.EventHandler(this.addNextButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(135, 525);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(61, 35);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "删除类别";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 525);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 35);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "增加同层";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tLabel
            // 
            this.tLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tLabel.ForeColor = System.Drawing.Color.Red;
            this.tLabel.Location = new System.Drawing.Point(66, 493);
            this.tLabel.Name = "tLabel";
            this.tLabel.ReadOnly = true;
            this.tLabel.Size = new System.Drawing.Size(129, 21);
            this.tLabel.TabIndex = 2;
            this.tLabel.TabStop = false;
            this.tLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前类别";
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(6, 20);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(189, 457);
            this.treeView.TabIndex = 0;
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_AfterLabelEdit);
            this.treeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView_DrawNode);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // product_typeTableAdapter
            // 
            this.product_typeTableAdapter.ClearBeforeFill = true;
            // 
            // producttypeBindingSource
            // 
            this.producttypeBindingSource.DataMember = "product_type";
            this.producttypeBindingSource.DataSource = this.dataDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.custodianTableAdapter = null;
            this.tableAdapterManager.customer_typeTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.exchangeTableAdapter = null;
            this.tableAdapterManager.outTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = this.product_typeTableAdapter;
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
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1.jpg");
            this.imageList.Images.SetKeyName(1, "2.jpg");
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1354, 578);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "仓库设置";
            this.Text = "仓库设置";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kuguanDataSet dataDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addNextButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox tLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView;
        private kuguanDataSetTableAdapters.product_typeTableAdapter product_typeTableAdapter;
        private System.Windows.Forms.BindingSource producttypeBindingSource;
        private kuguanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ImageList imageList;
    }
}