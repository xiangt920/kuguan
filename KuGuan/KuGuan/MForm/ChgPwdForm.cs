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
    public partial class ChgPwdForm : Form
    {
        private User user;
        private dataDataSetTableAdapters.userTableAdapter userTable;
        public ChgPwdForm()
        {
            InitializeComponent();
        }

        public void userInit(User user, dataDataSetTableAdapters.userTableAdapter userTable) 
        {
            this.user = user;
            this.userTable = userTable;
            this.Text = user.Username + "更改密码";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String oldpwd = oldpwdBox.Text;
            String newpwd = newpwdBox.Text;
            String cfmpwd = cfmpwdBox.Text;
            if (oldpwd != user.Password)
            {
                MessageBox.Show("原密码不正确！");
                return;
            }
            if (newpwd.Trim().Length == 0)
            {
                MessageBox.Show("新密码不能为空！");
                return;
            }
            if (newpwd == oldpwd)
            {
                MessageBox.Show("新密码不能与原密码相同！");
                return;
            }
            if (newpwd != cfmpwd)
            {
                MessageBox.Show("两次新密码输入不相同！");
                return;
            }
            int count = userTable.changePasswd(newpwd, user.UserId);
            if (count != 1)
            {
                MessageBox.Show("密码修改失败！");
                return;
            }
            else
            {
                MessageBox.Show("密码修改成功！");
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
