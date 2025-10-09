using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Temp\\student.txt");
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog(this);
            //MessageBox.Show(openFileDialog1.FileName);

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void footsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog(this) == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Option 1");
        }
    }
}
