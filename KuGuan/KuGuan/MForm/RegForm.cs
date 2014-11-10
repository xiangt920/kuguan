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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = user_nameTextBox.Text;
            string pwd = passwordTextBox.Text;
            string repwd = reBox.Text;
            if (name.Trim() == "")
            {
                MessageBox.Show(this,"用户名不能为空","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (pwd == "")
            {
                MessageBox.Show(this, "密码不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (pwd != repwd)
            {
                MessageBox.Show(this, "两次密码输入不一致", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.kuguanDataSet.user.AdduserRow(name, "超级用户", pwd);
            this.tableAdapterManager.UpdateAll(kuguanDataSet);
            MessageBox.Show(this, "注册成功", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
