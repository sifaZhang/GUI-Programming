using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {

        }

        private void btnOnMove_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnClickMe.Left = btnReset.Left;
            btnOnMove.Left = btnReset.Left;
        }

        private void btnClickMe_MouseEnter(object sender, EventArgs e)
        {
            btnClickMe.Left += 20;
        }

        private void btnOnMove_MouseMove(object sender, MouseEventArgs e)
        {
            btnOnMove.Left += 20;
        }

        private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < (char)48) || (e.KeyChar > (char)57))
            {
                e.Handled = true;
            }
        }

        private void txtNumPlus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)8)
                && (e.KeyChar != (char)46)
                    && (e.KeyChar < (char)48 || e.KeyChar > (char)57)
                && (e.KeyChar != (char)13))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (char)13)
                {
                    lblResult.Text = txtNumPlus.Text;
                    e.Handled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
