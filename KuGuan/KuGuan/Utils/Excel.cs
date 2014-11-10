using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Utils
{
    /// <summary>
    /// Excel操作类，用于操作Excel
    /// </summary>
    class Excel : IDisposable
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);
        private Type excelType = null;
        private Object xlApp;
        private Object wbs;
        private Object wb;
        private Object sheets;
        private Object ws;
        private Object cell;
        private Object range;
        private Object rows;
        private Object cols;
        private Object objPt;
        private IntPtr pt { get; set; }
        public Excel() { }

        /// <summary>
        /// 初始化Excel应用
        /// </summary>
        /// <returns>初始化成功则返回true；否则，返回false。</returns>
        public Boolean init()
        {
            try
            {
                //获取应用类型
                excelType = Type.GetTypeFromProgID("Excel.Application");
                if (excelType == null)
                {
                    return false;
                }
                //创建远程对象的实例，即Excel实例
                xlApp = Activator.CreateInstance(excelType);
                if (xlApp == null)
                {
                    return false;
                }
                //获取应用句柄
                objPt = xlApp.GetType().InvokeMember("Hwnd", BindingFlags.GetProperty, null, xlApp, null);
                pt = new IntPtr((Int32)objPt);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 创建Excel文件并初始化Excel信息
        /// </summary>
        /// <param name="index">sheet序号</param>
        /// <returns>初始化成功则返回true；否则返回false。</returns>
        public Boolean CreateInit(int index)
        {
            return
                //获取workbook集
            GetWorkBooks() &&
                //添加新workbook
            CreateDocument() &&
                //获取sheet集
            GetSheets() &&
                //获取第一个sheet
            GetSheet(index);
        }

        /// <summary>
        /// 打开Excel文件并初始化Excel信息
        /// </summary>
        /// <param name="filename">Excel文件路径</param>
        /// <param name="index">sheet序号</param>
        /// <returns>初始化成功则返回true；否则返回false。</returns>
        public Boolean OpenInit(string filename, int index)
        {
            return
            GetWorkBooks() &&
                //打开Excel文件
                OpenDocument(filename) &&
                //获取sheet集
                GetSheets() &&
                //获取第一个sheet
                GetSheet(index);
        }

        /// <summary>
        /// 获取Excel版本号，如果失败则返回0.
        /// </summary>
        /// <returns>返回Excel版本号</returns>
        public Decimal GetVersion()
        {
            Decimal version = 0;
            try
            {
                version = Convert.ToDecimal(xlApp.GetType().InvokeMember("Version", BindingFlags.GetProperty, null, xlApp, null));
            }
            catch { }
            return version;
        }

        /// <summary>
        /// 获取Excel工作蒲
        /// </summary>
        /// <returns>获取成功则返回true；否则返回false。</returns>
        public Boolean GetWorkBooks()
        {
            try
            {
                wbs = xlApp.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, xlApp, null);
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

        /// <summary>
        /// 打开Excel文件
        /// </summary>
        /// <param name="filename">Excel文件路径</param>
        /// <returns>打开成功则返回true；否则返回false。</returns>
        public Boolean OpenDocument(string filename)
        {
            try
            {
                wb = wbs.GetType().InvokeMember("Open", BindingFlags.InvokeMethod, null, wbs, new Object[] { filename, true });
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 创建Excel文件
        /// </summary>
        /// <returns>创建成功则返回true；否则返回false。</returns>
        public Boolean CreateDocument()
        {
            try
            {
                wb = wbs.GetType().InvokeMember("Add", BindingFlags.InvokeMethod, null, wbs, null);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取工作蒲sheet集合
        /// </summary>
        /// <returns>成功则返回true；否则返回false。</returns>
        public Boolean GetSheets()
        {
            try
            {
                //获取sheet集
                sheets = wb.GetType().InvokeMember("Worksheets", BindingFlags.GetProperty, null, wb, null);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 根据sheet序号获取某个sheet
        /// </summary>
        /// <param name="index">sheet序号</param>
        /// <returns>成功则返回true；否则返回false。</returns>
        public Boolean GetSheet(int index)
        {
            try
            {
                //获取第一个sheet
                ws = sheets.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, sheets, new Object[] { index });
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 根据范围字符串获取范围区域
        /// </summary>
        /// <param name="rangeStr">范围字符串，例如“A1:C3”</param>
        /// <returns>成功则返回true；否则返回false。</returns>
        public Boolean GetRange(String rangeStr)
        {
            try
            {
                range = ws.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, ws, new object[] { rangeStr });
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取当前整个区域
        /// </summary>
        /// <returns>成功则返回true；否则返回false。</returns>
        public Boolean GetCurrentRegion()
        {
            try
            {
                range = range.GetType().InvokeMember("CurrentRegion", BindingFlags.GetProperty, null, range, null);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取指定区域中的所有行
        /// </summary>
        /// <returns>成功则返回true；否则返回false。</returns>
        public Boolean GetRowsOfRange()
        {
            try
            {
                rows = range.GetType().InvokeMember("Rows", BindingFlags.GetProperty, null, range, null);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 合并单元格
        /// </summary>
        /// <param name="start">起始单元格，例如“A1”</param>
        /// <param name="end">结尾单元格，例如“B2”</param>
        /// <param name="isMerge">是否合并</param>
        public void MergeCells(string start, string end, Boolean isMerge)
        {
            try
            {
                range = ws.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, ws,
                        new Object[] { start, end });
                range.GetType().InvokeMember("MergeCells", BindingFlags.SetProperty, null, range, new Object[] { isMerge });
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// 设置单元格格式
        /// </summary>
        /// <param name="rangeStr">范围字符串，表示一个区域，例如“A1:B2”</param>
        /// <param name="format">格式字符串</param>
        public void SetNumberFormat(string rangeStr, string format)
        {
            try
            {
                range = ws.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, ws, new Object[] { rangeStr });
                range.GetType().InvokeMember("NumberFormat", BindingFlags.SetProperty, null, range, new Object[1] { format });
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// 设置指定范围内文字垂直位置
        /// </summary>
        /// <param name="rangeStr">范围字符串，表示一个区域，例如“A1:B2”</param>
        /// <param name="ver">位置
        /// 1 居上，2 居中，3 居下，4 自动换行</param>
        public void SetVerticalAlignment(string rangeStr, int ver)
        {
            try
            {
                range = ws.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, ws, new Object[] { rangeStr });
                range.GetType().InvokeMember("VerticalAlignment", BindingFlags.SetProperty, null, range, new Object[1] { ver });
            }
            catch (Exception)
            { }
        }
        
        /// <summary>
        /// 设置指定范围内文字水平位置
        /// </summary>
        /// <param name="rangeStr">范围字符串，表示一个区域，例如“A1:B2”</param>
        /// <param name="hor">位置
        /// 2 居左，3 居中，4 居右，5 横向填充</param>
        public void SetHorizontalAlignment(string rangeStr, int hor)
        {
            try
            {
                range = ws.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, ws, new Object[] { rangeStr });
                range.GetType().InvokeMember("HorizontalAlignment", BindingFlags.SetProperty, null, range, new Object[1] { hor });
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// 设置指定范围内宽度自适应
        /// </summary>
        /// <param name="rangeStr">范围字符串，表示一个区域，例如“A1:B2”</param>
        public void SetAutoFit(string rangeStr)
        {
            try
            {
                range = ws.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, ws, new Object[] { rangeStr });
                cols = range.GetType().InvokeMember("Columns", BindingFlags.GetProperty, null, range, null);
                cols.GetType().InvokeMember("AutoFit", BindingFlags.InvokeMethod, null, cols, null);
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// 获取行集合中的行数
        /// </summary>
        /// <returns>返回行数</returns>
        public int GetCountOfRows()
        {
            try
            {
                return (int)rows.GetType().InvokeMember("Count", BindingFlags.GetProperty, null, rows, null);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 获取当前sheet中活动区域最大行号
        /// </summary>
        /// <returns>返回最大行号</returns>
        public int getMaxRows()
        {
            if (GetRange("A1:A1") &&
                GetCurrentRegion() &&
                GetRowsOfRange())
                return GetCountOfRows();
            return 0;
        }

        /// <summary>
        /// 将列序号转换为Excel中的列号，如1转换为A
        /// </summary>
        /// <param name="columnNum">列序号</param>
        /// <returns>返回列号</returns>
        public string ConvertColumnNum2String(int? columnNum)
        {
            if (columnNum > 26)
            {
                return string.Format("{0}{1}", (char)(((columnNum - 1) / 26) + 64), (char)(((columnNum - 1) % 26) + 65));
            }
            else
            {
                return ((char)(columnNum + 64)).ToString();
            }
        }

        /// <summary>
        /// 读取指定单元格内容
        /// </summary>
        /// <param name="row">单元格行号，从1开始</param>
        /// <param name="col">单元格列号，从1开始</param>
        /// <returns>返回单元格内容</returns>
        public Object ReadValue(int row, int col)
        {
            try
            {
                cell = ws.GetType().InvokeMember("Cells", BindingFlags.GetProperty, null, ws, new Object[] { row, col });
                return cell.GetType().InvokeMember("Value", BindingFlags.GetProperty, null, cell, null);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 读取指定区域中的内容到二维数组
        /// </summary>
        /// <returns>返回二维数组</returns>
        public Object[,] ReadValue()
        {
            try
            {
                return (Object[,])range.GetType().InvokeMember("Value", BindingFlags.GetProperty, null, range, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 向指定单元格写入内容
        /// </summary>
        /// <param name="row">单元格行号</param>
        /// <param name="col">单元格列号</param>
        /// <param name="value">将要写入单元格的内容</param>
        public void WriteValue(int row, int col, object value)
        {
            try
            {
                cell = ws.GetType().InvokeMember("Cells", BindingFlags.GetProperty, null, ws, new Object[2] { row, col });
                cell.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, cell, new Object[1] { value });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 将二维数组中的值一次性写入指定区域中
        /// </summary>
        /// <param name="rangeStr">范围字符串，例如“A1:C3”</param>
        /// <param name="vals">二维数组，存放即将写入文件的值</param>
        public void WriteValue(String rangeStr, Object[,] vals)
        {
            try
            {
                range = ws.GetType().InvokeMember("Range",
                      BindingFlags.GetProperty,
                      null,
                      ws,
                      new Object[] { rangeStr });
                range.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, range, new Object[] { vals });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 将Excel保存为xls格式
        /// </summary>
        /// <param name="fileanme">文件路径</param>
        /// <returns>成功则返回true；否则，返回false。</returns>
        public Boolean SaveFileAsXls(string fileanme)
        {
            try
            {
                wb.GetType().InvokeMember("SaveAs", BindingFlags.InvokeMethod, null, wb, new Object[2] { fileanme, -4143 });
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 强制保存Excel
        /// </summary>
        /// <param name="fileanme">文件路径</param>
        /// <returns>成功则返回true；否则，返回false。</returns>
        public Boolean SaveFileCopyAs(string fileanme)
        {
            try
            {
                wb.GetType().InvokeMember("SaveCopyAs", BindingFlags.InvokeMethod, null, wb, new Object[1] { fileanme });
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 关闭文件并退出Excel
        /// </summary>
        /// <param name="isSave">是否保存</param>
        public void CloseFile(Boolean isSave)
        {
            try
            {
                wb.GetType().InvokeMember("Close", BindingFlags.InvokeMethod, null, wb, new object[] { isSave });
                xlApp.GetType().InvokeMember("Quit", BindingFlags.InvokeMethod, null, xlApp, null);
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// 释放Excel进程资源
        /// </summary>
        private void release()
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                if (pt != null)
                {
                    int pid = 0;
                    GetWindowThreadProcessId(pt, out pid);
                    System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(pid);
                    p.Kill();
                }
            }
            catch { }
        }

        //释放EXCEL
        public void Dispose()
        {
            NAR();
        }

        /// <summary>
        /// 释放类资源
        /// </summary>
        private void NAR()
        {
            try
            {
                range = null;
                cell = null;
                ws = null;
                sheets = null;
                wb = null;
                wbs = null;
                GC.Collect();//强行销毁
                release();
            }
            catch { }
            finally
            {
                GC.Collect();
            }
        }
    }
}
