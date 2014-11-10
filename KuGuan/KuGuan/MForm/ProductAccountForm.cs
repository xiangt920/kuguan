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
    public partial class ProductAccountForm : DockContent
    {
        private choose_stock P = new choose_stock();
        private kuguanDataSet.accountDataTable acc = new kuguanDataSet.accountDataTable();
        private Boolean backrunning = false;
        private delegate void ShowInfo(string info);
        private delegate void ShowProcess(int value);
        private delegate void SetMaxValue(int value);

        public ProductAccountForm()
        {
            InitializeComponent();
        }

        private void proIdBox_Click(object sender, EventArgs e)
        {
            if (P.ShowDialog() == DialogResult.OK)
            {
                proIdBox.Text = P.ID;
                proNameBox.Text = P.ProName;
                unitBox.Text = P.Unit;
                priceBox.Text = P.OutPrice;
                storeBox.Text = P.Store;
                engBox.Text = P.Type;
                unitBox.Text = P.Unit;
                specBox.Text = P.ProSpec;
                int pro_id = Convert.ToInt32(P.ID);
                refreshDetailView(pro_id, P.TypeId);
            }
        }

        private void ProductAccountForm_Load(object sender, EventArgs e)
        {
            this.fromTimePicker.Value = Convert.ToDateTime(DateTime.Now.Year + "-" + DateTime.Now.Month + "-1");
        }

        private void fromTimePicker_CloseUp(object sender, EventArgs e)
        {
            if (!backrunning)
            {
                accountDetailView.Rows.Clear();
                int pro_id = Convert.ToInt32(P.ID);
                refreshDetailView(pro_id, P.TypeId);
            }
        }

        private void refreshDetailView(int pro_id,int store_id)
        {
            if (backrunning)
            {
                MessageBox.Show(this, "后台操作尚未完成", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                row.debit_num.ToString("f2"),"",
                                deb[0],deb[1],deb[2],deb[3],deb[4],deb[5],deb[6],deb[7],deb[8],
                                row.credit_num.ToString("f2"),"",
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

        private int getMonthCount(DateTime d1, DateTime d2)
        {
            int m = 0;
            m = (d2.Year - d1.Year) * 12 + d2.Month - d1.Month;
            return m;
        }

        private DateTime getDateByMonth(DateTime d, int month)
        {
            int y = month / 12;
            if(month % 12 >= d.Month)
            {
                y ++;
                month = month % 12 - 12;
            }
            else
                month = month % 12;
            String str = (d.Year - y) + "-" + (d.Month - month) + "-27 23:59:59";
            return Convert.ToDateTime(str);
        }

        private DateTime getDateByYear(DateTime d, int y)
        {
            String str = (d.Year - y) + "-1-1 00:00:00";
            return Convert.ToDateTime(str);
        }

        private void MAcc(Object param)
        {
            Object[] paras = param as Object[];
            DateTime fromDate = (DateTime)paras[0];
            DateTime toDate = (DateTime)paras[1];
            if (fromDate == null)
            {
                showInfo("没有足够的记录可以结算！");
                backrunning = false;
                return;
            }
            int m = getMonthCount(fromDate, toDate);
            if (m < 1 || fromDate.Day > 27)
            {
                showInfo("没有足够的记录可以结算！");
                backrunning = false;
                return;
            }
            stockTableAdapter.Fill(this.kuguanDataSet.stock);
            setMaxValue(this.kuguanDataSet.stock.Rows.Count);
            int i0 = 1;
            foreach (kuguanDataSet.stockRow row in kuguanDataSet.stock.Rows)
            {
                fromDate = (DateTime)paras[0];
                toDate = (DateTime)paras[1];
                m = getMonthCount(fromDate, toDate);
                kuguanDataSet.accountRow r;
                int c = (int)accountTableAdapter.Get0CountById(row.product_id, row.product_type_id);
                if (c == 0)
                {
                    r = InitRow(row);
                    m = getMonthCount(r.time, toDate);
                }
                DateTime initTime = (DateTime)accountTableAdapter.GetInitTime(row.product_id, row.product_type_id);
                if (initTime > fromDate)
                {
                    fromDate = initTime.AddDays(5).Date;
                    m = getMonthCount(fromDate, toDate);
                }
                accountTableAdapter.FillByCondition1(acc, row.product_id, row.product_type_id, fromDate, toDate);
                decimal remNum = 0;
                decimal remAmount = 0;
                for (int i = m; i > 0; i--)
                {
                    DateTime f_time = getDateByMonth(toDate, i + 1);
                    DateTime t_time = getDateByMonth(toDate, i);
                    if (i == m)
                    {
                        DataTable t = accountTableAdapter.GetLastRemain(f_time,row.product_id,row.product_type_id);
                        if (t != null && t.Rows.Count != 0)
                        {
                            remNum = Convert.ToDecimal(t.Rows[0]["num"]);
                            remAmount = Convert.ToDecimal(t.Rows[0]["amount"]);
                        }
                    }
                    var rs = from kuguanDataSet.accountRow r0 in acc
                             where r0.time > f_time && r0.time <= t_time
                             orderby r0.time
                             select r0;
                    decimal debNum = rs.Sum(r1 => r1.debit_num);
                    decimal debAmount = rs.Sum(r1 => r1.debit_amount);
                    decimal creNum = rs.Sum(r1 => r1.credit_num);
                    decimal creAmount = rs.Sum(r1 => r1.credit_amount);
                    if (rs.Count() > 0)
                    {
                        remNum = remNum + debNum - creNum;
                        remAmount = remAmount + debAmount - creAmount;
                    }

                    this.kuguanDataSet.account.AddaccountRow(
                        row.product_id, row.product_type_id, t_time, "", "本月合计",
                        debNum, 0, debAmount, creNum, 0, creAmount, "", remNum, 0, remAmount, 4);
                    
                }
                showProcess(i0);
                i0++;
                acc.Rows.Clear();
            }
            manager.UpdateAll(kuguanDataSet);
            showInfo("结算完成！");
            showProcess(0);
            backrunning = false;
        }

        private void YAcc(Object param)
        {
            Object[] paras = param as Object[];
            DateTime fromDate = (DateTime)paras[0];
            DateTime toDate = (DateTime)paras[1];
            if (fromDate == null)
            {
                showInfo("没有足够的记录可以结算！");
                backrunning = false;
                return;
            }
            int m = toDate.Year - fromDate.Year;
            if (m < 1)
            {
                MessageBox.Show("没有足够的记录可以结算！");
                backrunning = false;
                return;
            }
            stockTableAdapter.Fill(this.kuguanDataSet.stock);
            setMaxValue(this.kuguanDataSet.stock.Rows.Count);
            int i0 = 1;
            foreach (kuguanDataSet.stockRow row in kuguanDataSet.stock.Rows)
            {
                accountTableAdapter.FillByCondition2(acc, row.product_id, row.product_type_id, fromDate, toDate);
                decimal remNum = 0;
                decimal remAmount = 0;
                for (int i = m; i > 0; i--)
                {
                    DateTime f_time = getDateByYear(toDate, i);
                    DateTime t_time = getDateByYear(toDate, i - 1);
                    var rs = from kuguanDataSet.accountRow r0 in acc
                             where r0.time >= f_time && r0.time < t_time
                             orderby r0.time
                             select r0;
                    if (rs.Count() > 0)
                    {
                        remNum = rs.Last().remain_num;
                        remAmount = rs.Last().remain_amount;
                    }

                    this.kuguanDataSet.account.AddaccountRow(
                        row.product_id, row.product_type_id, t_time, "", "上年结转",
                        0, 0, 0, 0, 0, 0, "", remNum, 0, remAmount, 5);

                }
                acc.Rows.Clear();
                showProcess(i0);
                i0++;
            }
            manager.UpdateAll(kuguanDataSet);
            showInfo("结算完成！");
            showProcess(0);
            backrunning = false;
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
            MessageBox.Show(this, info,"通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void mCheckButton_Click(object sender, EventArgs e)
        {
            if (backrunning)
            {
                MessageBox.Show(this, "后台操作尚未完成", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int? c = (int)accountTableAdapter.Get0Count();
            if (c == 0)
            {
                MessageBox.Show("请先初始化账目！");
                return;
            }
            DateTime lastDate = Convert.ToDateTime(accountTableAdapter.GetLastMDate());
            DateTime now = DateTime.Now;
            if (lastDate > now)
                return;
            Thread t = new Thread(new ParameterizedThreadStart(MAcc));
            if (lastDate == null || lastDate.Year == 1)
            {
                DateTime? tmp = accountTableAdapter.GetFirstDate();
                if (tmp == null)
                {
                    MessageBox.Show(this, "没有记录可以结算！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                backrunning = true;
                t.Start(new Object[]{(DateTime)tmp,now});
            }
            else
            {
                backrunning = true;
                t.Start(new Object[] { lastDate.AddDays(5), now });
            }
            MessageBox.Show(this,"已在后台结算账目","通知",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void yCheckButton_Click(object sender, EventArgs e)
        {

            if (backrunning)
            {
                MessageBox.Show(this, "后台操作尚未完成", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int? c = (int)accountTableAdapter.Get0Count();
            if (c == 0)
            {
                MessageBox.Show("请先初始化账目！");
                return;
            }
            DateTime lastDate = Convert.ToDateTime(accountTableAdapter.GetLastYDate());
            DateTime now = DateTime.Now;
            if (lastDate > now)
                return;
            
            Thread t = new Thread(new ParameterizedThreadStart(YAcc));
            if (lastDate == null || lastDate.Year == 1)
            {
                DateTime? tmp = accountTableAdapter.GetFirstDate();
                if(tmp == null)
                    MessageBox.Show(this, "没有记录可以结算！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                backrunning = true;
                t.Start(new Object[] { tmp, now });
            }
            else
            {
                backrunning = true;
                t.Start(new Object[] { lastDate, now });
            }
            MessageBox.Show(this, "已在后台结算账目", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDGV();
        }

        private void printDGV()
        {
            if (MessageBox.Show("是否打印账目？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PrintDialog dg = new PrintDialog();
                DGVPrintDocument doc = new DGVPrintDocument(accountDetailView, "材料明细账",new int[]{});
                
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
                dg.Document = doc.Doc;
                doc.accInit();
                if (dg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    doc.Doc.DefaultPageSettings.Landscape = true;
                    doc.Doc.Print();
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExcelOperate excel = new ExcelOperate(this, "材料账目明细-" + storeBox.Text+"-"+engBox.Text+"-"+proNameBox.Text);
            excel.AccountExport(accountDetailView);
        }

        private void accountDetailView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccInitButton_Click(object sender, EventArgs e)
        {

            if (backrunning)
            {
                MessageBox.Show(this, "后台操作尚未完成", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Thread t = new Thread(new ThreadStart(AccInit));
            t.Start();
            backrunning = true;
            MessageBox.Show(this, "账目已开始初始化", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void AccInit()
        {
            kuguanDataSet.stockDataTable st = new kuguanDataSet.stockDataTable();
            kuguanDataSetTableAdapters.stockTableAdapter sta = new kuguanDataSetTableAdapters.stockTableAdapter();
            sta.Fill(st);
            setMaxValue(st.Rows.Count);
            int i = 1;
            foreach (kuguanDataSet.stockRow row in st.Rows)
            {
                InitRow(row);
                showProcess(i);
                i++;
            }
            manager.UpdateAll(kuguanDataSet);
            showInfo("初始化成功");
            showProcess(0);
        }

        private kuguanDataSet.accountRow InitRow(kuguanDataSet.stockRow row)
        {
            DateTime f_time = Convert.ToDateTime("1975-1-1");
            DateTime tmp = DateTime.Now;
            int c = (int)accountTableAdapter.Get0CountById(row.product_id, row.product_type_id);
            kuguanDataSet.accountDataTable accTmp = new kuguanDataSet.accountDataTable();
            kuguanDataSet.accountRow r = null;
            if (c == 0)
            {
                accountTableAdapter.FillByCondition1(accTmp, row.product_id, row.product_type_id, f_time, DateTime.Now);
                if (accTmp.Rows.Count == 0)
                {
                    tmp = DateTime.Now;
                    r = this.kuguanDataSet.account.AddaccountRow(
                        row.product_id, row.product_type_id,
                        getDateByMonth(tmp, 2),
                        "", "结转",
                        0, 0, 0, 0, 0, 0, "", row.stock_num,
                        row.stock_num == 0 ? 0 : row.stock_amount / row.stock_num,
                        row.stock_amount, 6);
                }
                else
                {
                    var rs = from kuguanDataSet.accountRow r0 in accTmp.Rows
                             select r0;
                    tmp = getDateByMonth(rs.First().time, 1);
                    Decimal debitNum = rs.Sum(r1 => r1.debit_num);
                    Decimal debitAcc = rs.Sum(r1 => r1.debit_amount);
                    Decimal creditNum = rs.Sum(r1 => r1.credit_num);
                    Decimal creditAcc = rs.Sum(r1 => r1.credit_amount);
                    Decimal remainNum = row.stock_num + creditNum - debitNum;
                    Decimal remainAcc = row.stock_amount + creditAcc - debitAcc;
                    r = this.kuguanDataSet.account.AddaccountRow(
                        row.product_id, row.product_type_id, tmp,
                        "", "结转",
                        0, 0, 0, 0, 0, 0, "", remainNum,
                        remainNum == 0 ? 0 : remainAcc / remainNum,
                        remainAcc, 6);
                }
                accTmp.Rows.Clear();
            }
            return r;
        }

        private void ProductAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (backrunning)
            {
                MessageBox.Show(this, "后台操作尚未完成", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
                return;
            }
        }

    }
}
