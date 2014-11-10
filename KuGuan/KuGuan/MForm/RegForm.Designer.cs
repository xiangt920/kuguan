namespace KuGuan.MForm
{
    partial class RegForm
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
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.user_nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.reBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancleButton = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuguanDataSet = new KuGuan.kuguanDataSet();
            this.userTableAdapter = new KuGuan.kuguanDataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new KuGuan.kuguanDataSetTableAdapters.TableAdapterManager();
            user_nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuguanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Location = new System.Drawing.Point(63, 15);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(47, 12);
            user_nameLabel.TabIndex = 3;
            user_nameLabel.Text = "用户名:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(63, 52);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(35, 12);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "密码:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(63, 89);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 12);
            label1.TabIndex = 9;
            label1.Text = "重复密码:";
            // 
            // user_nameTextBox
            // 
            this.user_nameTextBox.Location = new System.Drawing.Point(134, 12);
            this.user_nameTextBox.Name = "user_nameTextBox";
            this.user_nameTextBox.Size = new System.Drawing.Size(155, 21);
            this.user_nameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(134, 49);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(155, 21);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // reBox
            // 
            this.reBox.Location = new System.Drawing.Point(134, 86);
            this.reBox.Name = "reBox";
            this.reBox.Size = new System.Drawing.Size(155, 21);
            this.reBox.TabIndex = 10;
            this.reBox.UseSystemPasswordChar = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(134, 131);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancleButton
            // 
            this.cancleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancleButton.Location = new System.Drawing.Point(215, 131);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(75, 23);
            this.cancleButton.TabIndex = 12;
            this.cancleButton.Text = "取消";
            this.cancleButton.UseVisualStyleBackColor = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.kuguanDataSet;
            // 
            // kuguanDataSet
            // 
            this.kuguanDataSet.DataSetName = "kuguanDataSet";
            this.kuguanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.use_unitTableAdapter = null;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // RegForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancleButton;
            this.ClientSize = new System.Drawing.Size(301, 165);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reBox);
            this.Controls.Add(label1);
            this.Controls.Add(user_nameLabel);
            this.Controls.Add(this.user_nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册新用户";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuguanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kuguanDataSet kuguanDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private kuguanDataSetTableAdapters.userTableAdapter userTableAdapter;
        private kuguanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox user_nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox reBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancleButton;
    }
}