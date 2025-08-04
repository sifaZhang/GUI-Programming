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
    public partial class MianFrm : Form
    {
        public MianFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        private void iconButton_report_Click(object sender, EventArgs e)
        {

        }

        private void iconButton_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit？", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconButton_Kai_Click(object sender, EventArgs e)
        {
            kaiManagement kaiManagement = new kaiManagement();
            kaiManagement.ShowDialog();
        }
    }
}
