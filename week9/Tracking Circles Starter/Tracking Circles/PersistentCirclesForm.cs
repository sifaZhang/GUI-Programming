using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Circles
{
    public partial class PersistentCirclesForm : Form
    {

        private ArrayList allColorPoints;
        private Color penColor = Color.Blue;

        public PersistentCirclesForm()
        {
            InitializeComponent();
        }

        private void PersistentCirclesForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics(); //allows drawing on the form
                ColorPoint cp = new ColorPoint(e.X, e.Y, penColor);
                allColorPoints.Add(cp);
                cp.Draw(g);
            }
        }

        private void PersistentCirclesForm_Load(object sender, EventArgs e)
        {
            allColorPoints = new ArrayList();
        }

        private void PersistentCirclesForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics(); //allows drawing on the form

            ColorPoint[] CirclePoints = (ColorPoint[])allColorPoints.ToArray(typeof(ColorPoint));
            foreach (ColorPoint cp in CirclePoints)
            {
                cp.Draw(g);
            }
        }

        private void PersistentCirclesForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    penColor = colorDialog1.Color;
                }
            }
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            allColorPoints.Clear();
            this.Invalidate();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                ColorPoint[] CirclePoints = (ColorPoint[])allColorPoints.ToArray(typeof(ColorPoint));
                foreach (ColorPoint cp in CirclePoints)
                {
                    sb.Append(cp.ToString());
                }
                string temp = sb.ToString();

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(sb);
                sw.Close();
            }

        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                allColorPoints.Clear(); //should really ask if they want to save first
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string theDots = sr.ReadToEnd();
                sr.Close();
                string[] theLines = theDots.Split('#');
                foreach (string stringDot in theLines)
                {
                    if (stringDot != "") allColorPoints.Add(new ColorPoint(stringDot));
                }
                this.Invalidate();
            }

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
