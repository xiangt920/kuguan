using KuGuan.Model;
using KuGuan.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class AnnPrintAccountForm : DockContent
    {
        private StoreForm S = new StoreForm(true);
        private delegate void ShowInfo(string info);
        private delegate void ShowText(TextBox box, string text);
        private delegate void RefreshDetailView(int pro_id, int store_id);
        private delegate void ShowProcess(int value);
        private delegate void SetMaxValue(int value);
        private delegate void PrintCompelete();
        private Boolean isPaused = false;
        private Boolean isStoped = false;

        public AnnPrintAccountForm()
        {
            InitializeComponent();
        }

        private void ProductAccountForm_Load(object sender, EventArgs e)
        {
            this.fromTimePicker.Value = Convert.ToDateTime(DateTime.Now.Year+"-1-1");
        }

        private void refreshDetailView(int pro_id,int store_id)
        {
            if (accountDetailView.InvokeRequired)
            {

                RefreshDetailView tmp = new RefreshDetailView(refreshDetailView);
                try
                {
                    this.Invoke(tmp, new object[] { pro_id, store_id});
                }
                catch (Exception)
                { }
                return;
            }
            accountDetailView.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            this.accountTableAdapter.FillByCondition(this.kuguanDataSet.account,
                pro_id, store_id, fromTimePicker.Value.Date, toTimePicker.Value.Date.AddDays(1));
            foreach (kuguanDataSet.accountRow row in kuguanDataSet.account.Rows)
            {
                DataGridViewRow r = new DataGridViewRow();
                String[] deb = amount2String(row.debit_amount);
                String[] cre = amount2String(row.credit_amount);
                String[] rem;
                switch (row.type)
                {
                    case 1:
                        r.CreateCells(accountDetailView, new Object[]{
                            row.time.ToString("yyyy.MM.dd"),
                            "",row.summary,row.debit_num.ToString("f2"),
                            row.debit_price.ToString("f3"),
                            deb[0],deb[1],deb[2],deb[3],deb[4],deb[5],deb[6],deb[7],deb[8],
                            "","",
                            "","","","","","","","","",
                            "",
                            "","",
                            "","","","","","","","",""
                        });
                        break;
                    case 2:
                        r.CreateCells(accountDetailView, new Object[]{
                            row.time.ToString("yyyy.MM.dd"),
                            "",row.summary,
                            "","",
                            "","","","","","","","","",
                            row.credit_num.ToString("f2"),row.credit_price.ToString("f3"),
                            cre[0],cre[1],cre[2],cre[3],cre[4],cre[5],cre[6],cre[7],cre[8],"",
                            "","",
                            "","","","","","","","",""
                        });
                        break;
                    case 3:
                        if (row.debit_num == 0)
                        {
                            r.CreateCells(accountDetailView, new Object[]{
                                row.time.ToString("yyyy.MM.dd"),
                                "",row.summary,row.debit_num.ToString("f2"),
                                row.debit_price.ToString("f3"),
                                deb[0],deb[1],deb[2],deb[3],deb[4],deb[5],deb[6],deb[7],deb[8],
                                "","",
                                "","","","","","","","","",
                                "",
                                "","",
                                "","","","","","","","",""
                            });
                        }
                        else if (row.credit_num == 0)
                        {
                            r.CreateCells(accountDetailView, new Object[]{
                                row.time.ToString("yyyy.MM.dd"),
                                "",row.summary,row.debit_num.ToString("f2"),
                                row.debit_price.ToString("f3"),
                                deb[0],deb[1],deb[2],deb[3],deb[4],deb[5],deb[6],deb[7],deb[8],
                                row.credit_num.ToString("f2"),row.credit_price.ToString("f3"),
                                cre[0],cre[1],cre[2],cre[3],cre[4],cre[5],cre[6],cre[7],cre[8],"",
                                "","",
                                "","","","","","","","",""
                            });
                        }
                        else
                        {
                            r.CreateCells(accountDetailView, new Object[]{
                                row.time.ToString("yyyy.MM.dd"),
                                "",row.summary,
                                "","",
                                deb[0],deb[1],deb[2],deb[3],deb[4],deb[5],deb[6],deb[7],deb[8],
                                row.credit_num.ToString("f2"),"",
                                cre[0],cre[1],cre[2],cre[3],cre[4],cre[5],cre[6],cre[7],cre[8],"",
                                "","",
                                "","","","","","","","",""
                            });
                        }
                        break;
                    case 4:
                        rem = amount2String(row.remain_amount);
                        r.CreateCells(accountDetailView, new Object[]{
                                row.time.ToString("yyyy.MM.dd"),
                                "",row.summary,
                                row.debit_num == 0?"":row.debit_num.ToString("f2"),"",
                                deb[0],deb[1],deb[2],deb[3],deb[4],deb[5],deb[6],deb[7],deb[8],
                                row.credit_num==0?"":row.credit_num.ToString("f2"),"",
                                cre[0],cre[1],cre[2],cre[3],cre[4],cre[5],cre[6],cre[7],cre[8],"",
                                row.remain_num.ToString("f2"),"",
                                rem[0],rem[1],rem[2],rem[3],rem[4],rem[5],rem[6],rem[7],rem[8]
                            });
                        break;
                    case 5:
                        rem = amount2String(row.remain_amount);
                        r.CreateCells(accountDetailView, new Object[]{
                                row.time.ToString("yyyy.MM.dd"),
                                "",row.summary,
                                "","",
                                "","","","","","","","","",
                                "","",
                                "","","","","","","","","","",
                                row.remain_num.ToString("f2"),"",
                                rem[0],rem[1],rem[2],rem[3],rem[4],rem[5],rem[6],rem[7],rem[8]
                            });
                        break;
                    case 6:
                        rem = amount2String(row.remain_amount);
                        r.CreateCells(accountDetailView, new Object[]{
                                row.time.ToString("yyyy.MM.dd"),
                                "",row.summary,
                                "","",
                                "","","","","","","","","",
                                "","",
                                "","","","","","","","","","",
                                row.remain_num.ToString("f2"),"",
                                rem[0],rem[1],rem[2],rem[3],rem[4],rem[5],rem[6],rem[7],rem[8]
                            });
                        break;
                }
                
                rows.Add(r);
            }
            accountDetailView.Rows.AddRange(rows.ToArray());
            
        }

        private String[] amount2String(decimal amount)
        {
            amount = Decimal.Round(amount, 1);
            bool f = false;
            if (amount < 0)
            {
                f = true;
                amount = 0 - amount;
            }
            String[] str = new String[9];
            for (int i = 6; i > -3; i--)
            {
                int tmp = (int)(amount / Convert.ToDecimal(Math.Pow(10, i))) % 10;
                str[6 - i] = tmp == 0 && (i == 6 || str[5 -i] == "") ? "" : tmp + "";
                if (i == 6)
                {
                    if (str[0] != "" && f)
                        str[0] = "-" + str[0];
                }
                else
                {
                    if (str[5 - i] == "" && str[6 - i] != "" && f)
                        str[6 - i] = "-" + str[6 - i];
                }
            }
            return str;
        }

        private void showInfo(string info)
        {
            if (this.InvokeRequired)
            {
                ShowInfo tmp = new ShowInfo(showInfo);
                try
                {
                    this.Invoke(tmp, new object[] { info });
                }
                catch (Exception)
                { }
                return;
            }
            MessageBox.Show(this, info, "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void showText(TextBox box,string info)
        {
            if (box.InvokeRequired)
            {
                ShowText tmp = new ShowText(showText);
                try
                {
                    this.Invoke(tmp, new object[] { box,info });
                }
                catch (Exception)
                { }
                return;
            }
            box.Text = info;
        }

        private void showProcess(int value)
        {
            if (this.progressBar.InvokeRequired)
            {
                ShowProcess tmp = new ShowProcess(showProcess);
                try
                {
                    this.Invoke(tmp, new Object[] { value });
                }
                catch { }
                return;
            }
            this.progressBar.Value = value;
        }

        private void setMaxValue(int value)
        {
            if (this.progressBar.InvokeRequired)
            {
                SetMaxValue tmp = new SetMaxValue(setMaxValue);
                try
                {
                    this.Invoke(tmp, new Object[] { value });
                }
                catch { }
                return;
            }
            this.progressBar.Maximum = value;
        }

        private void printCompelete()
        {

            if (this.InvokeRequired)
            {
                PrintCompelete tmp = new PrintCompelete(printCompelete);
                try
                {
                    this.Invoke(tmp, null);
                }
                catch (Exception)
                { }
                return;
            }

            showProcess(0);
            supButton.Text = "暂停";
            supButton.Enabled = false;
            stopButton.Enabled = false;
            isStoped = false;
            isPaused = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            supButton.Enabled = true;
            stopButton.Enabled = true;
            supButton.Text = "暂停";
            isPaused = false;
            isStoped = false;
            Thread t = new Thread(new ThreadStart(autoPrint));
            t.Start();
        }

        private Boolean printDGV()
        {
            PrintDialog dg = new PrintDialog();
            DGVPrintDocument doc = new DGVPrintDocument(accountDetailView, "材料明细账", new int[] { });

            doc.Title = "材料明细账";
            var rs = from kuguanDataSet.accountRow row in kuguanDataSet.account
                     select row;
            doc.SubTitle = new String[] { 
                "名称："+proNameBox.Text,
                "计量单位："+unitBox.Text,
                "最高库存：",
                "库："+storeBox.Text,
                "架：",
                "编号："+proIdBox.Text,
                "计划单价：",
                "最低库存：",
                "区："+engBox.Text,
                "层："
            };
            doc.Footer = new String[] {
                "  ",
                "  ",
            };
            doc.CellFont = Util.GetFont(@"data\acf.dat");
            doc.SubTitleFont = Util.GetFont(@"data\asf.dat");
            doc.FooterFont = Util.GetFont(@"data\asf.dat");
            doc.TitleFont = Util.GetFont(@"data\atf.dat");
            doc.SubCount = 5;
            doc.accInit();
            doc.Doc.DefaultPageSettings.Landscape = true;
            dg.Document = doc.Doc;
            doc.Doc.Print();
            return true;
        }

        private void autoPrint()
        {
            productStockAdapter.FillByType(this.kuguanDataSet.product_stock, S.Id);
            setMaxValue(this.kuguanDataSet.product_stock.Rows.Count);
            int i = 1;
            foreach(kuguanDataSet.product_stockRow row in kuguanDataSet.product_stock.Rows)
            {
                if (isPaused)
                {
                    while (true)
                    {
                        if (isPaused)
                            Thread.Sleep(500);
                        else
                            break;
                    }
                }
                if (isStoped)
                {
                    printCompelete();
                    return;
                }
                showText(specBox, row.spec);
                showText(proIdBox, row.product_id+"");
                showText(proNameBox, row.product_name);
                showText(unitBox, row.unit);
                refreshDetailView(row.product_id, row.product_type_id);
                if (!printDGV())
                {
                    if (MessageBox.Show(this, "是否中止打印?", "询问",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == 
                        System.Windows.Forms.DialogResult.Yes)
                        return;
                }
                kuguanDataSet.account.Rows.Clear();
                showProcess(i++);
            }
            kuguanDataSet.product_stock.Rows.Clear();
            printCompelete();
        }

        private void accountDetailView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void storeBox_Click(object sender, EventArgs e)
        {

            if (S.ShowDialog() == DialogResult.OK)
            {
                storeBox.Text = S.ParentName;
                engBox.Text = S.SName;
            }
        }

        private void supButton_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                supButton.Text = "暂停";
                isPaused = false;
            }
            else
            {
                supButton.Text = "继续";
                isPaused = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            isStoped = true;
        }

    }
}
