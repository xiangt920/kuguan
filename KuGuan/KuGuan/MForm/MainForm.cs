using KuGuan.Model;
using KuGuan.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Utils;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm = new LoginForm();

        private User user;
        public User MUser 
        {
            set { this.user = value; }
            get { return this.user; }
        }
        private StartForm startForm = new StartForm();
        public StartForm SForm
        {
            get { return startForm; }
        }
        public DockPanel MDockPanel
        {
            get { return this.dockPanel; }
        }
        public MainForm()
        {
            InitializeComponent();
            if (DateTime.Now > Convert.ToDateTime("2015-1-31"))
            {
                if (!RegisterTable.isRegistered("license"))
                {
                    MessageBox.Show("软件授权已过期！");
                    RegisterForm rf = new RegisterForm();
                    if (!(rf.ShowDialog(this) == System.Windows.Forms.DialogResult.OK))
                    {
                        ExitSys();
                    }
                }
                else
                {

                    SymmetricMethod sm = new SymmetricMethod();
                    Machine m = new Machine();
                    String encStr = RegisterTable.GetRegisterData("license");
                    string decStr = sm.Decrypto(encStr);
                    Byte[] b3 = m.CpuId2Byte(decStr);
                    Byte[] key = m.CpuId2Byte("BFEBFBFF000206A7");
                    Byte[] b4 = Util.Dec(b3, key);
                    String idStr = Encoding.ASCII.GetString(b4);
                    if (idStr != m.CpuId)
                    {
                        MessageBox.Show(this, "软件注册信息错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ExitSys();
                    }
                }
            }
            this.Visible = false;
            //FormInit();
            startForm.Show(this);
            DialogResult result = this.loginForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                FormInit();
            }
            else
            {
                ExitSys();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.unitLabel.Text = this.use_unitTableAdapter.GetName();

        }

        private DockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as DockContent;
                    }
                }

                return null;
            }
            else
            {
                foreach (DockContent content in dockPanel.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }

        private void FormInit()
        {
            //user = new User(1, "sjhd", "sdh", "shd");
            this.Text = "当前用户：" + user.Username;
            this.userLabel.Text = user.Username;
            this.Visible = true;
        }
        private void ExitSys()
        {
            List<DockContent> dl = new List<DockContent>();
            foreach (DockContent c in this.dockPanel.Contents)
            {
                dl.Add(c);
            }
            foreach (DockContent c in dl)
            {
                try
                {
                    c.Close();
                }
                catch (InvalidOperationException)
                { }
                if (!c.IsDisposed)
                {
                    return;
                }
            }
            this.Close();
            Application.ExitThread();
            System.Environment.Exit(0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitSys();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DialogResult result = this.loginForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                FormInit();
            }
            else
            {
                ExitSys();
            }
        }

        private void 供货商设置GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("供应商设置");
            if (frm == null)
                frm = new SupplierForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 销售商设置GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("客户设置");
            if (frm == null)
                frm = new CustomerForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 计量单位设置UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("计量单位");
            if (frm == null)
                frm = new unit();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 仓库设置CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("仓库设置");
            if (frm == null)
                frm = new StoreForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 货品设置HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("货品设置");
            if (frm == null)
                frm = new ProductForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 入库管理Button_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("入库管理");
            if (frm == null)
                frm = new storage_management();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 出库管理OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("出库管理");
            if (frm == null)
                frm = new out_management();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 调库管理toolStripButton_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("调库管理");
            if(frm == null)
                frm = new exchange_management();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 库存查询toolStripButton_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("库存查询");
            if (frm == null)
                frm = new StockForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 入库单据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("入库单据查询");
            if (frm == null)
                frm = new StorageDocForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 出库单据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("出库单据查询");
            if (frm == null)
                frm = new OutDocForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 调库单据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("调库单据查询");
            if (frm == null)
                frm = new ExchangeDocForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 单据查询toolStripButton_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("单据综合查询");
            if (frm == null)
                frm = new CompositeForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 账目查询AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("账目查询");
            if (frm == null)
                frm = new ProductAccountForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 使用单位设置DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseUnitForm uForm = new UseUnitForm();
            uForm.ShowDialog(this);
            this.unitLabel.Text =  this.use_unitTableAdapter.GetName();
        }

        private void 标题字体设置TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.SetFont(@"data\tf.dat",this);
        }

        private void 内容字体设置CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.SetFont(@"data\cf.dat",this);
        }

        private void 标题字体设置TToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.SetFont(@"data\atf.dat", this);
        }

        private void 内容字体设置CToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.SetFont(@"data\acf.dat", this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.SetFont(@"data\asf.dat", this);
        }

        private void 年末打印查询EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("年末打印");
            if (frm == null)
                frm = new AnnPrintAccountForm();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }

        private void 保管员设置ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockContent frm = FindDocument("保管员设置");
            if (frm == null)
                frm = new custodian();

            frm.Show(this.dockPanel);
            frm.BringToFront();
        }
    
    }
}
