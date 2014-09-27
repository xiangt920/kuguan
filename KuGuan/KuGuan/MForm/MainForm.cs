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
            //FormInit();
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
    }
}
