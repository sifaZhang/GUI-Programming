// this file is used to manage event registrations in the Kaioordinate application.
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

namespace Kaioordinate
{
    public partial class registrationFrm : Form
    {
        // declaration of DataModule and CurrencyManagers
        private DataModule DM;
        private CurrencyManager cmEvent;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmRegistration;

        /// <summary>
        /// constructor for the registrationFrm class.
        /// </summary>
        /// <param name="dM"></param>
        public registrationFrm(DataModule dM)
        {
            InitializeComponent();

            DM = dM;
            BindControls();
        }

        /// <summary>
        /// binds the controls to the data source.
        /// </summary>
        private void BindControls()
        {
            // Set the data source for the DataGridViews and their CurrencyManagers
            dgEvent.DataSource = DM.dsKaioordinate;
            dgEvent.DataMember = "Event";
            dgEvent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgEvent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Event"];

            // Set the data source for the Whanau and Registration DataGridViews
            dgWhanau.DataSource = DM.dsKaioordinate;
            dgWhanau.DataMember = "Whanau";
            dgWhanau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgWhanau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgWhanau.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Whanau"];

            // Set the data source for the Registration DataGridView
            dgRegistration.DataSource = DM.dsKaioordinate;
            dgRegistration.DataMember = "EventRegister";
            dgRegistration.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgRegistration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgRegistration.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmRegistration = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EventRegister"];
        }

        /// <summary>
        /// form load event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrationFrm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        /// <summary>
        /// handles the click event for the Return button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// handles the click event for the Add button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow eventRow = DM.eventTable.Rows[cmEvent.Position];
            DataRow whanauRow = DM.whanauTable.Rows[cmWhanau.Position];

            int eventID = Convert.ToInt32(eventRow["EventID"]);
            int whanauID = Convert.ToInt32(whanauRow["WhanauID"]);

            // Check if the whanau is already registered for the event
            DataRow[] selectRow = DM.registrationTable.Select("EventID = " + eventID + " AND WhanauID = " + whanauID);
            if (selectRow.Length > 0)
            {
                MessageBox.Show("Whanau can only be registered to an event once.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create a new registration entry
                DataRow newRegistration = DM.registrationTable.NewRow();
                newRegistration["EventID"] = eventID;
                newRegistration["WhanauID"] = whanauID;
                newRegistration["KaiPreparation"] = ckboxPreparation.Checked;
                DM.registrationTable.Rows.Add(newRegistration);
                DM.UpdateRegistration();

                // Show success message
                MessageBox.Show("Entry added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// handles the click event for the Update button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteow = DM.registrationTable.Rows[cmRegistration.Position];

            // Check if the user confirms the deletion
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                deleteow.Delete();
                DM.UpdateRegistration();
            }
        }
    }
}
