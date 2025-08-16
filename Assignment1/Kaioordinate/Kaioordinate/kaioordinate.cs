// this file is entry point for the Kaioordinate application.
// Author: Sifa Zhang
// Date: 08/11/2025

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
        private eventManagementFrm eventManagementFrm;
        private kaiManagementFrm kaiManagementFrm;
        private whānauManagementFrm whanauManagementFrm;
        private locationFrm locationManagementFrm;
        private registrationFrm registrationFrm;
        private reportPreview reportPreviewFrm;
        private calenderFrm calenderFrm;

        /// <summary>
        /// constructor for the main form of the Kaioordinate application.
        /// </summary>
        public MianFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for the report button, displaying a report preview dialog.
        /// </summary>
        /// <remarks>If the report preview form has not been initialized, it is created before being
        /// displayed. The dialog is shown modally, blocking interaction with other windows until it is
        /// closed.</remarks>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">The event data associated with the click action.</param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (reportPreviewFrm == null)
            {
                reportPreviewFrm = new reportPreview(DM);
            }
            reportPreviewFrm.ShowDialog();
        }

        /// <summary>
        /// handles the click event for the exit button. Prompts the user for confirmation before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit？", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// handles the click event for the kai management button. If the kai management form has not been
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKai_Click(object sender, EventArgs e)
        {
            if (kaiManagementFrm == null)
            {
                kaiManagementFrm = new kaiManagementFrm(DM);
            }
            kaiManagementFrm.ShowDialog();
        }

        /// <summary>
        /// handles the click event for the event management button. If the event management form has not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvent_Click(object sender, EventArgs e)
        {
            if (eventManagementFrm == null)
            {
                eventManagementFrm = new eventManagementFrm(DM);
            }
            eventManagementFrm.ShowDialog();
        }

        /// <summary>
        /// handles the click event for the whānau management button. If the whānau management form has not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWhanau_Click(object sender, EventArgs e)
        {
            if (whanauManagementFrm == null)
            {
                whanauManagementFrm = new whānauManagementFrm(DM);
            }
            whanauManagementFrm.ShowDialog();
        }

        /// <summary>
        /// handles the click event for the location management button. If the location management form has not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (locationManagementFrm == null)
            {
                locationManagementFrm = new locationFrm(DM);
            }
            locationManagementFrm.ShowDialog();
        }

        /// <summary>
        /// handles the click event for the registration button. If the registration form has not been
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (registrationFrm == null)
            {
                registrationFrm = new registrationFrm(DM);
            }
            registrationFrm.ShowDialog();
        }

        /// <summary>
        /// handles the click event for the calendar button. If the calendar form has not been initialized,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalender_Click(object sender, EventArgs e)
        {
            if (calenderFrm == null)
            {
                calenderFrm = new calenderFrm(DM);
            }
            calenderFrm.ShowDialog();
        }

        /// <summary>
        /// Handles the load event of the main form. Creates a new instance of the <see cref="DataModule"/> class
        /// </summary>
        /// <remarks>This method initializes the <see cref="DataModule"/> instance when the form is
        /// loaded.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> object that contains the event data.</param>
        private void MianFrm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }
    }
}
