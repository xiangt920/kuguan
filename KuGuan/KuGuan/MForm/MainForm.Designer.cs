namespace KuGuan.MForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.档案设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供货商档案设置GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售商档案设置XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.计量单位设置UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货品设置HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库设置CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货物管理HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调库管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询与统计SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.入库单据查询IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.unitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.供货商设置toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.销售商设置toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.仓库设置toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.入库管理toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.出口管理toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.调库管理toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.库存查询toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.单据查询toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.注销toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.退出toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.档案设置ToolStripMenuItem,
            this.货物管理HToolStripMenuItem,
            this.查询与统计SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 档案设置ToolStripMenuItem
            // 
            this.档案设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.供货商档案设置GToolStripMenuItem,
            this.销售商档案设置XToolStripMenuItem,
            this.toolStripSeparator1,
            this.计量单位设置UToolStripMenuItem,
            this.货品设置HToolStripMenuItem,
            this.仓库设置CToolStripMenuItem});
            this.档案设置ToolStripMenuItem.Name = "档案设置ToolStripMenuItem";
            this.档案设置ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.档案设置ToolStripMenuItem.Text = "档案设置(&D)";
            // 
            // 供货商档案设置GToolStripMenuItem
            // 
            this.供货商档案设置GToolStripMenuItem.Name = "供货商档案设置GToolStripMenuItem";
            this.供货商档案设置GToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.供货商档案设置GToolStripMenuItem.Text = "供应商档案设置(&G)";
            this.供货商档案设置GToolStripMenuItem.Click += new System.EventHandler(this.供货商设置GToolStripMenuItem_Click);
            // 
            // 销售商档案设置XToolStripMenuItem
            // 
            this.销售商档案设置XToolStripMenuItem.Name = "销售商档案设置XToolStripMenuItem";
            this.销售商档案设置XToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.销售商档案设置XToolStripMenuItem.Text = "客户档案设置(&X)";
            this.销售商档案设置XToolStripMenuItem.Click += new System.EventHandler(this.销售商设置GToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // 计量单位设置UToolStripMenuItem
            // 
            this.计量单位设置UToolStripMenuItem.Name = "计量单位设置UToolStripMenuItem";
            this.计量单位设置UToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.计量单位设置UToolStripMenuItem.Text = "计量单位设置(&U)";
            this.计量单位设置UToolStripMenuItem.Click += new System.EventHandler(this.计量单位设置UToolStripMenuItem_Click);
            // 
            // 货品设置HToolStripMenuItem
            // 
            this.货品设置HToolStripMenuItem.Name = "货品设置HToolStripMenuItem";
            this.货品设置HToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.货品设置HToolStripMenuItem.Text = "货品设置(&H)";
            this.货品设置HToolStripMenuItem.Click += new System.EventHandler(this.货品设置HToolStripMenuItem_Click);
            // 
            // 仓库设置CToolStripMenuItem
            // 
            this.仓库设置CToolStripMenuItem.Name = "仓库设置CToolStripMenuItem";
            this.仓库设置CToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.仓库设置CToolStripMenuItem.Text = "仓库设置(&C)";
            this.仓库设置CToolStripMenuItem.Click += new System.EventHandler(this.仓库设置CToolStripMenuItem_Click);
            // 
            // 货物管理HToolStripMenuItem
            // 
            this.货物管理HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库管理IToolStripMenuItem,
            this.出库管理OToolStripMenuItem,
            this.调库管理CToolStripMenuItem});
            this.货物管理HToolStripMenuItem.Name = "货物管理HToolStripMenuItem";
            this.货物管理HToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.货物管理HToolStripMenuItem.Text = "货物管理(&H)";
            // 
            // 入库管理IToolStripMenuItem
            // 
            this.入库管理IToolStripMenuItem.Name = "入库管理IToolStripMenuItem";
            this.入库管理IToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.入库管理IToolStripMenuItem.Text = "入库管理(&I)";
            // 
            // 出库管理OToolStripMenuItem
            // 
            this.出库管理OToolStripMenuItem.Name = "出库管理OToolStripMenuItem";
            this.出库管理OToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.出库管理OToolStripMenuItem.Text = "出库管理(&O)";
            this.出库管理OToolStripMenuItem.Click += new System.EventHandler(this.出库管理OToolStripMenuItem_Click);
            // 
            // 调库管理CToolStripMenuItem
            // 
            this.调库管理CToolStripMenuItem.Name = "调库管理CToolStripMenuItem";
            this.调库管理CToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.调库管理CToolStripMenuItem.Text = "调库管理(&C)";
            // 
            // 查询与统计SToolStripMenuItem
            // 
            this.查询与统计SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存查询KToolStripMenuItem,
            this.toolStripSeparator2,
            this.入库单据查询IToolStripMenuItem});
            this.查询与统计SToolStripMenuItem.Name = "查询与统计SToolStripMenuItem";
            this.查询与统计SToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.查询与统计SToolStripMenuItem.Text = "查询与统计(&S)";
            // 
            // 库存查询KToolStripMenuItem
            // 
            this.库存查询KToolStripMenuItem.Name = "库存查询KToolStripMenuItem";
            this.库存查询KToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.库存查询KToolStripMenuItem.Text = "库存查询(&K)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // 入库单据查询IToolStripMenuItem
            // 
            this.入库单据查询IToolStripMenuItem.Name = "入库单据查询IToolStripMenuItem";
            this.入库单据查询IToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.入库单据查询IToolStripMenuItem.Text = "单据查询(&D)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.userLabel,
            this.toolStripStatusLabel4,
            this.unitLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1248, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "当前账套名称";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel2.Text = "第一套账";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "当前操作员";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = false;
            this.userLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.userLabel.Name = "userLabel";
            this.userLabel.Padding = new System.Windows.Forms.Padding(5);
            this.userLabel.Size = new System.Drawing.Size(130, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel4.Text = "使用单位";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = false;
            this.unitLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.unitLabel.Size = new System.Drawing.Size(200, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.供货商设置toolStripButton,
            this.销售商设置toolStripButton,
            this.仓库设置toolStripButton,
            this.toolStripSeparator3,
            this.入库管理toolStripButton,
            this.出口管理toolStripButton,
            this.调库管理toolStripButton,
            this.toolStripSeparator4,
            this.库存查询toolStripButton,
            this.单据查询toolStripButton,
            this.toolStripSeparator5,
            this.注销toolStripButton,
            this.退出toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1248, 72);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 供货商设置toolStripButton
            // 
            this.供货商设置toolStripButton.Image = global::KuGuan.Properties.Resources._1_供货商;
            this.供货商设置toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.供货商设置toolStripButton.Name = "供货商设置toolStripButton";
            this.供货商设置toolStripButton.Size = new System.Drawing.Size(72, 69);
            this.供货商设置toolStripButton.Text = "供应商设置";
            this.供货商设置toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.供货商设置toolStripButton.Click += new System.EventHandler(this.供货商设置GToolStripMenuItem_Click);
            // 
            // 销售商设置toolStripButton
            // 
            this.销售商设置toolStripButton.Image = global::KuGuan.Properties.Resources._1_出货商;
            this.销售商设置toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.销售商设置toolStripButton.Name = "销售商设置toolStripButton";
            this.销售商设置toolStripButton.Size = new System.Drawing.Size(60, 69);
            this.销售商设置toolStripButton.Text = "客户设置";
            this.销售商设置toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.销售商设置toolStripButton.Click += new System.EventHandler(this.销售商设置GToolStripMenuItem_Click);
            // 
            // 仓库设置toolStripButton
            // 
            this.仓库设置toolStripButton.Image = global::KuGuan.Properties.Resources._1_仓库设置;
            this.仓库设置toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.仓库设置toolStripButton.Name = "仓库设置toolStripButton";
            this.仓库设置toolStripButton.Size = new System.Drawing.Size(60, 69);
            this.仓库设置toolStripButton.Text = "仓库设置";
            this.仓库设置toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.仓库设置toolStripButton.Click += new System.EventHandler(this.仓库设置CToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(25, 55);
            // 
            // 入库管理toolStripButton
            // 
            this.入库管理toolStripButton.Image = global::KuGuan.Properties.Resources._2_入库管理;
            this.入库管理toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.入库管理toolStripButton.Name = "入库管理toolStripButton";
            this.入库管理toolStripButton.Size = new System.Drawing.Size(60, 69);
            this.入库管理toolStripButton.Text = "入库管理";
            this.入库管理toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.入库管理toolStripButton.Click += new System.EventHandler(this.入库管理Button_Click);
            // 
            // 出口管理toolStripButton
            // 
            this.出口管理toolStripButton.Image = global::KuGuan.Properties.Resources._2_出库管理;
            this.出口管理toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.出口管理toolStripButton.Name = "出口管理toolStripButton";
            this.出口管理toolStripButton.Size = new System.Drawing.Size(60, 69);
            this.出口管理toolStripButton.Text = "出库管理";
            this.出口管理toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.出口管理toolStripButton.Click += new System.EventHandler(this.出库管理OToolStripMenuItem_Click);
            // 
            // 调库管理toolStripButton
            // 
            this.调库管理toolStripButton.Image = global::KuGuan.Properties.Resources._2_调库管理;
            this.调库管理toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.调库管理toolStripButton.Name = "调库管理toolStripButton";
            this.调库管理toolStripButton.Size = new System.Drawing.Size(60, 69);
            this.调库管理toolStripButton.Text = "调库管理";
            this.调库管理toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.调库管理toolStripButton.Click += new System.EventHandler(this.调库管理toolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(25, 55);
            // 
            // 库存查询toolStripButton
            // 
            this.库存查询toolStripButton.Image = global::KuGuan.Properties.Resources._3_仓库查询;
            this.库存查询toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.库存查询toolStripButton.Name = "库存查询toolStripButton";
            this.库存查询toolStripButton.Size = new System.Drawing.Size(60, 69);
            this.库存查询toolStripButton.Text = "库存查询";
            this.库存查询toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 单据查询toolStripButton
            // 
            this.单据查询toolStripButton.Image = global::KuGuan.Properties.Resources._3_单据查询;
            this.单据查询toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.单据查询toolStripButton.Name = "单据查询toolStripButton";
            this.单据查询toolStripButton.Size = new System.Drawing.Size(60, 69);
            this.单据查询toolStripButton.Text = "单据查询";
            this.单据查询toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.AutoSize = false;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(25, 55);
            // 
            // 注销toolStripButton
            // 
            this.注销toolStripButton.Image = global::KuGuan.Properties.Resources.注销;
            this.注销toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.注销toolStripButton.Name = "注销toolStripButton";
            this.注销toolStripButton.Size = new System.Drawing.Size(52, 69);
            this.注销toolStripButton.Text = "注销";
            this.注销toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.注销toolStripButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // 退出toolStripButton
            // 
            this.退出toolStripButton.Image = global::KuGuan.Properties.Resources.退出;
            this.退出toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.退出toolStripButton.Name = "退出toolStripButton";
            this.退出toolStripButton.Size = new System.Drawing.Size(52, 69);
            this.退出toolStripButton.Text = "退出";
            this.退出toolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.退出toolStripButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 97);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1248, 447);
            this.dockPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 566);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel userLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel unitLabel;
        private System.Windows.Forms.ToolStripMenuItem 档案设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供货商档案设置GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售商档案设置XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库设置CToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 计量单位设置UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货品设置HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货物管理HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库管理IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调库管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询与统计SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询KToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 入库单据查询IToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 供货商设置toolStripButton;
        private System.Windows.Forms.ToolStripButton 销售商设置toolStripButton;
        private System.Windows.Forms.ToolStripButton 仓库设置toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton 入库管理toolStripButton;
        private System.Windows.Forms.ToolStripButton 出口管理toolStripButton;
        private System.Windows.Forms.ToolStripButton 调库管理toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton 库存查询toolStripButton;
        private System.Windows.Forms.ToolStripButton 单据查询toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton 注销toolStripButton;
        private System.Windows.Forms.ToolStripButton 退出toolStripButton;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
    }
}

