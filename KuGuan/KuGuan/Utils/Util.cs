using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace KuGuan.Utils
{
    class Util
    {
        public static void deleteBak()
        {
            try
            {
                string[] files = Directory.GetFiles(@"data");
                foreach (string s in files)
                {
                    if(s.Contains("bak"))
                        File.Delete(s);
                }
            }
            catch { }
        }

        public static Font GetFont(string filename)
        {
            Font f = new Font("宋体", 12);
            string fileName = filename;//文件名称与路径
            Stream fStream = null;
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                f = (Font)binFormat.Deserialize(fStream);
            }
            catch (Exception) { }
            finally
            {
                if (fStream != null)
                    fStream.Close();
            }
            return f;
        }

        public static void SetFont(string filename, IWin32Window owner)
        {
            FontDialog fd = new FontDialog();
            fd.ShowEffects = true;
            string fileName = filename;//文件名称与路径
            Stream fStream = null;
            try
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                try
                {
                    fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fd.Font = (Font)binFormat.Deserialize(fStream);
                }
                catch (Exception) { }
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    Font f = fd.Font;
                    fStream.Position = 0;
                    binFormat.Serialize(fStream, f);

                }
            }
            catch (Exception)
            {
                MessageBox.Show(owner, "设置失败！", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (fStream != null)
                fStream.Close();
        }

        public static Byte[] Enc(Byte[] b0,Byte[] key)
        {
            Byte[] rs = null;
            try
            {
                rs = new Byte[b0.Length];
                for (int i = 0; i < b0.Length; i++)
                {
                    if (i == 0)
                    {
                        rs[0] = (Byte)(b0[0] ^ key[0]);
                    }
                    else
                    {
                        rs[i] = (Byte)(rs[i - 1] ^ b0[i] ^ key[i]);
                    }
                }
            }
            catch 
            {
                rs = null;
            }
            return rs;
        }

        public static Byte[] Dec(Byte[] b0, Byte[] key)
        {
            Byte[] rs = null;
            try
            {
                rs = new Byte[b0.Length];
                for (int i = 0; i < b0.Length; i++)
                {
                    if (i == 0)
                    {
                        rs[0] = (Byte)(b0[0] ^ key[0]);
                    }
                    else
                    {
                        rs[i] = (Byte)(b0[i - 1] ^ b0[i] ^ key[i]);
                    }
                }
            }
            catch 
            {
                rs = null;
            }
            return rs;
        }
    }
}
