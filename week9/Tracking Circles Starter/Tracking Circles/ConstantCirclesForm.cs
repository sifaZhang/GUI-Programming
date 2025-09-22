using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Circles
{
    public partial class ConstantCirclesForm : Form
    {

        private ArrayList allPoints;
        private Point[] CirclePoints;

        public ConstantCirclesForm()
        {
            InitializeComponent();
        }

        private void ConstantCirclesForm_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void ConstantCirclesForm_Load(object sender, EventArgs e)
        {
            allPoints = new ArrayList();
        }

        private void ConstantCirclesForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics(); //allows drawing on the form
            Pen pn = new Pen(Color.Orange, 2);

            Point[] CirclePoints = (Point[])allPoints.ToArray(typeof(Point));
            foreach (Point pt in CirclePoints)
            {
                g.DrawEllipse(pn, pt.X, pt.Y, 20, 20);

            }
        }

        private void btnShowForm3_Click(object sender, EventArgs e)
        {
            PersistentCirclesForm someForm2;
            someForm2 = new PersistentCirclesForm();
            someForm2.Show();
        }
    }
}
