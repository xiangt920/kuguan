using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void SetBtnStyle(Button btn)
        {

            btn.FlatStyle = FlatStyle.Flat;//样式
            btn.ForeColor = Color.Transparent;//前景
            btn.BackColor = Color.Transparent;//去背景
            btn.FlatAppearance.BorderSize = 1;//去边线
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;//鼠标经过
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;//鼠标按下
        }
        bool beginMove = false;//初始化
        int currentXPosition;
        int currentYPosition;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userBox.SelectedValue == null)
            {
                MessageBox.Show("系统未成功连接数据库，无法登录", "警告", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            int userId = (int)userBox.SelectedValue;
            String passwd = passwordBox.Text;
            int? count = this.userTableAdapter.Login(userId, passwd);
            if (count == 1)
            {
                kuguanDataSet.userDataTable tab = this.userTableAdapter.GetDataById((int)userBox.SelectedValue);
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
            try
            {
                SetBtnStyle(loginButton);
                SetBtnStyle(chnPwdBtn);
                SetBtnStyle(exitButton);
                SetBtnStyle(button1);
                this.userTableAdapter.Fill(this.dataDataSet.user);
            }
            catch (COMException)
            {
                MessageBox.Show("您的系统中缺少必要的运行库导致无法启动系统，请联系系统技术支持人员以解决该问题！", "警告", MessageBoxButtons.OK);
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }

        }

        private void chnPwdBtn_Click(object sender, EventArgs e)
        {
            if (userBox.SelectedValue == null)
            {
                MessageBox.Show("系统未成功连接数据库，无法修改密码", "警告", MessageBoxButtons.OK);
                return;

            }
            ChgPwdForm chg = new ChgPwdForm();
            kuguanDataSet.userDataTable tab = this.userTableAdapter.GetDataById((int)userBox.SelectedValue);
            KuGuan.Model.User u = new KuGuan.Model.User(
                (int)tab.Rows[0]["user_id"],
                (String)tab.Rows[0]["user_name"],
                (String)tab.Rows[0]["user_type"],
                (String)tab.Rows[0]["password"]);
            chg.userInit(u, this.userTableAdapter);
            chg.ShowDialog();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            StartForm s = ((MainForm)this.Owner).SForm;
            s.Hide();
            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegForm rForm = new RegForm();
            if (rForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.userTableAdapter.Fill(this.dataDataSet.user);
                }
                catch (COMException)
                {
                    MessageBox.Show("您的系统中缺少必要的运行库导致无法启动系统，请联系系统技术支持人员以解决该问题！", "警告", MessageBoxButtons.OK);
                    this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                }
            }
        }
    }
}
