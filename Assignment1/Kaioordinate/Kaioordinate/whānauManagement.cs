// this file is used to manage whānau (family) information in the Kaioordinate application.
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
    public partial class whānauManagementFrm : Form
    {
        // This enum is used to track the action being performed (none, Add, Update)
        enum EventAction
        {
            none,
            Add,
            Update
        }

        // Declaration of DataModule and CurrencyManager
        private DataModule DM;
        private CurrencyManager currencyManager;
        private EventAction eventAction = EventAction.none;

        /// <summary>
        /// constructor for the whānauManagement class.
        /// </summary>
        /// <param name="dm"></param>
        public whānauManagementFrm(DataModule dm)
        {
            InitializeComponent();

            DM = dm;
            BindControls();
        }

        /// <summary>
        /// binds the controls to the data source.
        /// </summary>
        public void BindControls()
        {
            // Bind text boxes to the Whanau data source
            txtboxWhanauID.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.WhanauID");
            txtboxFirstNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.FirstName");
            txtboxLastNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.LastName");
            txtboxPhoneShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Phone");
            txtboxEmailShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Email");
            txtboxAddressShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Address");

            // Check if the FullName column exists, if not, create it
            if (!DM.dsKaioordinate.Tables["Whanau"].Columns.Contains("FullName"))
            {
                DM.dsKaioordinate.Tables["Whanau"].Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
            }

            // Set the data source for the ListBox
            lstboxWhanauName.DataSource = DM.dsKaioordinate;
            lstboxWhanauName.DisplayMember = "Whanau.FullName";
            lstboxWhanauName.ValueMember = "Whanau.WhanauID";

            // Initialize the CurrencyManager for the Whanau table
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Whanau"];
        }

        /// <summary>
        /// handles the click event for the Update button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Set the event action to Update
            eventAction = EventAction.Update;

            // Disable buttons and show the panel for updating
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;

            // Hide the ListBox and show the panel for editing
            lstboxWhanauName.Hide();
            panel1.Visible = true;

            // Populate the text boxes with the current values
            txtboxFirstName.Text = txtboxFirstNameShow.Text;
            txtboxLastName.Text = txtboxLastNameShow.Text;
            txtboxPhone.Text = txtboxPhoneShow.Text;
            txtboxEmail.Text = txtboxEmailShow.Text;
            txtboxAddress.Text = txtboxAddressShow.Text;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        /// <summary>
        /// handles the click event for the return button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// form load event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void whānauManagementFrm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        /// <summary>
        /// handles the click event for the cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Enable the buttons
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;

            // Hide the panel and show the ListBox
            lstboxWhanauName.Show();
            panel1.Visible = false;

            // Reset the text boxes
            eventAction = EventAction.none;
        }

        /// <summary>
        /// handles the click event for the up button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            // Move to the previous record in the CurrencyManager
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// handles the click event for the down button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            // Move to the next record in the CurrencyManager
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// handles the click event for the add button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Set the event action to Add
            eventAction = EventAction.Add;

            // Disable buttons and show the panel for adding a new record
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;

            // hide the ListBox and show the panel for editing
            lstboxWhanauName.Hide();
            panel1.Visible = true;

            // Clear the text boxes for new entry
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtboxPhone.Text = "";
            txtboxEmail.Text = "";
            txtboxAddress.Text = "";
        }

        /// <summary>
        /// handles the click event for the delete button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the user has selected a record to delete
            DataRow deleteow = DM.whanauTable.Rows[currencyManager.Position];
            DataRow[] dsRow = DM.registrationTable.Select("WhanauID = " + txtboxWhanauID.Text);
            if (dsRow.Length != 0)
            {
                // If there are registrations associated with the whanau, show an error message
                MessageBox.Show("You may only delete records that have no registrations", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                // If there are no registrations, confirm deletion
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    deleteow.Delete();
                    DM.UpdateWhanau();
                }
            }
        }

        /// <summary>
        /// handles the click event for the save button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if the event action is Add or Update
            if (eventAction == EventAction.Add)
            {
                // Create a new row in the whanau table
                DataRow newRow = DM.whanauTable.NewRow();
                if (txtboxFirstName.Text == ""
                    || txtboxLastName.Text == ""
                    || txtboxPhone.Text == ""
                    || txtboxEmail.Text == ""
                    || txtboxAddress.Text == "")
                {
                    // Show an error message if any of the fields are empty
                    MessageBox.Show("You must type in all datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!txtboxEmail.Text.Contains('@'))
                {
                    // Show an error message if the email is not valid
                    MessageBox.Show("Email is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // If all fields are valid, set the values and add the new row to the table
                    newRow["FirstName"] = txtboxFirstName.Text;
                    newRow["LastName"] = txtboxLastName.Text;
                    newRow["Phone"] = txtboxPhone.Text;
                    newRow["Email"] = txtboxEmail.Text;
                    newRow["Address"] = txtboxAddress.Text;

                    // Add the new row to the whanau table
                    DM.whanauTable.Rows.Add(newRow);
                    DM.UpdateWhanau();

                    // End the current edit in the CurrencyManager
                    MessageBox.Show("Whanau added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (eventAction == EventAction.Update)
            {
                DataRow updateRow = DM.whanauTable.Rows[currencyManager.Position];
                if (txtboxFirstName.Text == ""
                    || txtboxLastName.Text == ""
                    || txtboxPhone.Text == ""
                    || txtboxEmail.Text == ""
                    || txtboxAddress.Text == "" )
                {
                    // Show an error message if any of the fields are empty
                    MessageBox.Show("You must type in all datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!txtboxEmail.Text.Contains('@'))
                {
                    // Show an error message if the email is not valid
                    MessageBox.Show("Email is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // If all fields are valid, set the values and update the row
                    updateRow["FirstName"] = txtboxFirstName.Text;
                    updateRow["LastName"] = txtboxLastName.Text;
                    updateRow["Phone"] = txtboxPhone.Text;
                    updateRow["Email"] = txtboxEmail.Text;
                    updateRow["Address"] = txtboxAddress.Text;

                    // End the current edit in the CurrencyManager and update the whanau table
                    currencyManager.EndCurrentEdit();
                    DM.UpdateWhanau();

                    // Show a success message
                    MessageBox.Show("Whanau updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
