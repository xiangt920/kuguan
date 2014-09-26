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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int userId = (int)userBox.SelectedValue;
            String passwd = passwordBox.Text;
            int? count = this.userTableAdapter.Login(userId, passwd);
            if (count == 1)
            {
                dataDataSet.userDataTable tab = this.userTableAdapter.GetDataById((int)userBox.SelectedValue);
                KuGuan.Model.User u = new KuGuan.Model.User(
                (int)tab.Rows[0]["user_id"],
                (String)tab.Rows[0]["user_name"],
                (String)tab.Rows[0]["user_type"],
                (String)tab.Rows[0]["password"]);
                ((MainForm)this.Owner).MUser = u;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("密码有误！");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.user”中。您可以根据需要移动或删除它。
            this.userTableAdapter.Fill(this.dataDataSet.user);

        }

        private void chnPwdBtn_Click(object sender, EventArgs e)
        {
            ChgPwdForm chg = new ChgPwdForm();
            dataDataSet.userDataTable tab = this.userTableAdapter.GetDataById((int)userBox.SelectedValue);
            KuGuan.Model.User u = new KuGuan.Model.User(
                (int)tab.Rows[0]["user_id"],
                (String)tab.Rows[0]["user_name"],
                (String)tab.Rows[0]["user_type"],
                (String)tab.Rows[0]["password"]);
            chg.userInit(u, this.userTableAdapter);
            chg.ShowDialog();
        }
    }
}
