using KuGuan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
        public MainForm()
        {
            InitializeComponent();
            this.Visible = false;
            FormInit();
            //DialogResult result = this.loginForm.ShowDialog(this);
            //if (result == DialogResult.OK)
            //{
            //    FormInit();
            //}
            //else
            //{
            //    ExitSys();
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

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
            user = new User(1, "sjhd", "sdh", "shd");
            this.Text = "当前用户：" + user.Username;
            this.userLabel.Text = user.Username;
            this.Visible = true;
        }
        private void ExitSys()
        {
            this.Dispose();
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
    }
}
