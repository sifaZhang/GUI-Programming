using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button5.Click += new System.EventHandler(this.button_Click);
            this.button6.Click += new System.EventHandler(this.button_Click);
            this.button7.Click += new System.EventHandler(this.button_Click);
            this.button8.Click += new System.EventHandler(this.button_Click);
            this.button9.Click += new System.EventHandler(this.button_Click);

            this.button15.Click += new System.EventHandler(this.button_Click);
            this.button15.Click += new System.EventHandler(this.button1_Click);
            this.button15.Click += new System.EventHandler(this.button2_Click);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender as Button;
            label1.Text += btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1", "1", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2", "2", MessageBoxButtons.OK);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
