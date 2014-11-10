using KuGuan.Control;
using KuGuan.MForm;
using KuGuan.Utils;
using Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KuGuan.Utils
{
    public class ExcelOperate
    {
        Excel excel = new Excel();
        private int rowCount;
        private string saveFileName;
        private Form owner = null;
        private ProgressBar bar;
        private delegate void ImportInvoke(string info);
        private delegate void ShowBarInvoke(int value);
        private delegate void ShowSaveDialog(bool e, int count);
        private kuguanDataSet dataSet = new kuguanDataSet();
        private kuguanDataSetTableAdapters.TableAdapterManager manager;
        private kuguanDataSetTableAdapters.proTableAdapter proAdapter = new kuguanDataSetTableAdapters.proTableAdapter();
        private kuguanDataSetTableAdapters.stockTableAdapter stockAdapter = new kuguanDataSetTableAdapters.stockTableAdapter();
        private List<Object[]> objRows = new List<Object[]>();
        public ExcelOperate(Form owner, String fileName)
        {
            this.owner = owner;
            saveFileName = fileName;
        }
        public ExcelOperate(Form owner)
        {
            this.owner = owner;
            bar = (ProgressBar)owner.GetType().InvokeMember("Bar", BindingFlags.GetProperty, null, owner, null);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();

            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            manager = new kuguanDataSetTableAdapters.TableAdapterManager();
            manager.BackupDataSetBeforeUpdate = false;
            manager.customer_typeTableAdapter = null;
            manager.stockTableAdapter = stockAdapter;
            manager.proTableAdapter = proAdapter;
            manager.customerTableAdapter = new kuguanDataSetTableAdapters.customerTableAdapter();
            manager.supplier_typeTableAdapter = null;
            manager.supplierTableAdapter = new kuguanDataSetTableAdapters.supplierTableAdapter();
            manager.unitTableAdapter = null;
            manager.UpdateOrder = KuGuan.kuguanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            manager.userTableAdapter = null;
            manager.storageTableAdapter = null;
        }

        private Boolean init()
        {
            if (excel.init())
                return true;
            else
            {
                MessageBox.Show("调用失败，可能您的机器未安装excel");
                return false;
            }
        }

        private bool ImportInit()
        {
            if (init() && chooseFile())
            {
                //打开工作薄
                if (excel.OpenInit(saveFileName,1))
                    return true;
                else
                {
                    MessageBox.Show("无法打开excel，可能文件格式不正确！");
                    return false;
                }
            }
            else
                return false;
        }

        private void ShowInfo(string Info)
        {
            if (owner.InvokeRequired)
            {
                ImportInvoke tmpInvoke = new ImportInvoke(ShowInfo);
                try
                {
                    owner.Invoke(tmpInvoke, new object[] { Info });
                }
                catch { }
                return;
            }
            MessageBox.Show(owner, Info);
        }

        private void ShowBarValue(int value)
        {

            if (bar.InvokeRequired)
            {
                ShowBarInvoke tmpInvoke = new ShowBarInvoke(ShowBarValue);
                try
                {
                    owner.Invoke(tmpInvoke, new object[] { value });
                }
                catch { }
                return;
            }
            bar.Value = value;
        }

        private bool chooseFile()
        {
            bool e = true;
            try
            {
                Decimal version = excel.GetVersion();

                if (Decimal.ToDouble(version) >= 12.0)
                    e = true;
                else
                    e = false;
            }
            catch (Exception)
            {
                e = false;
            }
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = e ? "xlsx" : "xls";
            openDialog.Filter = e ? "excel文件|*.xlsx;*.xls" : "excel文件|*.xls;";
            openDialog.Multiselect = false;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileName = openDialog.FileName;
                return true;
            }
            else
            {
                release();
                return false;
            }
        }

        private bool ImportOneProductData(int index,
            int eng_id,
            Object obj_name,
            Object obj_spec,
            Object obj_unit,
            Object obj_price,
            Object obj_num,
            Object obj_amount,
            Object obj_remark)
        {
            try
            {
                string pro_name = (string)obj_name;
                if (pro_name == null || pro_name.Trim() == "")
                {
                    ShowInfo("成功导入 " + rowCount + " 条数据中的前 " + (index - 1) + " 条数据！\n" +
                        "若未全部导入，可能是第" + (index + 3) + "行附近数据格式不正确！");
                    return false;
                }
                string spec;
                if (obj_spec == null)
                {
                    spec = "";
                }
                else
                    spec = obj_spec.ToString();
                String unit_str = obj_unit == null ? "" : obj_unit.ToString();
                decimal num = Convert.ToDecimal(obj_num);
                decimal amount = Convert.ToDecimal(obj_amount);
                string remark = obj_remark == null ? "" : (string)(obj_remark);
                decimal price;
                if (num != 0 && amount != 0)
                    price = amount / num;
                else
                {
                    price = Convert.ToDecimal(obj_price);
                }
                int proId = DBUtil.GetProId(pro_name, spec,unit_str, Decimal.Round(price, 11), remark, dataSet.pro);
                if (proId > 0)
                    DBUtil.changeStock(proId, eng_id, num, price,amount, dataSet.stock);
                else
                    objRows.Add(new Object[]{
                        pro_name,
                        spec,
                        unit_str,
                        Decimal.Round(price, 11),
                        remark,
                        num,
                        amount});
            }
            catch (Exception)
            {
                ShowInfo("第" + (index + 4) + "行附近数据格式不正确，导入已中止！");
                return false;
            }
            if (index > rowCount - 4)
            {

                ShowBarValue(index);
                ShowInfo("成功导入文件中的所有数据！");
                return false;
            }
            ShowBarValue(index);
            return true;
        }

        private void ImportProductData()
        {
            int eng_id = -1;
            string title = "";
            try
            {
                title = (string)excel.ReadValue(1, 1);
                string store_name = title.Substring(1, title.IndexOf("物资清查") - 1);
                string eng_name = title.Substring(title.IndexOf("物资清查") + 5);
                eng_name = eng_name.Substring(0, eng_name.Length - 1);
                eng_id = DBUtil.GetEngId(store_name, eng_name);

            }
            catch (Exception)
            {
                ShowInfo("文件标题格式不正确，导入已中止！");
                excel.CloseFile(false);
                release();
                ((ProductForm)owner).Importing = false;
                ShowBarValue(0);
                manager.UpdateAll(dataSet);
                proAdapter.Fill(dataSet.pro);
                DBUtil.changeStock(objRows, eng_id, dataSet);
                manager.UpdateAll(dataSet);
                return;
            }
            stockAdapter.Fill(dataSet.stock);
            int index = 4;
            bool completed = false;
            int completedCount = 1;
            while (true)
            {
                objRows.Clear();
                Object[,] values;
                try
                {
                    if (index + 1000 > rowCount)
                        excel.GetRange("B" + index + ":H" + rowCount);
                    else
                        excel.GetRange("B" + index + ":H" + (index + 1000));
                    values = excel.ReadValue();
                }
                catch (Exception)
                {
                    release();
                    ShowInfo("文件可能被占用！");
                    return;
                }
                for (int i = 1; i <= values.GetLength(0); i++)
                {
                    if (!ImportOneProductData(completedCount,
                        eng_id,
                        values[i, 1],
                        values[i, 2],
                        values[i, 3],
                        values[i, 4],
                        values[i, 5],
                        values[i, 6],
                        values[i, 7]))
                    {
                        completed = true;
                        ShowBarValue(completedCount);
                        break;
                    }
                    ShowBarValue(completedCount);
                    completedCount++;
                }
                manager.UpdateAll(dataSet);
                Thread.Sleep(500);
                proAdapter.Fill(dataSet.pro);
                DBUtil.changeStock(objRows, eng_id, dataSet);
                try
                {
                    manager.UpdateAll(dataSet);
                }
                catch
                { 

                }
                stockAdapter.Fill(dataSet.stock);
                if (completed)
                {
                    break;
                }
                index += 1001;

            }

            excel.CloseFile(false);
            release();
            ((ProductForm)owner).Importing = false;
            ShowBarValue(0);
        }

        public void ImportProduct()
        {
            if (ImportInit())
            {
                proAdapter.Fill(dataSet.pro);
                ((ProductForm)owner).Importing = true;
                rowCount = excel.getMaxRows();
                if (rowCount < 4)
                {
                    MessageBox.Show(owner, "表格中没有足够的数据可以导入！");
                    ((ProductForm)owner).Importing = false;
                    release();
                    return;
                }
                ((ProductForm)owner).Bar.Maximum = rowCount - 3;
                Thread t = new Thread(new ThreadStart(ImportProductData));
                t.Start();
            }
            else
                release();
        }

        private bool ImportOneSupplierData(int index,
            int type_id,
            Object obj_name,
            Object obj_address,
            Object obj_phone,
            bool isSup)
        {
            if (index == 2603)
            {
                int a = 0;
                Console.WriteLine(a);
            }
            try
            {
                string name = (string)obj_name;
                if (name == null || name.Trim() == "")
                {
                    ShowInfo("成功导入 " + rowCount + " 条数据中的前 " + (index - 1) + " 条数据！\n" +
                        "若未全部导入，可能是第" + (index + 1) + "行附近数据格式不正确！");
                    return false;
                }
                string address;
                if (obj_address == null)
                {
                    address = "";
                }
                else
                    address = obj_address.ToString();
                string phone;
                if (obj_phone == null)
                {
                    phone = "";
                }
                else
                    phone = obj_phone.ToString();
                if (isSup)
                {
                    dataSet.supplier.AddsupplierRow(name, address, "", "", phone, "", "", "", "", "", type_id);
                }
                else
                    dataSet.customer.AddcustomerRow(type_id, name, address, "", "", phone, "", "", "", "", "");
            }
            catch (Exception)
            {
                ShowInfo("第" + (index + 1) + "行附近数据格式不正确，导入已中止！");
                return false;
            }
            if (index > rowCount - 2)
            {
                ShowBarValue(index);
                ShowInfo("成功导入文件中的所有数据！");
                return false;
            }
            ShowBarValue(index);
            return true;
        }

        private void ImportSupplierData(Object param)
        {
            Object[] paras = param as Object[];
            int type_id = (int)paras[0];
            bool isSup = (bool)paras[1];
            int index = 2;
            bool completed = false;
            int completedCount = 1;
            while (true)
            {
                dataSet.supplier.Rows.Clear();
                Object[,] values = null ;
                try
                {
                    if (index + 1000 > rowCount)
                        excel.GetRange("B" + index + ":D" + rowCount);
                    else
                        excel.GetRange("B" + index + ":D" + (index + 1000));
                    values = excel.ReadValue();
                }
                catch (Exception)
                {
                    ShowInfo("文件可能被占用！");
                    release();
                    return;
                }
                for (int i = 1; i <= values.GetLength(0); i++)
                {
                    if (!ImportOneSupplierData(completedCount,
                        type_id,
                        values[i, 1],
                        values[i, 2],
                        values[i, 3],
                        isSup))
                    {
                        completed = true;
                        break;
                    }
                    completedCount++;
                }
                manager.UpdateAll(dataSet);
                if (completed)
                    break;
                index += 1001;
            }
            excel.CloseFile(false);
            release();
            ShowBarValue(0);
            owner.GetType().InvokeMember("Importing", BindingFlags.SetProperty, null, owner, new Object[] { false });
        }

        public void ImportSupplier(object type_id, bool isSup)
        {
            if (ImportInit())
            {
                owner.GetType().InvokeMember("Importing", BindingFlags.SetProperty, null, owner, new Object[] { true });
                rowCount = excel.getMaxRows();
                if (rowCount < 2)
                {
                    MessageBox.Show(owner, "表格中没有足够的数据可以导入！");
                    owner.GetType().InvokeMember("Importing", BindingFlags.SetProperty, null, owner, new Object[] { false });
                    return;
                }
                bar.Maximum = rowCount - 1;
                Thread t = new Thread(new ParameterizedThreadStart(ImportSupplierData));
                t.Start(new Object[] { type_id, isSup });
            }
            else
                release();
        }

        private int DataExport( 
            DataGridView DGV, int startRow ,
            HashSet<int> colSet,bool writeTitle)
        {
            //写入标题
            if (writeTitle)
            {
                for (int i = 0; i < DGV.ColumnCount; i++)
                {
                    if(colSet == null || !colSet.Contains(i))
                        excel.WriteValue(startRow, i + 1, DGV.Columns[i].HeaderText);
                }
            }
            Object[,] vals = DGV2ObjArray(DGV,colSet);
            String maxCol = excel.ConvertColumnNum2String(
                DGV.ColumnCount-(colSet == null?0:colSet.Count));
            String rangeStr = "A" + (startRow + 1) + ":" + maxCol + (startRow + DGV.RowCount);
            excel.WriteValue(rangeStr, vals);
            return startRow + DGV.Rows.Count;
        }

        private Object[,] DGV2ObjArray(DataGridView DGV,HashSet<int> colSet)
        {
            Object[,] values = new Object[DGV.RowCount, DGV.ColumnCount - (colSet == null ? 0:colSet.Count)];
            if (colSet == null)
            {
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    DataGridViewRow row = DGV.Rows[i];
                    for (int j = 0; j < DGV.ColumnCount; j++)
                    {
                        values[i, j] = row.Cells[j].Value;
                    }
                }
            }
            else
            {
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    DataGridViewRow row = DGV.Rows[i];
                    int c = 0;
                    for (int j = 0; j < DGV.ColumnCount; j++)
                    {
                        if (!colSet.Contains(j))
                            values[i, j - c] = row.Cells[j].Value;
                        else
                            c++;
                    }
                }
            }
            return values;
        }

        private void saveExcel(int count)
        {
            try
            {
                bool e = true;
                try
                {
                    Decimal version = excel.GetVersion();

                    if (Decimal.ToDouble(version) >= 12.0)
                        e = true;
                    else
                        e = false;
                }
                catch (Exception)
                {
                    e = false;
                }
                showSaveDialog(e, count);

                excel.CloseFile(false);
                

            }
            catch (Exception ex)
            {
                ShowInfo("导出文件时出错,文件可能正被打开！\n" + ex.Message);

            }
            finally
            {
            }

        }

        private void showSaveDialog(bool e, int count)
        {
            if (owner.InvokeRequired)
            {
                ShowSaveDialog tmpInvoke = new ShowSaveDialog(showSaveDialog);
                try
                {
                    owner.Invoke(tmpInvoke, new Object[] { e, count });
                }
                catch (Exception)
                { }
                return;
            }
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = e ? "xlsx" : "xls";
            saveDialog.Filter = e ? "excel文件|*.xlsx|早期版本excel文件|*.xls" : "excel文件|*.xls;";
            saveDialog.FileName = saveFileName;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveDialog.FileName;
                try
                {
                    Boolean f = false;
                    if (saveFileName.Contains("xlsx"))
                    {
                       f =  excel.SaveFileCopyAs(saveFileName);
                    }
                    else
                    {
                        f = excel.SaveFileCopyAs(saveFileName);
                    }
                    if(f)
                        ShowInfo("excel文件保存成功!\n共导出" + count + "条数据");
                    else
                        ShowInfo("excel文件保存失败!\n可能文件已被其它程序占用！");
                }
                catch (TargetInvocationException)
                {
                    ShowInfo("excel文件保存失败!\n可能文件已被其它程序占用！");
                }
                
            }
        }

        public void StorageExport(DataGridView DGV, String sid, String time, String store_name, String eng_name, String supplier)
        {
            if (!init())
            {
                release();
                return;
            }
            if (!excel.CreateInit(1))
            {
                release();
                return;
            }

            excel.WriteValue(1, 1,"凭证号");
            excel.WriteValue(1, 2, sid);
            excel.WriteValue(2, 1, "日期");
            excel.WriteValue(2, 2, time);
            excel.WriteValue(3, 1, "仓库名");
            excel.WriteValue(3, 2, store_name);
            excel.WriteValue(3, 3, "类别名");
            excel.WriteValue(3, 4, eng_name);
            excel.WriteValue(4, 1, "供应商");
            excel.WriteValue(4, 2, supplier);

            Thread t = new Thread(new ParameterizedThreadStart(StorageExportData));
            t.Start(DGV);
        }

        private void StorageExportData(Object param)
        {
            DataGridView DGV = param as DataGridView;
            int s = DataExport(DGV, 6,null,true);
            excel.SetNumberFormat("D7:D" + s, "0.00000000000");
            excel.SetNumberFormat("E7:E" + s, "0.00000");
            excel.SetNumberFormat("G7:G" + s, "0.00000000000");
            excel.SetNumberFormat("B2:B2", "yyyy-MM-dd");
            saveExcel(DGV.RowCount);
            release();
        }

        public void OutExport(DataGridView DGV, String sid, String time, String store_name, String eng_name)
        {
            if (!init())
            {
                release();
                return;
            }
            if (!excel.CreateInit(1))
            {
                release();
                return;
            }

            excel.WriteValue(1, 1, "凭证号");
            excel.WriteValue(1, 2, sid);
            excel.WriteValue(2, 1, "日期");
            excel.WriteValue(2, 2, time);
            excel.WriteValue(3, 1, "仓库名");
            excel.WriteValue(3, 2, store_name);
            excel.WriteValue(3, 3, "类别名");
            excel.WriteValue(3, 4, eng_name);

            Thread t = new Thread(new ParameterizedThreadStart(OutExportData));
            t.Start(DGV);

        }

        private void OutExportData(Object param)
        {
            DataGridView DGV = param as DataGridView;
            int s = DataExport(DGV, 5,null,true);

            excel.SetNumberFormat("D7:D" + s, "0.00000000000");
            excel.SetNumberFormat("E7:E" + s, "0.00000");
            excel.SetNumberFormat("G7:G" + s, "0.00000000000");
            excel.SetNumberFormat("B2:B2", "yyyy-MM-dd");
            saveExcel(DGV.RowCount);
            release();
        }

        public void CompositeExport(DataGridView DGV, string sum, string amout)
        {

            if (!init())
            {
                release();
                return;
            }
            if (!excel.CreateInit(1))
            {
                release();
                return;
            }

            Thread t = new Thread(new ParameterizedThreadStart(CompositeExportData));
            t.Start(new Object[] { DGV, sum, amout });
        }

        private void CompositeExportData(Object param)
        {
            Object[] paras = param as Object[];
            DataGridView DGV = paras[0] as DataGridView;
            string sum = paras[1] as String;
            string amout = paras[2] as String;
            int s = DataExport(DGV, 1,null,true);

            excel.WriteValue(s + 1, 1,"总计");
            excel.WriteValue(s + 1, 8,sum );
            excel.WriteValue(s + 1, 9,amout);

            excel.SetNumberFormat("A2:A" + s,"0");
            excel.SetNumberFormat("F2:F" + s,"0.00000000000");
            excel.SetNumberFormat("H2:H" + s + 1,"0.00000");
            excel.SetNumberFormat("I2:I" + s + 1,"0.00000000000");
            excel.SetNumberFormat("B2:B" + s,"yyyy-MM-dd");
            saveExcel(DGV.RowCount);
            release();
        }

        public void ExchangeExport(DataGridView DGV, String sid, 
            String time, 
            String out_store_name, String out_eng_name, 
            String in_store_name, String in_eng_name)
        {
            if (!init())
            {
                release();
                return;
            }
            if (!excel.CreateInit(1))
            {
                release();
                return;
            }

            excel.WriteValue(1, 1, "凭证号");
            excel.WriteValue(1, 2, sid);
            excel.WriteValue(2, 1, "日期");
            excel.WriteValue(2, 2, time);
            excel.WriteValue(3, 1, "调出仓库");
            excel.WriteValue(3, 2, out_store_name);
            excel.WriteValue(3, 3, "调出类别");
            excel.WriteValue(3, 4, out_eng_name);
            excel.WriteValue(4, 1, "调入仓库");
            excel.WriteValue(4, 2, in_store_name);
            excel.WriteValue(4, 3, "调入类别");
            excel.WriteValue(4, 4, in_eng_name);

            Thread t = new Thread(new ParameterizedThreadStart(ExChangeExportData));
            t.Start(DGV);
        }

        public void ExChangeExportData(Object param)
        {
            DataGridView DGV = param as DataGridView;
            int s = DataExport( DGV, 6,null,true);

            excel.SetNumberFormat("D9:D" + s, "0.00000000000");
            excel.SetNumberFormat("E9:E" + s, "0.00000");
            excel.SetNumberFormat("G9:G" + s, "0.00000000000");
            excel.SetNumberFormat("B2:B2", "yyyy-MM-dd");

            saveExcel(DGV.RowCount);
            release();
        }

        public void AccountExport(HeaderUnitView HUV)
        {
            if (!init())
            {
                release();
                return;
            }
            if (!excel.CreateInit(1))
            {
                release();
                return;
            }
            Thread t = new Thread(new ParameterizedThreadStart(AccountExportData));
            t.Start(HUV);
        }

        private void AccountExportData(Object param)
        {
            HeaderUnitView HUV = param as HeaderUnitView;
            TreeView tree = HUV.ColumnTreeView[0];
            int x = 1;
            foreach (TreeNode n in tree.Nodes)
            {
                x = mergeTitle(x, n);
            }
            int s = DataExport(HUV, 3,null, false);

            excel.SetNumberFormat("A4:A" + s, "yyyy-MM-dd");
            excel.SetNumberFormat("B4:B" + s, "0");
            excel.SetNumberFormat("D4:D" + s, "0.00");
            excel.SetNumberFormat("E4:E" + s, "0.000");
            excel.SetNumberFormat("O4:O" + s, "0.00");
            excel.SetNumberFormat("P4:P" + s, "0.000");
            excel.SetNumberFormat("AA4:AA" + s, "0.00");
            excel.SetNumberFormat("AB4:AB" + s, "0.000");

            excel.SetVerticalAlignment("A1:AK" + s, 2);
            excel.SetHorizontalAlignment("A1:AK" + s, 3);
            excel.SetAutoFit("A1:AK" + s);
            saveExcel(HUV.RowCount);
            release();
        }

        private int mergeTitle(int x,TreeNode node)
        {
            if (node.Nodes.Count == 0)
            {
                String col = excel.ConvertColumnNum2String(x);
                excel.MergeCells(col + (node.Level + 1), col + 3,true);
                excel.WriteValue(node.Level + 1, x, node.Text);
                return x + 1;
            }
            else
            {
                int x0 = x;
                foreach (TreeNode n in node.Nodes)
                {
                    x0 = mergeTitle(x0, n);
                }
                excel.MergeCells(excel.ConvertColumnNum2String(x) + (node.Level + 1),
                        excel.ConvertColumnNum2String(x0 - 1) + (node.Level + 1),true);
                excel.WriteValue(node.Level + 1, x, node.Text);

                return x0;
            }
        }

        public void ProductExport(DataGridView DGV,string title)
        {
            if (!init())
            {
                release();
                return;
            }
            if (!excel.CreateInit(1))
            {
                release();
                return;
            }

            Thread t = new Thread(new ParameterizedThreadStart(ProductExportData));
            t.Start(new Object[]{DGV,title});
        }

        public void ProductExportData(Object param)
        {
            Object[] paras = (Object[])param;
            DataGridView DGV = paras[0] as DataGridView;
            string title = paras[1] as string;

            excel.MergeCells("A1", "G1",true);
            excel.WriteValue(1, 1, title);
            excel.SetHorizontalAlignment("A1:G1", 3);

            excel.MergeCells("D2", "F2",true);
            excel.WriteValue(2, 4, "账面价值");

            excel.WriteValue(3, 1, "序号");
            excel.WriteValue(3, 2, "物资名称");
            excel.WriteValue(3, 3, "规格");
            excel.WriteValue(3, 4, "单价");
            excel.WriteValue(3, 5, "数量");
            excel.WriteValue(3, 6, "金额");
            excel.WriteValue(3, 7, "备注");
            HashSet<int> colSet = new HashSet<int>();
            colSet.Add(5);
            colSet.Add(7);

            int s = DataExport(DGV, 3, colSet, false);

            excel.SetNumberFormat("A4:A" + s, "0");
            excel.SetNumberFormat("D4:F" + s, "0.00000000000");
            excel.SetNumberFormat("E4:F" + s, "0.00000");
            excel.SetNumberFormat("F4:F" + s, "0.00000000000");
            excel.SetAutoFit("A1:G" + s);
            saveExcel(DGV.RowCount);
            release();
        }

        
        private void release()
        {
            excel.Dispose();
        }
    }
}
