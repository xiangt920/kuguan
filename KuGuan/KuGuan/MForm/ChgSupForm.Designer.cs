namespace KuGuan.MForm
{
    partial class ChgSupForm
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
            System.Windows.Forms.Label supplier_nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label linkmanLabel;
            System.Windows.Forms.Label phone1Label;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label urlLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label opening_bankLabel;
            System.Windows.Forms.Label bank_accountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChgSupForm));
            this.dataDataSet = new KuGuan.kuguanDataSet();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new KuGuan.kuguanDataSetTableAdapters.supplierTableAdapter();
            this.tableAdapterManager = new KuGuan.kuguanDataSetTableAdapters.TableAdapterManager();
            this.supplier_nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.linkmanTextBox = new System.Windows.Forms.TextBox();
            this.phone1TextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.opening_bankTextBox = new System.Windows.Forms.TextBox();
            this.bank_accountTextBox = new System.Windows.Forms.TextBox();
            this.cfmButton = new System.Windows.Forms.Button();
            this.cnlButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            supplier_nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            linkmanLabel = new System.Windows.Forms.Label();
            phone1Label = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            opening_bankLabel = new System.Windows.Forms.Label();
            bank_accountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_nameLabel
            // 
            supplier_nameLabel.AutoSize = true;
            supplier_nameLabel.Location = new System.Drawing.Point(23, 13);
            supplier_nameLabel.Name = "supplier_nameLabel";
            supplier_nameLabel.Size = new System.Drawing.Size(47, 12);
            supplier_nameLabel.TabIndex = 3;
            supplier_nameLabel.Text = "供应商:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(23, 46);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(35, 12);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "地址:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(23, 79);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 12);
            codeLabel.TabIndex = 9;
            codeLabel.Text = "邮编:";
            // 
            // linkmanLabel
            // 
            linkmanLabel.AutoSize = true;
            linkmanLabel.Location = new System.Drawing.Point(23, 112);
            linkmanLabel.Name = "linkmanLabel";
            linkmanLabel.Size = new System.Drawing.Size(47, 12);
            linkmanLabel.TabIndex = 11;
            linkmanLabel.Text = "联系人:";
            // 
            // phone1Label
            // 
            phone1Label.AutoSize = true;
            phone1Label.Location = new System.Drawing.Point(23, 145);
            phone1Label.Name = "phone1Label";
            phone1Label.Size = new System.Drawing.Size(59, 12);
            phone1Label.TabIndex = 13;
            phone1Label.Text = "联系电话:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(23, 178);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(35, 12);
            faxLabel.TabIndex = 15;
            faxLabel.Text = "传真:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(23, 211);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(35, 12);
            urlLabel.TabIndex = 17;
            urlLabel.Text = "网址:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 244);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 12);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "邮箱:";
            // 
            // opening_bankLabel
            // 
            opening_bankLabel.AutoSize = true;
            opening_bankLabel.Location = new System.Drawing.Point(23, 277);
            opening_bankLabel.Name = "opening_bankLabel";
            opening_bankLabel.Size = new System.Drawing.Size(47, 12);
            opening_bankLabel.TabIndex = 21;
            opening_bankLabel.Text = "开户行:";
            // 
            // bank_accountLabel
            // 
            bank_accountLabel.AutoSize = true;
            bank_accountLabel.Location = new System.Drawing.Point(23, 310);
            bank_accountLabel.Name = "bank_accountLabel";
            bank_accountLabel.Size = new System.Drawing.Size(59, 12);
            bank_accountLabel.TabIndex = 23;
            bank_accountLabel.Text = "银行账户:";
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.dataDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.supplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KuGuan.kuguanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // supplier_nameTextBox
            // 
            this.supplier_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_name", true));
            this.supplier_nameTextBox.Location = new System.Drawing.Point(118, 10);
            this.supplier_nameTextBox.Name = "supplier_nameTextBox";
            this.supplier_nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.supplier_nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(118, 43);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 21);
            this.addressTextBox.TabIndex = 8;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(118, 76);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 21);
            this.codeTextBox.TabIndex = 10;
            // 
            // linkmanTextBox
            // 
            this.linkmanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "linkman", true));
            this.linkmanTextBox.Location = new System.Drawing.Point(118, 109);
            this.linkmanTextBox.Name = "linkmanTextBox";
            this.linkmanTextBox.Size = new System.Drawing.Size(100, 21);
            this.linkmanTextBox.TabIndex = 12;
            // 
            // phone1TextBox
            // 
            this.phone1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "phone1", true));
            this.phone1TextBox.Location = new System.Drawing.Point(118, 142);
            this.phone1TextBox.Name = "phone1TextBox";
            this.phone1TextBox.Size = new System.Drawing.Size(100, 21);
            this.phone1TextBox.TabIndex = 14;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(118, 175);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(100, 21);
            this.faxTextBox.TabIndex = 16;
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(118, 208);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(100, 21);
            this.urlTextBox.TabIndex = 18;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(118, 241);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 21);
            this.emailTextBox.TabIndex = 20;
            // 
            // opening_bankTextBox
            // 
            this.opening_bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "opening_bank", true));
            this.opening_bankTextBox.Location = new System.Drawing.Point(118, 274);
            this.opening_bankTextBox.Name = "opening_bankTextBox";
            this.opening_bankTextBox.Size = new System.Drawing.Size(100, 21);
            this.opening_bankTextBox.TabIndex = 22;
            // 
            // bank_accountTextBox
            // 
            this.bank_accountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "bank_account", true));
            this.bank_accountTextBox.Location = new System.Drawing.Point(118, 307);
            this.bank_accountTextBox.Name = "bank_accountTextBox";
            this.bank_accountTextBox.Size = new System.Drawing.Size(100, 21);
            this.bank_accountTextBox.TabIndex = 24;
            // 
            // cfmButton
            // 
            this.cfmButton.Image = global::KuGuan.Properties.Resources.ok;
            this.cfmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cfmButton.Location = new System.Drawing.Point(25, 347);
            this.cfmButton.Name = "cfmButton";
            this.cfmButton.Size = new System.Drawing.Size(75, 34);
            this.cfmButton.TabIndex = 25;
            this.cfmButton.Text = "确认";
            this.cfmButton.UseVisualStyleBackColor = true;
            this.cfmButton.Click += new System.EventHandler(this.cfmButton_Click);
            // 
            // cnlButton
            // 
            this.cnlButton.Image = global::KuGuan.Properties.Resources.no;
            this.cnlButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cnlButton.Location = new System.Drawing.Point(118, 347);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(75, 34);
            this.cnlButton.TabIndex = 26;
            this.cnlButton.Text = "取消";
            this.cnlButton.UseVisualStyleBackColor = true;
            this.cnlButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_type", true));
            this.typeBox.Location = new System.Drawing.Point(-760, 176);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 21);
            this.typeBox.TabIndex = 27;
            // 
            // idBox
            // 
            this.idBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_id", true));
            this.idBox.Location = new System.Drawing.Point(-7600, 186);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 21);
            this.idBox.TabIndex = 28;
            // 
            // ChgSupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 401);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.cnlButton);
            this.Controls.Add(this.cfmButton);
            this.Controls.Add(supplier_nameLabel);
            this.Controls.Add(this.supplier_nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(linkmanLabel);
            this.Controls.Add(this.linkmanTextBox);
            this.Controls.Add(phone1Label);
            this.Controls.Add(this.phone1TextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(opening_bankLabel);
            this.Controls.Add(this.opening_bankTextBox);
            this.Controls.Add(bank_accountLabel);
            this.Controls.Add(this.bank_accountTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChgSupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChgSupForm";
            this.Load += new System.EventHandler(this.ChgSupForm_Load);
            this.Shown += new System.EventHandler(this.ChgSupForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kuguanDataSet dataDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private kuguanDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private kuguanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox supplier_nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox linkmanTextBox;
        private System.Windows.Forms.TextBox phone1TextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox opening_bankTextBox;
        private System.Windows.Forms.TextBox bank_accountTextBox;
        private System.Windows.Forms.Button cfmButton;
        private System.Windows.Forms.Button cnlButton;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox idBox;

    }
}