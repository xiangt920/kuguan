namespace KuGuan.MForm
{
    partial class ChgProForm
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
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label get_priceLabel;
            System.Windows.Forms.Label out_priceLabel;
            System.Windows.Forms.Label product_introduceLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label label1;
            this.dataDataSet = new KuGuan.dataDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new KuGuan.dataDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new KuGuan.dataDataSetTableAdapters.TableAdapterManager();
            this.unitTableAdapter = new KuGuan.dataDataSetTableAdapters.unitTableAdapter();
            this.idBox = new System.Windows.Forms.TextBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.get_priceTextBox = new System.Windows.Forms.TextBox();
            this.out_priceTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.cnlButton = new System.Windows.Forms.Button();
            this.cfmButton = new System.Windows.Forms.Button();
            this.introBox = new System.Windows.Forms.RichTextBox();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specBox = new System.Windows.Forms.TextBox();
            product_nameLabel = new System.Windows.Forms.Label();
            get_priceLabel = new System.Windows.Forms.Label();
            out_priceLabel = new System.Windows.Forms.Label();
            product_introduceLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(20, 12);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(59, 12);
            product_nameLabel.TabIndex = 3;
            product_nameLabel.Text = "产品名称:";
            // 
            // get_priceLabel
            // 
            get_priceLabel.AutoSize = true;
            get_priceLabel.Location = new System.Drawing.Point(20, 72);
            get_priceLabel.Name = "get_priceLabel";
            get_priceLabel.Size = new System.Drawing.Size(47, 12);
            get_priceLabel.TabIndex = 5;
            get_priceLabel.Text = "进货价:";
            // 
            // out_priceLabel
            // 
            out_priceLabel.AutoSize = true;
            out_priceLabel.Location = new System.Drawing.Point(20, 102);
            out_priceLabel.Name = "out_priceLabel";
            out_priceLabel.Size = new System.Drawing.Size(47, 12);
            out_priceLabel.TabIndex = 7;
            out_priceLabel.Text = "出货价:";
            // 
            // product_introduceLabel
            // 
            product_introduceLabel.AutoSize = true;
            product_introduceLabel.Location = new System.Drawing.Point(20, 161);
            product_introduceLabel.Name = "product_introduceLabel";
            product_introduceLabel.Size = new System.Drawing.Size(59, 12);
            product_introduceLabel.TabIndex = 9;
            product_introduceLabel.Text = "产品描述:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(20, 132);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(59, 12);
            unitLabel.TabIndex = 11;
            unitLabel.Text = "计量单位:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(20, 280);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(35, 12);
            remarkLabel.TabIndex = 13;
            remarkLabel.Text = "备注:";
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.dataDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_typeTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.product_typeTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.storehouseTableAdapter = null;
            this.tableAdapterManager.supplier_typeTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.unitTableAdapter = this.unitTableAdapter;
            this.tableAdapterManager.UpdateOrder = KuGuan.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // idBox
            // 
            this.idBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_id", true));
            this.idBox.Location = new System.Drawing.Point(13900, 16);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 21);
            this.idBox.TabIndex = 2;
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(85, 9);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(266, 21);
            this.product_nameTextBox.TabIndex = 4;
            // 
            // get_priceTextBox
            // 
            this.get_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "get_price", true));
            this.get_priceTextBox.Location = new System.Drawing.Point(85, 69);
            this.get_priceTextBox.Name = "get_priceTextBox";
            this.get_priceTextBox.Size = new System.Drawing.Size(266, 21);
            this.get_priceTextBox.TabIndex = 6;
            // 
            // out_priceTextBox
            // 
            this.out_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "out_price", true));
            this.out_priceTextBox.Location = new System.Drawing.Point(85, 99);
            this.out_priceTextBox.Name = "out_priceTextBox";
            this.out_priceTextBox.Size = new System.Drawing.Size(266, 21);
            this.out_priceTextBox.TabIndex = 8;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(85, 277);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(266, 21);
            this.remarkTextBox.TabIndex = 14;
            // 
            // cnlButton
            // 
            this.cnlButton.Location = new System.Drawing.Point(176, 316);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(75, 34);
            this.cnlButton.TabIndex = 50;
            this.cnlButton.Text = "取消";
            this.cnlButton.UseVisualStyleBackColor = true;
            this.cnlButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // cfmButton
            // 
            this.cfmButton.Location = new System.Drawing.Point(85, 316);
            this.cfmButton.Name = "cfmButton";
            this.cfmButton.Size = new System.Drawing.Size(75, 34);
            this.cfmButton.TabIndex = 49;
            this.cfmButton.Text = "确认";
            this.cfmButton.UseVisualStyleBackColor = true;
            this.cfmButton.Click += new System.EventHandler(this.cfmButton_Click);
            // 
            // introBox
            // 
            this.introBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_introduce", true));
            this.introBox.Location = new System.Drawing.Point(85, 158);
            this.introBox.Name = "introBox";
            this.introBox.Size = new System.Drawing.Size(266, 110);
            this.introBox.TabIndex = 51;
            this.introBox.Text = "";
            // 
            // unitBox
            // 
            this.unitBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "unit_id", true));
            this.unitBox.DataSource = this.unitBindingSource;
            this.unitBox.DisplayMember = "unit";
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Location = new System.Drawing.Point(85, 129);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(266, 20);
            this.unitBox.TabIndex = 52;
            this.unitBox.ValueMember = "unit_id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "unit";
            this.unitBindingSource.DataSource = this.dataDataSet;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 12);
            label1.TabIndex = 53;
            label1.Text = "规格:";
            // 
            // specBox
            // 
            this.specBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "spec", true));
            this.specBox.Location = new System.Drawing.Point(85, 39);
            this.specBox.Name = "specBox";
            this.specBox.Size = new System.Drawing.Size(266, 21);
            this.specBox.TabIndex = 54;
            // 
            // ChgProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 382);
            this.Controls.Add(label1);
            this.Controls.Add(this.specBox);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.introBox);
            this.Controls.Add(this.cnlButton);
            this.Controls.Add(this.cfmButton);
            this.Controls.Add(this.idBox);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(get_priceLabel);
            this.Controls.Add(this.get_priceTextBox);
            this.Controls.Add(out_priceLabel);
            this.Controls.Add(this.out_priceTextBox);
            this.Controls.Add(product_introduceLabel);
            this.Controls.Add(unitLabel);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Name = "ChgProForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChgProForm";
            this.Load += new System.EventHandler(this.ChgProForm_Load);
            this.Shown += new System.EventHandler(this.ChgProForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private dataDataSetTableAdapters.productTableAdapter productTableAdapter;
        private dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox get_priceTextBox;
        private System.Windows.Forms.TextBox out_priceTextBox;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Button cnlButton;
        private System.Windows.Forms.Button cfmButton;
        private dataDataSetTableAdapters.unitTableAdapter unitTableAdapter;
        private System.Windows.Forms.RichTextBox introBox;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.TextBox specBox;
    }
}