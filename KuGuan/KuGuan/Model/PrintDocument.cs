using KuGuan.Control;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KuGuan.Model
{
    class DGVPrintDocument
    {
        private PrintDocument doc;
        private DataGridView DGV;
        private float width;
        private float height;
        private string title;
        private Font titleFont = new Font("黑体", 12, FontStyle.Bold);
        private Font subTitleFont = new Font("宋体", 9, FontStyle.Regular);
        private Font footerFont = new Font("宋体", 9, FontStyle.Regular);
        private Font cellFont = new Font("宋体", 9, FontStyle.Regular);
        private int subCount = 1;
        private String[] subTitle;
        private int footerCount = 1;
        private String[] footer;
        private float rate = 1;
        private List<int> colWidthList = new List<int>();
        private Object[,] data;
        private int DGVWidth;
        private int currentPage = 1;
        private bool dgvCompeleted = false;
        private int compeletedRowCount = 0;
        private int currentCol = 0;
        private PrintPageEventArgs e0;
        private HashSet<String> nSet = new HashSet<string>();
        private int[] notPrintCol;

        #region
        public PrintDocument Doc { get { return doc; } }
        public Font TitleFont
        {
            set { titleFont = value; }
            get { return titleFont; }
        }
        public Font SubTitleFont
        {
            set { subTitleFont = value; }
            get { return subTitleFont; }
        }
        public Font FooterFont
        {
            set { footerFont = value; }
            get { return footerFont; }
        }
        public Font CellFont
        {
            set { cellFont = value; }
            get { return cellFont; }
        }
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }
        public int SubCount
        {
            get { return this.subCount; }
            set { this.subCount = value; }
        }
        public int FooterCount
        {
            get { return this.footerCount; }
            set 
            { 
                this.footerCount = value; 

            }
        }
        public String[] SubTitle
        {
            get { return this.subTitle; }
            set { this.subTitle = value; }
        }
        public String[] Footer
        {
            get { return this.footer; }
            set 
            { 
                this.footer = value;
                footerCount = footer.Count();
            }
        }
        #endregion

        public DGVPrintDocument()
        {
            doc = new PrintDocument();
            title = "";
            subTitle = null;
        }
        
        public DGVPrintDocument(DataGridView DGV, string docName,int[] cols)
        {
            notPrintCol = cols;
            doc = new PrintDocument();
            this.DGV = DGV;
            doc.DocumentName = docName;
            doc.PrintPage += doc_PrintPage;
            title = "";
            subTitle = null;
            nSet.Add("万");
            nSet.Add("千");
            nSet.Add("百");
            nSet.Add("十");
            nSet.Add("元");
            nSet.Add("角");
            nSet.Add("分");
        }

        public void docInit(bool isA4)
        {
            if (!isA4)
            {
                PageSettings newsetting = new PageSettings(doc.PrinterSettings);
                newsetting.PaperSize = new PaperSize("Doc", 950, 550);
                newsetting.Margins = new Margins(80, 80, 40, 40);
                doc.DefaultPageSettings = newsetting;
            }
            else
            {
                PageSettings newsetting = new PageSettings(doc.PrinterSettings);
                newsetting.Margins = new Margins(80, 80, 40, 40);
                doc.DefaultPageSettings = newsetting;
 
            }
        }

        public void accInit()
        {
            PageSettings newsetting = new PageSettings(doc.PrinterSettings);
            newsetting.Margins = new Margins(70, 70, 70, 70);
            doc.DefaultPageSettings = newsetting;
 
        }

        private void DGVdata2Array()
        {
            data = new Object[DGV.RowCount + 1, 
                DGV.ColumnCount - (notPrintCol == null?0:notPrintCol.Length)];
            
            Graphics g = DGV.CreateGraphics();
            int c = 0;
            foreach (DataGridViewColumn col in DGV.Columns)
            {
                if (notPrintCol.Contains(col.Index))
                {
                    c++;
                    continue;
                }
                string head = col.HeaderText;
                SizeF siF = g.MeasureString(head, cellFont);
                if (typeof(DateTime) == col.ValueType)
                {
                    SizeF siF0 = g.MeasureString("2012.12.12", cellFont);
                    if (siF0.Width > siF.Width)
                        colWidthList.Add(Convert.ToInt32(siF0.Width) + 5);
                    else
                        colWidthList.Add(Convert.ToInt32(siF.Width) + 5);
                }
                else
                {
                    if (nSet.Contains(head))
                    {
                        colWidthList.Add(Convert.ToInt32(siF.Width * 0.8));
                    }
                    else if (head == "凭证号" || head == "核对号")
                    {
                        colWidthList.Add(Convert.ToInt32(siF.Width) / 3 + 2);
                    }
                    else
                    {
                        colWidthList.Add(Convert.ToInt32(siF.Width) + 5);
                    }
                }
                data[0, col.Index - c] = head;
            }
            foreach (DataGridViewRow row in DGV.Rows)
            {
                c = 0;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (notPrintCol.Contains(cell.ColumnIndex))
                    {
                        c++;
                        continue;
                    }
                    object value = cell.Value;
                    if (!(value is DateTime))
                    {
                        String v = value.ToString();
                        if(cell.OwningColumn.HeaderText == "摘要")
                        if (!v.Contains(".") && v.Length > 12)
                            v = v.Substring(0, 12);
                        SizeF siF = g.MeasureString(v, cellFont);
                        int tmpW = Convert.ToInt32(siF.Width) + 5;
                        if (tmpW > colWidthList[cell.ColumnIndex - c])
                        {
                            colWidthList[cell.ColumnIndex - c] = tmpW;
                            data[cell.RowIndex + 1, cell.ColumnIndex - c] = v;
                        }
                        else
                            data[cell.RowIndex + 1, cell.ColumnIndex - c] = v;
                    }
                    else
                        data[cell.RowIndex + 1, cell.ColumnIndex - c] = ((DateTime)value).ToString("yyyy-MM-dd");
                }
            }
            DGVWidth = 0;
            foreach (int w in colWidthList)
            {
                DGVWidth += w;
            }
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e0 = e;

            float y = e.PageSettings.Margins.Top;
            Graphics g = e.Graphics;
            if (currentPage == 1)
            {
                DGVdata2Array();
                float x = e0.MarginBounds.Left;
                width = e0.MarginBounds.Width;//计算出有效打印区域的宽度
                height = e0.MarginBounds.Height;//计算出有效打印区域的高度
                rate = (float)width / DGVWidth;
                y = printTitle(x, y, g);
                if (!(DGV is HeaderUnitView))
                    y += 3;
                y = printSubTitle(y, g);
                if (!(DGV is HeaderUnitView))
                    y += 5;
            }
            if (DGV is HeaderUnitView)
                printAcc(y);
            else
                printDoc(y);
        }

        private void printDoc(float y)
        {
            Graphics g = e0.Graphics;
            if (!dgvCompeleted)
                y = printDGV(y, g);
            if (!dgvCompeleted)
            {
                currentPage++;
                e0.HasMorePages = true;
                return;
            }
            SizeF siF = g.MeasureString("测试", footerFont);
            int footerHeight = Convert.ToInt32(siF.Height);
            if (y + footerHeight > height + e0.MarginBounds.Top + 15)
            {
                currentPage++;
                e0.HasMorePages = true;
                return;
            }
            printFooter(y + 2, g);
            e0.HasMorePages = false;
        }

        private void printAcc(float y)
        {
            Graphics g = e0.Graphics;
            if (currentPage != 1)
            {
                y = printTitle(0, y, g);
                y = printSubTitle(y, g);
            }
            if (!dgvCompeleted)
                y = printHUV(y, g);
            if (!dgvCompeleted)
            {
                currentPage++;
                e0.HasMorePages = true;
                return;
            }
            printHUVBlank(y, g);
            e0.HasMorePages = false;
        }

        private float printTitle(float x, float y, Graphics g)
        {
            SizeF siF = g.MeasureString(title, titleFont); // 两个参数，第一个是字符串内容，第二个是字符串的字体，我看你声明的是这两个
            int titleWidth = Convert.ToInt32(siF.Width);
            int titleHeight = Convert.ToInt32(siF.Height);
            x = (width - titleWidth) / 2 + e0.MarginBounds.Left;
            g.DrawString(title, titleFont, Brushes.Black, new PointF(x, y));
            return y + titleHeight + 1;
        }

        private float printSubTitle(float y, Graphics g)
        {
            float x = e0.MarginBounds.Left;
            SizeF siF = g.MeasureString("测试", subTitleFont);
            int titleWidth = (int)(width / subCount);
            int titleHeight = Convert.ToInt32(siF.Height);
            for (int i = 0; i < subTitle.Count(); i++)
            {
                if (i % subCount == 0)
                {
                    x = e0.MarginBounds.Left;
                    if (i != 0)
                        y += titleHeight + 1;
                }
                else
                    x += titleWidth;
                g.DrawString(subTitle[i], subTitleFont, Brushes.Black, new PointF(x, y));
            }
            return y + titleHeight + 1;
        }

        private float printDGV(float y, Graphics g)
        {
            float x = e0.MarginBounds.Left;
            int w = (int)width;
            SizeF siF = g.MeasureString("测试", cellFont);
            int h = Convert.ToInt32(siF.Height);
            if (currentPage == 1)
            {
                y = printDGVTitle(y, g);
                compeletedRowCount++;
            }
            else
            {
                y = e0.MarginBounds.Top;
                g.DrawLine(Pens.Black, new Point((int)x, (int)y), new Point((int)x + w, (int)y));
                    
            }

            for (int i = compeletedRowCount; i < data.GetLength(0); i++)
            {
                if (y + h + 4 > height + e0.MarginBounds.Top)
                {
                    compeletedRowCount = i;
                    dgvCompeleted = false;
                    return y;
                }
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    g.DrawLine(Pens.Black, 
                        new Point((int)x, (int)y), 
                        new Point((int)x, (int)y + h + 4));
                    g.DrawString(data[i, j].ToString(), 
                        cellFont, 
                        Brushes.Black, 
                        new PointF(x, y+3));

                    x += colWidthList[j] * rate;
                }
                g.DrawLine(Pens.Black, new Point((int)x, (int)y), new Point((int)x, (int)y + h + 4));
                x = e0.MarginBounds.Left;
                y += h + 4;
                g.DrawLine(Pens.Black, new Point((int)x, (int)y), new Point((int)x + w, (int)y));
            }
            dgvCompeleted = true;
            return y;
        }

        private float printHUV(float y, Graphics g)
        {
            float x = e0.MarginBounds.Left;
            int w = (int)width;
            SizeF siF = g.MeasureString("测试", cellFont);
            int h = Convert.ToInt32(siF.Height);
            y = printHUVTitle(y, g);
            if (currentPage == 1)
                compeletedRowCount++;

            for (int i = compeletedRowCount; i < data.GetLength(0); i++)
            {
                if (y + h + 8> height + e0.MarginBounds.Top)
                {
                    compeletedRowCount = i;
                    return y + h + 8;
                }
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    g.DrawLine(Pens.Black,
                        new Point((int)x, (int)y),
                        new Point((int)x, (int)y + h + 8));
                    g.DrawString(
                        data[i, j].ToString(), 
                        cellFont, 
                        Brushes.Black, 
                        new PointF(x, y + 5));

                    x += colWidthList[j] * rate;
                }
                g.DrawLine(Pens.Black, 
                    new Point((int)x, (int)y), 
                    new Point((int)x, (int)y + h + 8));
                x = e0.MarginBounds.Left;
                y += h + 8;
                g.DrawLine(Pens.Black, new Point((int)x, (int)y), new Point((int)x + w, (int)y));
            }
            dgvCompeleted = true;
            return y;
        }

        private float printHUVBlank(float y, Graphics g)
        {
            float x = e0.MarginBounds.Left;
            int w = (int)width;
            SizeF siF = g.MeasureString("测试", cellFont);
            int h = Convert.ToInt32(siF.Height);
            while (true)
            {
                if (y + h + 8 > height + e0.MarginBounds.Top)
                {
                    return y;
                }
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    g.DrawLine(Pens.Black,
                        new Point((int)x, (int)y),
                        new Point((int)x, (int)y + h + 8));

                    x += colWidthList[j] * rate;
                }
                g.DrawLine(Pens.Black,
                    new Point((int)x, (int)y),
                    new Point((int)x, (int)y + h + 8));
                x = e0.MarginBounds.Left;
                y += h + 8;
                g.DrawLine(Pens.Black, new Point((int)x, (int)y), new Point((int)x + w, (int)y));
 
            }
        }

        private int calcWidth(int s, int l)
        {
            int w = 0;
            for (int i = s; i < s + l; i++)
                w += colWidthList.ElementAt(i);
            return w;
        }

        private float printDGVTitle(float y, Graphics g)
        {
            currentCol = 0;
            float x = e0.MarginBounds.Left;
            SizeF siF = g.MeasureString("测试", cellFont);
            int h = Convert.ToInt32(siF.Height);
            int w = e0.MarginBounds.Width;
            g.DrawLine(Pens.Black, new Point((int)x, (int)y), new Point((int)x + w, (int)y));
            for (int j = 0; j < data.GetLength(1); j++)
            {
                g.DrawLine(Pens.Black,
                    new Point((int)x, (int)y),
                    new Point((int)x, (int)y + h));
                g.DrawString(data[0, j].ToString(), cellFont, Brushes.Black, new PointF(x, y + 1));

                x += colWidthList[j] * rate;
            }
            g.DrawLine(Pens.Black,
                new Point((int)x, (int)y),
                new Point((int)x, (int)y + h));
            y += h; x = e0.MarginBounds.Left;
            g.DrawLine(Pens.Black,
                new Point((int)x, (int)y),
                new Point((int)x + w, (int)y));
            return y;
        }

        private float printHUVTitle(float y, Graphics g)
        {
            currentCol = 0;
            float x = e0.MarginBounds.Left;
            SizeF siF = g.MeasureString("测试", cellFont);
            int h = Convert.ToInt32(siF.Height);
            int w = e0.MarginBounds.Width;
            g.DrawLine(Pens.Black, new Point((int)x, (int)y), new Point((int)x + w, (int)y));

            HeaderUnitView huv = (HeaderUnitView)DGV;
            TreeView tree = huv.ColumnTreeView[0];
            foreach (TreeNode n in tree.Nodes)
                x = printTree(x, y, h, g, n);
            g.DrawLine(Pens.Black, 
                new Point((int)x, (int)y), 
                new Point((int)x, (int)y + (h + 6) * 3));
            y += (h + 6) * 3;

            
            return y;
        }

        private float printTree(float x,float y,int h, Graphics g, TreeNode node)
        {
            float w = colWidthList.ElementAt(currentCol) * rate;
            if (node.Nodes.Count == 0)
            {
                g.DrawLine(Pens.Black,
                    new Point((int)x, (int)y),
                    new Point((int)x, (int)(y + ((h + 6) * (3 - node.Level)))));
                g.DrawLine(Pens.Black,
                    new Point((int)x, (int)(int)(y + ((h + 6) * (3 - node.Level)))),
                    new Point((int)(x + w), (int)(int)(y + ((h + 6) * (3 - node.Level)))));
                SizeF siF = g.MeasureString("测试", cellFont);
                int sw = Convert.ToInt32(siF.Width);
                int sh = Convert.ToInt32(siF.Height);
                float kx = (w - sw) / 2;
                kx = kx > 2 ? kx : 3;
                if (node.Text == "核对号" || node.Text == "凭证号")
                {
                    g.DrawString(node.Text.Substring(0, 1), cellFont, Brushes.Black,
                        new PointF(x + kx - 4, y + 3));
                    g.DrawString(node.Text.Substring(1, 1), cellFont, Brushes.Black,
                        new PointF(x + kx - 4, y + h + 9));
                    g.DrawString(node.Text.Substring(2, 1), cellFont, Brushes.Black,
                        new PointF(x + kx - 4, y + h * 2+ 15));
                }
                else
                {
                    g.DrawString(node.Text, cellFont, Brushes.Black,
                        new PointF(x + kx - 4, y + ((h + 6) * (3 - node.Level) - sh) / 2));
                }
                currentCol++;
                return x + w;
            }
            else
            {
                float x0 = x;
                foreach (TreeNode n in node.Nodes)
                {
                    x0 = printTree(x0, y + h + 6, h, g, n);
                }
                w = x0 - x;
                g.DrawLine(Pens.Black,
                    new Point((int)x, (int)y),
                    new Point((int)x, (int)(y + h + 6)));
                g.DrawLine(Pens.Black,
                    new Point((int)x, (int)(y + h + 6)),
                    new Point((int)(x + w), (int)(y + h + 6)));

                SizeF siF = g.MeasureString("测试", cellFont);
                int sw = Convert.ToInt32(siF.Width);
                int sh = Convert.ToInt32(siF.Height);
                g.DrawString(node.Text, cellFont, Brushes.Black,
                    new PointF(x + (w - sw) / 2 - 4, y + 4));
                float ty = y + h + 6;
                return x + w;
            }
        }

        private float printFooter(float y, Graphics g)
        {
            float x = e0.MarginBounds.Left;
            SizeF siF = g.MeasureString("测试", footerFont);
            int footerWidth = (int)(width / footerCount);
            int footerHeight = Convert.ToInt32(siF.Height);
            for (int i = 0; i < footer.Count(); i++)
            {
                if (i % footerCount == 0)
                {
                    x = e0.MarginBounds.Left;
                    if (i != 0)
                        y += footerHeight + 1;
                }
                else
                    x += footerWidth;
                g.DrawString(footer[i], footerFont, Brushes.Black, new PointF(x, y+1));
            }
            return y + 1;
        }

    }
}
