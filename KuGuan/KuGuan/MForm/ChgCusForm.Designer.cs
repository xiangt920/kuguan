namespace KuGuan.MForm
{
    partial class ChgCusForm
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
            this.cnlButton = new System.Windows.Forms.Button();
            this.cfmButton = new System.Windows.Forms.Button();
            this.supplier_nameTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new KuGuan.dataDataSet();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.linkmanTextBox = new System.Windows.Forms.TextBox();
            this.phone1TextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.opening_bankTextBox = new System.Windows.Forms.TextBox();
            this.bank_accountTextBox = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new KuGuan.dataDataSetTableAdapters.customerTableAdapter();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new KuGuan.dataDataSetTableAdapters.TableAdapterManager();
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
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_nameLabel
            // 
            supplier_nameLabel.AutoSize = true;
            supplier_nameLabel.Location = new System.Drawing.Point(15, 14);
            supplier_nameLabel.Name = "supplier_nameLabel";
            supplier_nameLabel.Size = new System.Drawing.Size(35, 12);
            supplier_nameLabel.TabIndex = 27;
            supplier_nameLabel.Text = "客户:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(15, 47);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(35, 12);
            addressLabel.TabIndex = 29;
            addressLabel.Text = "地址:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(15, 80);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 12);
            codeLabel.TabIndex = 31;
            codeLabel.Text = "邮编:";
            // 
            // linkmanLabel
            // 
            linkmanLabel.AutoSize = true;
            linkmanLabel.Location = new System.Drawing.Point(15, 113);
            linkmanLabel.Name = "linkmanLabel";
            linkmanLabel.Size = new System.Drawing.Size(47, 12);
            linkmanLabel.TabIndex = 33;
            linkmanLabel.Text = "联系人:";
            // 
            // phone1Label
            // 
            phone1Label.AutoSize = true;
            phone1Label.Location = new System.Drawing.Point(15, 146);
            phone1Label.Name = "phone1Label";
            phone1Label.Size = new System.Drawing.Size(59, 12);
            phone1Label.TabIndex = 35;
            phone1Label.Text = "联系电话:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(15, 179);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(35, 12);
            faxLabel.TabIndex = 37;
            faxLabel.Text = "传真:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(15, 212);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(35, 12);
            urlLabel.TabIndex = 39;
            urlLabel.Text = "网址:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(15, 245);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 12);
            emailLabel.TabIndex = 41;
            emailLabel.Text = "邮箱:";
            // 
            // opening_bankLabel
            // 
            opening_bankLabel.AutoSize = true;
            opening_bankLabel.Location = new System.Drawing.Point(15, 278);
            opening_bankLabel.Name = "opening_bankLabel";
            opening_bankLabel.Size = new System.Drawing.Size(47, 12);
            opening_bankLabel.TabIndex = 43;
            opening_bankLabel.Text = "开户行:";
            // 
            // bank_accountLabel
            // 
            bank_accountLabel.AutoSize = true;
            bank_accountLabel.Location = new System.Drawing.Point(15, 311);
            bank_accountLabel.Name = "bank_accountLabel";
            bank_accountLabel.Size = new System.Drawing.Size(59, 12);
            bank_accountLabel.TabIndex = 45;
            bank_accountLabel.Text = "银行账户:";
            // 
            // cnlButton
            // 
            this.cnlButton.Location = new System.Drawing.Point(166, 347);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(75, 34);
            this.cnlButton.TabIndex = 48;
            this.cnlButton.Text = "取消";
            this.cnlButton.UseVisualStyleBackColor = true;
            this.cnlButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // cfmButton
            // 
            this.cfmButton.Location = new System.Drawing.Point(77, 347);
            this.cfmButton.Name = "cfmButton";
            this.cfmButton.Size = new System.Drawing.Size(75, 34);
            this.cfmButton.TabIndex = 47;
            this.cfmButton.Text = "确认";
            this.cfmButton.UseVisualStyleBackColor = true;
            this.cfmButton.Click += new System.EventHandler(this.cfmButton_Click);
            // 
            // supplier_nameTextBox
            // 
            this.supplier_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customer_name", true));
            this.supplier_nameTextBox.Location = new System.Drawing.Point(77, 11);
            this.supplier_nameTextBox.Name = "supplier_nameTextBox";
            this.supplier_nameTextBox.Size = new System.Drawing.Size(164, 21);
            this.supplier_nameTextBox.TabIndex = 28;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(77, 44);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(164, 21);
            this.addressTextBox.TabIndex = 30;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(77, 77);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(164, 21);
            this.codeTextBox.TabIndex = 32;
            // 
            // linkmanTextBox
            // 
            this.linkmanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "linkman", true));
            this.linkmanTextBox.Location = new System.Drawing.Point(77, 110);
            this.linkmanTextBox.Name = "linkmanTextBox";
            this.linkmanTextBox.Size = new System.Drawing.Size(164, 21);
            this.linkmanTextBox.TabIndex = 34;
            // 
            // phone1TextBox
            // 
            this.phone1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "phone1", true));
            this.phone1TextBox.Location = new System.Drawing.Point(77, 143);
            this.phone1TextBox.Name = "phone1TextBox";
            this.phone1TextBox.Size = new System.Drawing.Size(164, 21);
            this.phone1TextBox.TabIndex = 36;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(77, 176);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(164, 21);
            this.faxTextBox.TabIndex = 38;
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(77, 209);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(164, 21);
            this.urlTextBox.TabIndex = 40;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(77, 242);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(164, 21);
            this.emailTextBox.TabIndex = 42;
            // 
            // opening_bankTextBox
            // 
            this.opening_bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "opening_bank", true));
            this.opening_bankTextBox.Location = new System.Drawing.Point(77, 275);
            this.opening_bankTextBox.Name = "opening_bankTextBox";
            this.opening_bankTextBox.Size = new System.Drawing.Size(164, 21);
            this.opening_bankTextBox.TabIndex = 44;
            // 
            // bank_accountTextBox
            // 
            this.bank_accountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "bank_account", true));
            this.bank_accountTextBox.Location = new System.Drawing.Point(77, 308);
            this.bank_accountTextBox.Name = "bank_accountTextBox";
            this.bank_accountTextBox.Size = new System.Drawing.Size(164, 21);
            this.bank_accountTextBox.TabIndex = 46;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // typeBox
            // 
            this.typeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customer_type", true));
            this.typeBox.Location = new System.Drawing.Point(76, 18699);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 21);
            this.typeBox.TabIndex = 49;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_typeTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.storehouseTableAdapter = null;
            this.tableAdapterManager.supplier_typeTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KuGuan.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ChgCusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 393);
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
            this.Name = "ChgCusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChgCusForm";
            this.Load += new System.EventHandler(this.ChgCusForm_Load);
            this.Shown += new System.EventHandler(this.ChgCusForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cnlButton;
        private System.Windows.Forms.Button cfmButton;
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
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private dataDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox typeBox;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}