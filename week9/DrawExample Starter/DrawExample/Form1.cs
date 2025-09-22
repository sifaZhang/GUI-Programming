using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawExample
{
    public partial class Form1 : Form
    {

        private bool willShowNothing, willShowLine, willShowElipses, willShowRectangles;
        bool showTempEllipse = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void pnlGDI_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //graphics object for the pnlGDI control

            //draw a line
            Pen pn = new Pen(Color.Red, 2);
            Point pt1 = new Point(30, 30);
            Point pt2 = new Point(110, 100);
            g.DrawLine(pn, pt1, pt2);

            //draw a filled rectangle
            Rectangle rect = new Rectangle(50, 150, 200, 150);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow,
                                             LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);

            //draw some text
            Font fnt = new Font("Arial", 16);
            g.DrawString("Text drawn using GDI+", fnt, new SolidBrush(Color.DarkCyan), 14, 10);

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            willShowNothing = false;
            willShowLine = !willShowLine;
            this.Invalidate(); //force the form to be re painted
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            willShowNothing = false;
            willShowElipses = !willShowElipses;
            this.Invalidate(); //force the form to be re painted
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (willShowNothing)
            {
                return;
            }
            Graphics g = e.Graphics;
            if (willShowLine)
            {
                Pen pn = new Pen(Color.Blue, 4);
                Point pt1 = new Point(30, 80);
                Point pt2 = new Point(110, 150);
                g.DrawLine(pn, pt1, pt2);
            }
            if (willShowElipses)
            {
                Rectangle rect = new Rectangle(50, 100, 200, 100);
                Pen pn = new Pen(Color.Maroon, 3);
                g.DrawEllipse(pn, rect);

                Rectangle rect1 = new Rectangle(50, 210, 80, 80);
                Brush brsh = new SolidBrush(Color.Yellow);
                g.FillEllipse(brsh, rect1);
            }
            if (willShowRectangles)
            {
                Rectangle rect2 = new Rectangle(50, 100, 200, 100);
                Pen pn = new Pen(Color.Chocolate, 2);
                g.DrawRectangle(pn, rect2);

                Rectangle rect3 = new Rectangle(160, 210, 120, 50);
                Brush brsh1 = new SolidBrush(Color.Aqua);
                g.FillRectangle(brsh1, rect3);
            }

            //draw some text
            Font fnt = new Font("Times New Roman", 20, FontStyle.Strikeout | FontStyle.Bold);
            g.DrawString("This text is bold with strikeout",
                         fnt, new SolidBrush(Color.DarkCyan), 14, 10);

        }

        private void btnRectangles_Click(object sender, EventArgs e)
        {
            willShowNothing = false;
            willShowRectangles = !willShowRectangles;
            this.Invalidate(); //force the form to be re painted
        }

        private void btnDrawOnOff_Click(object sender, EventArgs e)
        {
            willShowNothing = !willShowNothing;
            this.Invalidate(); //force the form to be re painted
        }

        private void btnDrawTemp(object sender, EventArgs e)
        {
            // Toggle whether to draw the ellipse or not
            showTempEllipse = !showTempEllipse;

            Graphics g = this.CreateGraphics(); //allows drawing on the form
            try
            {
                if (showTempEllipse)
                {
                    // Draw the ellipse
                    g.FillEllipse(Brushes.DarkBlue, this.ClientRectangle);
                }
                else
                {
                    // Erase the previously drawn ellipse
                    g.FillEllipse(SystemBrushes.Control, this.ClientRectangle);
                }
            }
            finally
            {
                g.Dispose(); //Need to dispose of graphics objects if
                             //we are responsible for creating them
            }
        }
    }
}
