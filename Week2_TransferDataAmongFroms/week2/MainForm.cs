using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.setName(txtBoxName1.Text);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(txtBoxName2.Text);
            frm.ShowDialog();
        }
    }
}
