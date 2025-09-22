using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Circles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics(); //allows drawing on the form
            Pen pn = new Pen(Color.DarkGreen, 3);
            g.DrawEllipse(pn, e.X, e.Y, 20, 20);
        }

        private void btnShowConstant_Click(object sender, EventArgs e)
        {
            ConstantCirclesForm someForm2;
            someForm2 = new ConstantCirclesForm();
            someForm2.Show();
        }
    }
}
