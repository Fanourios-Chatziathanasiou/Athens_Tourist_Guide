using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    class Print
    {
        private Font printFont;
        public List<string> LabelToPrint { get; set; }

        //The PrintPage evnet is raised for each page to be printed.
        private void PD_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage;
            float yPos;
            int linesCount = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;

            String line ="";
            Boolean newLabel = false;

            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            while (linesCount < linesPerPage && LabelToPrint.Count != 0)
            {   
                LabelToPrint[0] = Regex.Replace(LabelToPrint[0], @"\t|\n|\r", "");
                if (LabelToPrint[0].Length < 97)
                {
                    newLabel = true;
                    //MessageBox.Show(LabelToPrint[0].ToString());
                    line = LabelToPrint[0];
                    LabelToPrint.RemoveAt(0);
                }
                else
                {
                    newLabel = false;
                    for (int i = 0; i < 16; i++)
                    {
                        if (LabelToPrint[0][81 + i].ToString() == " ")
                        {
                            //MessageBox.Show(LabelToPrint[0].ToString());
                            line = LabelToPrint[0].Substring(0, 82 + i);
                            //LabelToPrint[0] = LabelToPrint[0].Replace(line, "");
                            LabelToPrint[0] = LabelToPrint[0].Remove(0, 82 + i);
                            break;
                        }
                    }
                }

                yPos = topMargin + (linesCount * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());

                if (newLabel)
                {
                    linesCount += 2;
                }
                else
                {
                    linesCount += 1;
                }
            }
                //line = LabelToPrint[0];
                //LabelToPrint.RemoveAt(0);
            /*
            yPos = topMargin + (linesCount * printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());

            if (line.Length < 95)
            {
                linesCount += 2;
            }
            else
            {
                linesCount += 1;
            }
                //linesCount += (line.Count() / 45) + 2;
            */

            if (LabelToPrint.Count != 0)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        public void Printing()
        {

            printFont = new Font("Arial", 10);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PD_PrintPage);
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();

            /*
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }
            */
        }
    }
}
