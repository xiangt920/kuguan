﻿namespace KuGuan.MForm
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addNextButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingbankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankaccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.kuguanDataSet();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addSupButton = new System.Windows.Forms.Button();
            this.delSupButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.linkmanBox = new System.Windows.Forms.TextBox();
            this.addrBox = new System.Windows.Forms.TextBox();
            this.supBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.supplierTableAdapter = new KuGuan.kuguanDataSetTableAdapters.supplierTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNextButton);
            this.groupBox1.Controls.Add(this.delButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.tLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Location = new System.Drawing.Point(21, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 567);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "供应商类别结构图";
            // 
            // addNextButton
            // 
            this.addNextButton.Location = new System.Drawing.Point(69, 526);
            this.addNextButton.Name = "addNextButton";
            this.addNextButton.Size = new System.Drawing.Size(63, 35);
            this.addNextButton.TabIndex = 5;
            this.addNextButton.Text = "增加下层";
            this.addNextButton.UseVisualStyleBackColor = true;
            this.addNextButton.Click += new System.EventHandler(this.addNextButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(134, 526);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(61, 35);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "删除类别";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(5, 526);
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
            this.tLabel.Location = new System.Drawing.Point(65, 494);
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
            this.label1.Location = new System.Drawing.Point(6, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前类别";
            // 
            // treeView
            // 
            this.treeView.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(6, 20);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(189, 448);
            this.treeView.TabIndex = 0;
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_AfterLabelEdit);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieridDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.linkmanDataGridViewTextBoxColumn,
            this.phone1DataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.openingbankDataGridViewTextBoxColumn,
            this.bankaccountDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.supplierBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(228, 29);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1114, 448);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "编号";
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplieridDataGridViewTextBoxColumn.Width = 70;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "供应商";
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "邮政编码";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkmanDataGridViewTextBoxColumn
            // 
            this.linkmanDataGridViewTextBoxColumn.DataPropertyName = "linkman";
            this.linkmanDataGridViewTextBoxColumn.HeaderText = "联系人";
            this.linkmanDataGridViewTextBoxColumn.Name = "linkmanDataGridViewTextBoxColumn";
            this.linkmanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phone1DataGridViewTextBoxColumn
            // 
            this.phone1DataGridViewTextBoxColumn.DataPropertyName = "phone1";
            this.phone1DataGridViewTextBoxColumn.HeaderText = "联系电话1";
            this.phone1DataGridViewTextBoxColumn.Name = "phone1DataGridViewTextBoxColumn";
            this.phone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "传真";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "网址";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "邮箱";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openingbankDataGridViewTextBoxColumn
            // 
            this.openingbankDataGridViewTextBoxColumn.DataPropertyName = "opening_bank";
            this.openingbankDataGridViewTextBoxColumn.HeaderText = "开户行";
            this.openingbankDataGridViewTextBoxColumn.Name = "openingbankDataGridViewTextBoxColumn";
            this.openingbankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankaccountDataGridViewTextBoxColumn
            // 
            this.bankaccountDataGridViewTextBoxColumn.DataPropertyName = "bank_account";
            this.bankaccountDataGridViewTextBoxColumn.HeaderText = "银行账号";
            this.bankaccountDataGridViewTextBoxColumn.Name = "bankaccountDataGridViewTextBoxColumn";
            this.bankaccountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refreshButton
            // 
            this.refreshButton.Image = global::KuGuan.Properties.Resources._11_conew3;
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshButton.Location = new System.Drawing.Point(1256, 494);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(87, 38);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "刷新列表";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addSupButton
            // 
            this.addSupButton.Image = global::KuGuan.Properties.Resources._0_conew3;
            this.addSupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addSupButton.Location = new System.Drawing.Point(228, 494);
            this.addSupButton.Name = "addSupButton";
            this.addSupButton.Size = new System.Drawing.Size(80, 38);
            this.addSupButton.TabIndex = 3;
            this.addSupButton.Text = "新增";
            this.addSupButton.UseVisualStyleBackColor = true;
            this.addSupButton.Click += new System.EventHandler(this.addSupButton_Click);
            // 
            // delSupButton
            // 
            this.delSupButton.Image = global::KuGuan.Properties.Resources.no;
            this.delSupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delSupButton.Location = new System.Drawing.Point(400, 494);
            this.delSupButton.Name = "delSupButton";
            this.delSupButton.Size = new System.Drawing.Size(80, 38);
            this.delSupButton.TabIndex = 5;
            this.delSupButton.Text = "删除";
            this.delSupButton.UseVisualStyleBackColor = true;
            this.delSupButton.Click += new System.EventHandler(this.delSupButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Image = global::KuGuan.Properties.Resources.Pencil4_conew3;
            this.changeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeButton.Location = new System.Drawing.Point(314, 494);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(80, 38);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "修改";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.linkmanBox);
            this.groupBox2.Controls.Add(this.addrBox);
            this.groupBox2.Controls.Add(this.supBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(496, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(753, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Image = global::KuGuan.Properties.Resources._135_conew2;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(667, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 38);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.search);
            // 
            // linkmanBox
            // 
            this.linkmanBox.Location = new System.Drawing.Point(539, 20);
            this.linkmanBox.Name = "linkmanBox";
            this.linkmanBox.Size = new System.Drawing.Size(100, 21);
            this.linkmanBox.TabIndex = 10;
            // 
            // addrBox
            // 
            this.addrBox.Location = new System.Drawing.Point(263, 20);
            this.addrBox.Name = "addrBox";
            this.addrBox.Size = new System.Drawing.Size(211, 21);
            this.addrBox.TabIndex = 9;
            // 
            // supBox
            // 
            this.supBox.Location = new System.Drawing.Point(104, 20);
            this.supBox.Name = "supBox";
            this.supBox.Size = new System.Drawing.Size(106, 21);
            this.supBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "联系人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "供应商名称：";
            // 
            // importButton
            // 
            this.importButton.Image = global::KuGuan.Properties.Resources._1_conew1;
            this.importButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importButton.Location = new System.Drawing.Point(314, 535);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(166, 35);
            this.importButton.TabIndex = 8;
            this.importButton.Text = "从Excel导入";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(496, 543);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(753, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1354, 578);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.delSupButton);
            this.Controls.Add(this.addSupButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierForm";
            this.TabText = "供应商设置";
            this.Text = "供应商设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SupplierForm_FormClosing);
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView dataGridView;
        private kuguanDataSet dataDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private kuguanDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.TextBox tLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addNextButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingbankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankaccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addSupButton;
        private System.Windows.Forms.Button delSupButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox linkmanBox;
        private System.Windows.Forms.TextBox addrBox;
        private System.Windows.Forms.TextBox supBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}