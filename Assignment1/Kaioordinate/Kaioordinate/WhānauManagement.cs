using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate
{
    public partial class WhānauManagement : Form
    {
        public WhānauManagement()
        {
            InitializeComponent();
        }

        private void iconButton_update_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void iconButton_reture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WhānauManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
