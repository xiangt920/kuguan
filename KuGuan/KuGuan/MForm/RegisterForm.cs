using KuGuan.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace KuGuan.MForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            Machine m = new Machine();
            SymmetricMethod sm = new SymmetricMethod();
            string encStr = sm.Encrypto(m.CpuId);
            applyCodeBox.Text = encStr;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Machine m = new Machine();
            SymmetricMethod sm = new SymmetricMethod();
            String encStr = licenseBox.Text;
            string decStr = sm.Decrypto(encStr);
            Byte[] b3 = m.CpuId2Byte(decStr);
            Byte[] key = m.CpuId2Byte("BFEBFBFF000206A7");
            Byte[] b4 = Util.Dec(b3, key);
            String idStr = Encoding.ASCII.GetString(b4);
            if (idStr == m.CpuId && RegisterTable.WriteRegisterData("license",encStr))
            {
                MessageBox.Show(this, "注册成功！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this, "注册失败！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
