using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace KuGuan.MForm
{
    public partial class storage_management : DockContent
    {
        private dataDataSetTableAdapters.QueriesTableAdapter procAdapter = new dataDataSetTableAdapters.QueriesTableAdapter();
        private SupplierForm C = new SupplierForm(true);
        private StoreForm S = new StoreForm(true);
        private choose_product P = new choose_product();
        private int engId;
        public storage_management()
        {
            InitializeComponent();
        }

        private void choose_product(object sender, EventArgs e)
        {
            if (P.ShowDialog() == DialogResult.OK)
            {
                proIdBox.Text = P.ID;
                proNameBox.Text = P.ProName;
                unitBox.Text = P.Unit;
                priceBox.Text = P.InPrice;
                this.numUpDown.Focus();
                this.numUpDown.Select(0, numUpDown.Value.ToString().Length);

            }
        }
        private List<String> to = new List<String>();
        private void storage_management_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.product_type”中。您可以根据需要移动或删除它。
            this.product_typeTableAdapter.Fill0(this.dataDataSet.product_type);
            string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date));
            new_id++;
            sidBox.Text = new_id.ToString();
        }

        private bool isPrice(string s)
        {
            Regex reg = new Regex("\\d+\\.\\d{11}");
            return reg.IsMatch(s);
        }
        private void show_on_list(object sender, EventArgs e)
        {

            if (proNameBox.Text == "")
            {
                MessageBox.Show("请您选择货品");
                return;
            }
            if (numUpDown.Value == 0)
            {
                MessageBox.Show("请您填写货品数量");
                return;
            }
            if (!isPrice(priceBox.Text))
            {
                MessageBox.Show("请您填写货品价格");
                return;
            }
            if (unitBox.Text == "")
            {
                MessageBox.Show("请您填写货品单位");
                return;
            }
            try
            {
                KuGuan.dataDataSet.storage_managementRow row = (dataDataSet.storage_managementRow)this.dataDataSet.storage_management.NewRow();
                row.BeginEdit();
                row.s_id = sidBox.Text;
                row.t = datePicker.Value;
                row.supplier_id = C.Id;
                row.product_type_id = S.Id;
                row.product_id = Int32.Parse(proIdBox.Text);
                row.pro_name = proNameBox.Text;
                row.unit_id = P.UnitId;
                row.unit_name = unitBox.Text;
                row.num = numUpDown.Value;
                row.get_price = Decimal.Parse(priceBox.Text);
                row.total_price = Decimal.Round(numUpDown.Value * Decimal.Parse(priceBox.Text),11);
                row.EndEdit();
                this.dataDataSet.storage_management.Addstorage_managementRow(row);
                var rs = from dataDataSet.storage_managementRow r0 in dataDataSet.storage_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.num)+"";
                amountBox.Text = rs.Sum(r1 => r1.total_price)+"";

            }
            catch (System.Exception)
            {
            }
            
            
        }

        private void choose_supplier(object sender, EventArgs e)
        {
            
            if (C.ShowDialog() == DialogResult.OK)
            {
                supIdBox.Text = C.Id.ToString();
                supNameBox.Text = C.SupName;
                this.numUpDown.Focus(); 
                this.numUpDown.Select(0,numUpDown.Value.ToString().Length);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataDataSet.storage_management.Rows.Clear();
            sumBox.Text = "0";
            amountBox.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = this.dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(row_index);

                var rs = from dataDataSet.storage_managementRow r0 in dataDataSet.storage_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.num) + "";
                amountBox.Text = rs.Sum(r1 => r1.total_price) + "";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dateTimePicker1_TabIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string date = datePicker.Value.ToString("yyyyMMdd");  //.ToString("yyyyMMdd");
                Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date)) + 1;
                sidBox.Text = new_id.ToString();
            }
            catch (System.Exception)
            {
                
            }
        }
        public Boolean saveAll()
        {
            if (supNameBox.Text == "")
            {
                MessageBox.Show("请您选择供应商");
                return false ;
            }

            if (storeBox.Text.Trim() == "" || engBox.Text.Trim() == "")
            {
                MessageBox.Show("请您选择仓库");
                return false;
            }
            int count = 0;
            if (this.dataDataSet.storage_management.Rows.Count == 0)
                return false;
            List<KuGuan.dataDataSet.storage_managementRow> successedRows = new List<dataDataSet.storage_managementRow>();

            foreach (KuGuan.dataDataSet.storage_managementRow row in this.dataDataSet.storage_management.Rows)
            {
                int c = this.storage_managementTableAdapter.AddStorage(
                    row.s_id,
                    row.t,
                    row.supplier_id,
                    row.product_id,
                    row.num,
                    row.product_type_id);
                if (c > 0)
                {
                    count += c;

                    successedRows.Add(row);
                }
            }
            if (count == this.dataDataSet.storage_management.Rows.Count)
            {
                MessageBox.Show("成功入库所有信息(" + count + "条)！");
            }
            else
            {
                MessageBox.Show("提交入库信息条数:" + this.dataDataSet.storage_management.Rows.Count
                    + "\n成功入库信息条数:" + count);
                foreach (KuGuan.dataDataSet.storage_managementRow r in successedRows)
                    this.dataDataSet.storage_management.Rows.Remove(r);
                var rs = from dataDataSet.storage_managementRow r0 in dataDataSet.storage_management.Rows
                         select r0;
                sumBox.Text = rs.Sum(r1 => r1.num) + "";
                amountBox.Text = rs.Sum(r1 => r1.total_price) + "";
            }

            string date = datePicker.Value.ToString("yyyyMMdd");
            Decimal new_id = Decimal.Parse((String)this.storage_managementTableAdapter.find(date)) + 1;
            sidBox.Text = new_id.ToString();


            panel2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            datePicker.Enabled = true;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!saveAll()) return;
            if (MessageBox.Show("是否打印单据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                DGVPrinter printer = new DGVPrinter();
                
                printer.Title = "XXXXXX公司";

                printer.SubTitleFont = new Font("宋体", 9, FontStyle.Regular);
                printer.SubTitleFormatFlags = StringFormatFlags.NoWrap;
                printer.SubTitleAlignment = StringAlignment.Near;
                printer.SubTitle = "\n\n凭证号：" + sidBox.Text + "\n日  期：" + datePicker.Value + "\n仓库名：" + storeBox.Text + "     工程名：" + engBox.Text + "\n供应商：" + supNameBox.Text + "\n\n";
                
                
                printer.PageNumbers = false;
                printer.PorportionalColumns = true;
                printer.CellAlignment = StringAlignment.Center;
                printer.HeaderCellAlignment = StringAlignment.Center;


                printer.FooterFont = new Font("宋体", 9, FontStyle.Regular);
                printer.Footer = "操作员：" + ((MainForm)this.MdiParent).MUser.Username + "                                      总数量：" + sumBox.Text + "      总价格：" + amountBox.Text;
                printer.FooterSpacing = 15;
                printer.PageSeparator = " / ";
                printer.PageText = "";

                printer.PrintNoDisplay(dataGridView1);
            }
            this.dataDataSet.storage_management.Rows.Clear();
            sumBox.Text = "0";
            amountBox.Text = "0";
        }

        private void storage_management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dataDataSet.storage_management.Rows.Count > 0) 
            {
                if (MessageBox.Show(
                    "还有" + this.dataDataSet.storage_management.Rows.Count + "入库信息尚未提交，确定放弃？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                        e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }

        private void storeBox_Click(object sender, EventArgs e)
        {
            if (S.ShowDialog() == DialogResult.OK)
            {
                this.engId = S.Id;
                storeBox.Text = S.ParentName;
                engBox.Text = S.SName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "工作薄(*.xlsx)|*.xlsx;*.xls";
            if (openfile.FilterIndex == 1 && openfile.ShowDialog() == DialogResult.OK)
                ExcelToDS(openfile.FileName);
        }
        private DateTime ConvertExcelDateTimeIntoCLRDateTime(object value)
        {
            //if (value is DateTime)
            //{
            //    return DateTime.Parse(value.ToString());
            //}
            //else
            //{
            //    double a = Convert.ToInt32(value);
            //    string dt = DateTime.FromOADate(Convert.ToInt32(value)).ToString("d");
            //    return DateTime.Parse(dt);
            //}
            return DateTime.Parse(value.ToString());
        }
        public void ExcelToDS(string path)
        {
            //HDR=YES 有两个值:YES/NO,表示第一行是否字段名,默认是YES,第一行是字段名
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + @path + ";" + "Extended Properties='Excel 12.0;HDR=No;IMEX=1'";
            //string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + @path + ";" + "Extended Properties='Excel 8.0;HDR=No;IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable schemaTable = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
            //获取Excel的表名，默认值是sheet1
            string tableName = schemaTable.Rows[0][2].ToString().Trim();
            string strExcel = "select * from [" + tableName + "]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strExcel, strConn);
            DataTable ExcelTable = new DataTable();
            myCommand.Fill(ExcelTable);
            conn.Close();

            String id = ExcelTable.Rows[0][1].ToString();
            String s_id = id.Substring(1, id.Length - 2);
            DateTime t = ConvertExcelDateTimeIntoCLRDateTime(ExcelTable.Rows[1][1]);
            String store_name = (String)ExcelTable.Rows[2][1];
            String eng_name = (String)ExcelTable.Rows[2][3];
            String supplier_name = (String)ExcelTable.Rows[3][1];
            storeBox.Text = store_name;
            engBox.Text = eng_name;
            sidBox.Text = s_id;
            int? engId = -1;
            procAdapter.GetEngId(store_name, eng_name, ref engId);
            int? supId = -1;
            procAdapter.GetSupId(supplier_name, ref supId);
            supIdBox.Text = supId + "";
            supNameBox.Text = supplier_name;
            panel2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            datePicker.Enabled = false;
            this.dataDataSet.storage_management.Rows.Clear();
            for (int i = 6; i < ExcelTable.Rows.Count; i++)
            {
                try
                {
                    KuGuan.dataDataSet.storage_managementRow row = (dataDataSet.storage_managementRow)this.dataDataSet.storage_management.NewRow();
                    row.BeginEdit();
                    row.s_id = s_id;
                    row.t = t;
                    row.store_name = store_name;
                    row.eng_name = eng_name;
                    row.supplier_id = (int)supId;
                    row.cust_name = supplier_name;
                    row.product_type_id = (int)engId;
                    row.product_id = Convert.ToInt32(ExcelTable.Rows[i][0]);
                    row.pro_name = (String)ExcelTable.Rows[i][1];
                    row.spec = ExcelTable.Rows[i][2] is DBNull? "" : (String)ExcelTable.Rows[i][2];
                    row.get_price = Convert.ToDecimal(ExcelTable.Rows[i][3]);
                    row.num = Convert.ToDecimal(ExcelTable.Rows[i][4]);
                    string unit_name = (String)ExcelTable.Rows[i][5];
                    int? unit_id = -1;
                    row.unit_name = unit_name;
                    procAdapter.GetUnitId(unit_name, ref unit_id);
                    row.unit_id = (int)unit_id ;

                    row.total_price = Convert.ToDecimal(ExcelTable.Rows[i][6]);
                    row.EndEdit();
                    this.dataDataSet.storage_management.Addstorage_managementRow(row);

                }
                catch (System.Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

            var rs = from dataDataSet.storage_managementRow r0 in dataDataSet.storage_management.Rows
                     select r0;
            sumBox.Text = rs.Sum(r1 => r1.num) + "";
            amountBox.Text = rs.Sum(r1 => r1.total_price) + "";
        }
    
    }
}
