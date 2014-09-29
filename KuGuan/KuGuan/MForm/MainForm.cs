using KuGuan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void 供货商档案设置GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm sup = new SupplierForm();
            sup.MdiParent = this;
            sup.WindowState = FormWindowState.Maximized;
            sup.Show();
        }

        private void 计量单位设置UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unit u = new unit();
            u.WindowState = FormWindowState.Normal;
            u.MdiParent = this;
            u.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CustomerForm cus = new CustomerForm();
            cus.MdiParent = this;
            cus.WindowState = FormWindowState.Maximized;
            cus.Show();
        }

        private void 仓库设置CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoreForm s = new StoreForm();
            s.WindowState = FormWindowState.Normal;
            s.MdiParent = this;
            s.Show();
        }

        private void 货品设置HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm pro = new ProductForm();
            pro.MdiParent = this;
            pro.WindowState = FormWindowState.Maximized;
            pro.Show();
        }

        private void storageButton_Click(object sender, EventArgs e)
        {
            storage_management st = new storage_management();

            st.MdiParent = this;
            st.WindowState = FormWindowState.Normal;
            st.Show();
        }

        private void 出库管理OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            out_management st = new out_management();

            st.MdiParent = this;
            st.WindowState = FormWindowState.Normal;
            st.Show();
        }
    }
}
