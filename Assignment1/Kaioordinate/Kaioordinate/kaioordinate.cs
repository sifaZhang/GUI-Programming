using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kaioordinate
{
    public partial class MianFrm : Form
    {
        private DataModule DM;
        private eventManagement eventManagementFrm;
        private kaiManagement kaiManagementFrm;
        private whānauManagement whanauManagementFrm;
        private locationManagement locationManagementFrm;
        private registration registrationFrm;

        public MianFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void iconButton_report_Click(object sender, EventArgs e)
        {
            reportPreview reportPreview = new reportPreview();
            reportPreview.ShowDialog();
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
            kaiManagement kaiManagement = new kaiManagement(DM);
            kaiManagement.ShowDialog();
        }

        private void iconButton_event_Click(object sender, EventArgs e)
        {
            if (eventManagementFrm == null)
            {
                eventManagementFrm = new eventManagement(DM);
            }
            eventManagementFrm.ShowDialog();
        }

        private void iconButton_whanau_Click(object sender, EventArgs e)
        {
            whānauManagement whanauManagement = new whānauManagement();
            whanauManagement.ShowDialog();
        }

        private void iconButton_location_Click(object sender, EventArgs e)
        {
            locationManagement locationManagement = new locationManagement();
            locationManagement.ShowDialog();
        }

        private void iconButton_registration_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            registration.ShowDialog();
        }
    }
}
