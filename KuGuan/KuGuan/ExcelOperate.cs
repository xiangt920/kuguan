using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace KuGuan
{
    public class ExcelOperate
    {
        private String fileName = "";
        private String saveFileName = "";
        private Excel.Application xlApp = null;
        public ExcelOperate(String fileName) 
        {
            this.fileName = fileName;
        }
        private Boolean init() 
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx";
            saveDialog.FileName = fileName;

            if (saveDialog.ShowDialog() == DialogResult.Cancel) 
            {
                return false;
            }
            saveFileName = saveDialog.FileName;
            xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机器未安装Excel");
                return false;
            }
            return true;
        }
        private int DataExport(Excel.Worksheet ws, DataGridView DGV, int startRow)
        { 
            //写入标题
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                ws.Cells[startRow, i + 1] = DGV.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < DGV.Rows.Count; r++)
            {
                for (int i = 0; i < DGV.ColumnCount; i++)
                {
                    if (DGV.Rows[r].Cells[i].Value is DateTime)
                    {
                        ws.Cells[r + startRow + 1, i + 1] = ((DateTime)DGV.Rows[r].Cells[i].Value).ToString("yyyy-MM-dd");
                    }
                    else
                        ws.Cells[r + startRow + 1, i + 1] = DGV.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            ws.Columns.EntireColumn.AutoFit();//列宽自适应
            return startRow + DGV.Rows.Count;
        }
        private void saveExcel(Excel.Workbook wb, int count)
        {
            if (saveFileName != "")
            {
                try
                {
                    wb.SaveAs(saveFileName);
                    xlApp.Quit();
                    GC.Collect();//强行销毁
                    MessageBox.Show("excel文件保存成功!\n共导出" + count + "条数据", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        public void StorageExport(DataGridView DGV, String sid, String time, String store_name, String eng_name, String supplier)
        {
            if (!init()) return;
            Excel.Workbooks wbs = xlApp.Workbooks;
            Excel.Workbook wb = wbs.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];//取得sheet1
            ws.Cells[1, 1] = "凭证号"; ws.Cells[1, 2] = sid;
            ws.Cells[2, 1] = "日期"; ws.Cells[2, 2] = time;
            ws.Cells[3, 1] = "仓库名"; ws.Cells[3, 2] = store_name;
            ws.Cells[3, 3] = "工程名"; ws.Cells[3, 4] = eng_name;
            ws.Cells[4, 1] = "供应商"; ws.Cells[4, 2] = supplier;

            int s = DataExport(ws, DGV, 6);
            ws.Range[ws.Cells[7, 4], ws.Cells[s, 4]].NumberFormat = "0.00000000000";
            ws.Range[ws.Cells[7, 5], ws.Cells[s, 5]].NumberFormat = "0.00000";
            ws.Range[ws.Cells[7, 7], ws.Cells[s, 7]].NumberFormat = "0.00000000000";
            ws.Columns.EntireColumn.AutoFit();
            saveExcel(wb, DGV.RowCount);
        }

        public void OutExport(DataGridView DGV, String sid, String time, String store_name, String eng_name)
        {
            if (!init()) return;
            Excel.Workbooks wbs = xlApp.Workbooks;
            Excel.Workbook wb = wbs.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];//取得sheet1

            ws.Cells[1, 1] = "凭证号"; ws.Cells[1, 2] = sid;
            ws.Cells[2, 1] = "日期"; ws.Cells[2, 2] = time;
            ws.Cells[3, 1] = "仓库名"; ws.Cells[3, 2] = store_name;
            ws.Cells[3, 3] = "工程名"; ws.Cells[3, 4] = eng_name;

            DataExport(ws, DGV, 5);
            saveExcel(wb, DGV.RowCount);
        }
        public void CompositeExport(DataGridView DGV,string sum,string amout)
        {
            if (!init()) return;
            Excel.Workbooks wbs = xlApp.Workbooks;
            Excel.Workbook wb = wbs.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];//取得sheet1
            int s = DataExport(ws, DGV, 1);
            ws.Cells[s + 1, 1] = "总计";
            ws.Cells[s + 1, 7] = sum;
            ws.Cells[s + 1, 9] = amout;
            ws.Range[ws.Cells[1,1], ws.Cells[s,1]].NumberFormat = "@";
            ws.Columns.EntireColumn.AutoFit();
            saveExcel(wb, DGV.RowCount);
        }
        public void ExchangeExport(DataGridView DGV, String sid, String time, String out_store_name, String out_eng_name, String in_store_name, String in_eng_name)
        {
            if (!init()) return;
            Excel.Workbooks wbs = xlApp.Workbooks;
            Excel.Workbook wb = wbs.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];//取得sheet1

            ws.Cells[1, 1] = "凭证号";   ws.Cells[1, 2] = sid;
            ws.Cells[2, 1] = "日期";     ws.Cells[2, 2] = time;
            ws.Cells[3, 1] = "调出仓库"; ws.Cells[3, 2] = out_store_name;
            ws.Cells[3, 3] = "调出工程"; ws.Cells[3, 4] = out_eng_name;
            ws.Cells[4, 1] = "调入仓库"; ws.Cells[4, 2] = in_store_name;
            ws.Cells[4, 3] = "调入工程"; ws.Cells[4, 4] = in_eng_name;

            DataExport(ws, DGV, 8);
            saveExcel(wb, DGV.RowCount);
        }
    }
}
