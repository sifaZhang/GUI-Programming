using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font font = new Font("Arial", 12);

            int lineHeight = font.Height;
            int linesSoFar = 0;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            foreach (string txt in txtPrint.Lines)
            {
                g.DrawString(txt, font, Brushes.Black, leftMargin, 
                    topMargin + linesSoFar * lineHeight);
                linesSoFar++;
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.PrintPreviewControl.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPreview myPreview = new MyPreview();
            myPreview.printPreviewControl1.Document = printDocument1;
            myPreview.printPreviewControl1.Zoom = 2;
            myPreview.ShowDialog();
        }
    }
}
