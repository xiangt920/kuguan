using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class CompositeForm : DockContent
    {
        private SupplierForm S = new SupplierForm(true);
        private CustomerForm C = new CustomerForm(true);
        private StoreForm ST = new StoreForm(true);
        private choose_product P = new choose_product();
        private int sup_id = -1;
        private int out_eng_id = -1;
        private int in_eng_id = -1;
        private int pro_id = -1;
        private string id = "";
        private decimal min_price = -1;
        private decimal max_price = -1;
        private decimal min_num = -1;
        private decimal max_num = -1;
        private decimal min_amount = -1;
        private decimal max_amount = -1;
        private bool refreshing = false;
        public CompositeForm()
        {
            InitializeComponent();
        }

        private void CompositeForm_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.exchange_management”中。您可以根据需要移动或删除它。
            this.exchange_managementTableAdapter.Fill(this.dataDataSet.exchange_management);
            // TODO:  这行代码将数据加载到表“dataDataSet.out_management”中。您可以根据需要移动或删除它。
            this.out_managementTableAdapter.Fill(this.dataDataSet.out_management);
            // TODO:  这行代码将数据加载到表“dataDataSet.storage_management”中。您可以根据需要移动或删除它。
            fromTimePicker.Value = DateTime.Now.Date.AddDays(-7);
            showSup(true);
            showCus(false);
            search();
        }
        private void showSup(bool show)
        {

            inEngBox.Visible = show;
            inEngLabel.Visible = show;
            inStoreBox.Visible = show;
            inStoreLabel.Visible = show;
        }
        private void showCus(bool show)
        {

            outEngBox.Visible = show;
            outEngLabel.Visible = show;
            outStoreBox.Visible = show;
            outStoreLabel.Visible = show;
            
        }
        private void storageDocButton_CheckedChanged(object sender, EventArgs e)
        {
            storageDetailView.Visible = storageDocButton.Checked;
            if (storageDocButton.Checked)
            {
                supLabel.Visible = true;
                supBox.Visible = true;
                supLabel.Text = "供应商：";
                showSup(true);
                refreshButton_Click(sender, e);
            } 
            else
            {
                showSup(false);
            }

        }

        private void outDocButton_CheckedChanged(object sender, EventArgs e)
        {
            outDetailView.Visible = outDocButton.Checked;
            if (outDocButton.Checked)
            {
                supLabel.Visible = true;
                supBox.Visible = true;
                supLabel.Text = "客户：";
                showCus(true);
                refreshButton_Click(sender, e);
            }
            else
            {
                showCus(false);
            }
        }

        private void exchangeDocButton_CheckedChanged(object sender, EventArgs e)
        {
            exchangeDetailView.Visible = exchangeDocButton.Checked;
            if (exchangeDocButton.Checked)
            {
                supLabel.Visible = false;
                supBox.Visible = false;
                showCus(true);
                showSup(true);
                refreshButton_Click(sender, e);
            }
            else
            {

                showCus(false);
                showSup(false);
 
            }
        }

        private bool isNum(string s)
        {
            Regex reg = new Regex("^\\d+(\\.\\d{0,11})?$");
            return reg.IsMatch(s);
        }
        private void minPriceBox_TextChanged(object sender, EventArgs e)
        {
            if (refreshing)
                return;
            TextBox b = (TextBox)sender;
            if (b.Text == "")
            {
                textVal(b);
                return;
            }
            if (!isNum(b.Text))
            {
                b.Text = "";
            }
            textVal(b);
        }

        private void textVal(TextBox box)
        {
            decimal tmp = -1;
            if (box.Name == "minPriceBox")
            {
                tmp = min_price;
                if(!Decimal.TryParse(box.Text,out min_price))
                    min_price = -1;
                if(tmp!=min_price)
                    search();
            }
            else if (box.Name == "maxPriceBox")
            {
                tmp = max_price;
                if (!Decimal.TryParse(box.Text, out max_price))
                    max_price = -1;
                if (tmp != max_price)
                    search();
            }
            else if (box.Name == "minNumBox")
            {
                tmp = min_num;
                if (!Decimal.TryParse(box.Text, out min_num))
                    min_num = -1;
                if (tmp != min_num)
                    search();
            }
            else if (box.Name == "maxNumBox")
            {
                tmp = max_num;
                if (!Decimal.TryParse(box.Text, out max_num))
                    max_num = -1;
                if (tmp != max_num)
                    search();
            }
            else if (box.Name == "minAmountBox")
            {
                tmp = min_amount;
                if (!Decimal.TryParse(box.Text, out min_amount))
                    min_amount = -1;
                if (tmp != min_amount)
                    search();
            }
            else if (box.Name == "maxAmountBox")
            {
                tmp = max_amount;
                if (!Decimal.TryParse(box.Text, out max_amount))
                    max_amount = -1;
                if (tmp != max_amount)
                    search();
            }
        }

        private void minPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == '.' || e.KeyChar == '\b'))
                e.Handled = true;
        }

        private void outStoreBox_Click(object sender, EventArgs e)
        {
            int tmpEngId = out_eng_id;
            if (ST.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outStoreBox.Text = ST.ParentName;
                outEngBox.Text = ST.SName;
                this.out_eng_id = ST.Id;
            }
            else
            {
                outStoreBox.Text = "";
                outEngBox.Text = "";
                this.out_eng_id = -1;
            }
            if (tmpEngId != out_eng_id)
                search();

        }

        private void inStoreBox_Click(object sender, EventArgs e)
        {
            int tmpEngId = in_eng_id;
            if (ST.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                inStoreBox.Text = ST.ParentName;
                inEngBox.Text = ST.SName;
                this.in_eng_id = ST.Id;
            }
            else
            {
                inStoreBox.Text = "";
                inEngBox.Text = "";
                this.in_eng_id = -1;
            }
            if (tmpEngId != in_eng_id)
                search();
        }

        private void proIdBox_Click(object sender, EventArgs e)
        {
            int tmpProId = pro_id;
            if (P.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                proIdBox.Text = P.ID;
                proNameBox.Text = P.ProName;
                if (!Int32.TryParse(P.ID, out this.pro_id))
                    this.pro_id = -1;
            }
            else
            {
                proIdBox.Text = "";
                proNameBox.Text = "";
                this.pro_id = -1;
            }
            if (tmpProId != pro_id)
                search();
        }

        private void supBox_Click(object sender, EventArgs e)
        {
            int tmpSupId = sup_id;
            if (storageDocButton.Checked)
            {
                if (S.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    supBox.Text = S.SupName;
                    this.sup_id = S.Id;
                }
                else
                {
                    supBox.Text = "";
                    this.sup_id = -1;
                }
            }
            else if(outDocButton.Checked)
            {
                if (C.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    supBox.Text = C.CusName;
                    this.sup_id = C.Id;
                }
                else
                {
                    supBox.Text = "";
                    this.sup_id = -1;
                }
            }
            if (tmpSupId != sup_id)
                search();
        }

        private void fromTimePicker_ValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            if (refreshing)
                return;
            id = idBox.Text;
            search();
        }

        private void search() 
        {
            if (storageDocButton.Checked)
            {
                this.storage_managementTableAdapter.FillByCondition(dataDataSet.storage_management,
                    fromTimePicker.Value.Date.AddDays(-0.0000001),
                    toTimePicker.Value.Date.AddDays(0.9999999),
                    id,
                    sup_id,
                    in_eng_id,
                    pro_id,
                    min_price,
                    max_price,
                    min_num,
                    max_num,min_amount,
                    max_amount);
                var result = from dataDataSet.storage_managementRow r2 in dataDataSet.storage_management.Rows
                             select r2;
                numBox.Text = result.Sum(r3 => r3.num) + "";
                amountBox.Text = "￥ " + result.Sum(r4 => r4.total_price);
            }
            else if (outDocButton.Checked)
            {
                this.out_managementTableAdapter.FillByCondition(dataDataSet.out_management,
                    fromTimePicker.Value.Date.AddDays(-0.0000001),
                    toTimePicker.Value.Date.AddDays(0.9999999),
                    id,
                    sup_id,
                    out_eng_id,
                    pro_id,
                    min_price,
                    max_price,
                    min_num,
                    max_num,
                    min_amount,
                    max_amount);
                var result = from dataDataSet.out_managementRow r2 in dataDataSet.out_management.Rows
                             select r2;
                numBox.Text = result.Sum(r3 => r3.storage_num) + "";
                amountBox.Text = "￥ " + result.Sum(r4 => r4.total_price);
            }
            else if (exchangeDocButton.Checked)
            {
                this.exchange_managementTableAdapter.FillByCondition(dataDataSet.exchange_management,
                    fromTimePicker.Value.Date.AddDays(-0.0000001),
                    toTimePicker.Value.Date.AddDays(0.9999999),
                    id,
                    out_eng_id,
                    in_eng_id,
                    pro_id,
                    min_price,
                    max_price,
                    min_num,
                    max_num,
                    min_amount,
                    max_amount);
                var result = from dataDataSet.exchange_managementRow r2 in dataDataSet.exchange_management.Rows
                             select r2;
                numBox.Text = result.Sum(r3 => r3.exchange_num) + "";
                amountBox.Text = "￥ " + result.Sum(r4 => r4.total_price);
            }
        }

        private void conditionInit() 
        {
            fromTimePicker.Value = DateTime.Now.Date.AddDays(-7);
            toTimePicker.Value = DateTime.Now;
            idBox.Text = id = supBox.Text = outStoreBox.Text
                = outEngBox.Text = inStoreBox.Text = inEngBox.Text
                = proIdBox.Text = proNameBox.Text = minPriceBox.Text
                = maxPriceBox.Text = minNumBox.Text = maxNumBox.Text
                = minAmountBox.Text = maxAmountBox.Text = "";
            sup_id = out_eng_id = in_eng_id = pro_id = -1;
            min_price = max_price = min_num = max_num = min_amount = max_amount = -1;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshing = true;
            conditionInit();
            refreshing = false;
            search();
        }

        private void saveExcelButton_Click(object sender, EventArgs e)
        {
            if (storageDocButton.Checked)
            {
                if (storageDetailView.Rows.Count <= 0)
                {
                    MessageBox.Show("没有可导出的数据！");
                    return;
                }
                ExcelOperate excel = new ExcelOperate("综合入库记录");
                excel.CompositeExport(storageDetailView,numBox.Text,amountBox.Text);
            }
            else if (outDocButton.Checked)
            {
                if (outDetailView.Rows.Count <= 0)
                {
                    MessageBox.Show("没有可导出的数据！");
                    return;
                }
                ExcelOperate excel = new ExcelOperate("综合出库记录");
                excel.CompositeExport(outDetailView, numBox.Text, amountBox.Text);
            }
            else if (exchangeDocButton.Checked)
            {
                if (exchangeDetailView.Rows.Count <= 0)
                {
                    MessageBox.Show("没有可导出的数据！");
                    return;
                }
                ExcelOperate excel = new ExcelOperate("综合调库记录");
                excel.CompositeExport(exchangeDetailView, numBox.Text, amountBox.Text);
            }
        }
    
    }
}
