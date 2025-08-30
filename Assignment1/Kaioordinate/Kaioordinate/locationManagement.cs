// this file is used to manage location registrations in the Kaioordinate application.
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
    public partial class locationFrm : Form
    {
        //define an enum to represent the action type for events
        enum EventAction
        {
            none,
            Add,
            Update
        }

        // Declare private fields for the DataModule, CurrencyManager, and EventAction
        private DataModule DM;
        private CurrencyManager currencyManager;
        private EventAction eventAction = EventAction.none;

        /// <summary>
        /// constructor for the location management form.
        /// </summary>
        /// <param name="dm"></param>
        public locationFrm(DataModule dm)
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
            try
            {
                // Bind the text boxes to the data source
                txtboxLocationID.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationID");
                txtboxLocationNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationName");
                txboxAddressShow.DataBindings.Add("Text", DM.dsKaioordinate, "Location.Address");

                // Bind the list box to the data source
                lstboxLocationName.DataSource = DM.dsKaioordinate;
                lstboxLocationName.DisplayMember = "Location.LocationName";
                lstboxLocationName.ValueMember = "Location.LocationID";

                // Initialize the CurrencyManager for the Location table
                currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Location"];
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid data format: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Null reference: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)  // 兜底
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// handles the load event for the location management form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locationFrm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        /// <summary>
        /// handles the click event for the return button, closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// handles the click event for the cancel button, resetting the form state and controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reset the form state and controls
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;

            // show the list box and hide the panel
            lstboxLocationName.Show();
            panel1.Visible = false;

            // Reset eventAction to none
            eventAction = EventAction.none;
        }

        /// <summary>
        /// handles the click event for the update button, allowing the user to update a location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Set the eventAction to Update to indicate that the user is updating a location
            eventAction = EventAction.Update;

            // Disable buttons to prevent further actions while updating
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            lstboxLocationName.Hide();
            panel1.Visible = true;

            // Populate the text boxes with the current values for editing
            txtboxLocationName.Text = txtboxLocationNameShow.Text;
            txtboxAddress.Text = txboxAddressShow.Text;
        }

        /// <summary>
        /// handles the click event for the up button, moving the position in the CurrencyManager up by one if possible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            // Move the position in the CurrencyManager up by one if it is not already at the first position
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }


        /// <summary>
        /// handles the click event for the down button, moving the position in the CurrencyManager down by one if possible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            // Move the position in the CurrencyManager down by one if it is not already at the last position
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// handles the click event for the add button, allowing the user to add a new location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Set the eventAction to Add to indicate that the user is adding a new location
            eventAction = EventAction.Add;

            // Disable buttons to prevent further actions while adding
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;

            // Hide the list box and show the panel for adding a new location
            lstboxLocationName.Hide();
            panel1.Visible = true;

            // Clear the text boxes for the new location
            txtboxLocationName.Text = "";
            txtboxLocationID.Text = "";
            txtboxAddress.Text = "";
        }

        /// <summary>
        /// handles the click event for the delete button, allowing the user to delete a location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the CurrencyManager is at the first position, if so, disable the delete button
                DataRow deleteow = DM.locationTable.Rows[currencyManager.Position];
                DataRow[] dsRow = DM.eventTable.Select("LocationID = " + txtboxLocationID.Text);
                if (dsRow.Length != 0)
                {
                    // If there are events associated with the location, show an error message
                    MessageBox.Show("You may only delete locations that have no events", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // If there are no events associated with the location, prompt the user for confirmation before deleting
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        deleteow.Delete();
                        DM.UpdateLocation();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid data format: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Data position error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Null reference: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)  // 兜底
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// handles the click event for the save button, saving the changes made to the location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the eventAction is none, if so, show an error message
                if (eventAction == EventAction.Add)
                {
                    DataRow newRow = DM.locationTable.NewRow();
                    if (txtboxLocationName.Text == ""
                        || txtboxAddress.Text == "")
                    {
                        // If the text boxes are empty, show an error message
                        MessageBox.Show("You must type in all datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtboxLocationName.Text.Length > 255 || txtboxAddress.Text.Length > 255)
                    {
                        MessageBox.Show("The maximal length of Address and Name is 255 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // If the text boxes are not empty, add a new row to the location table
                        newRow["LocationName"] = txtboxLocationName.Text;
                        newRow["Address"] = txtboxAddress.Text;

                        DM.locationTable.Rows.Add(newRow);
                        MessageBox.Show("Location added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DM.UpdateLocation();
                    }
                }
                else if (eventAction == EventAction.Update)
                {
                    DataRow updateRow = DM.locationTable.Rows[currencyManager.Position];
                    if (txtboxLocationName.Text == ""
                        || txtboxAddress.Text == "")
                    {
                        // If the text boxes are empty, show an error message
                        MessageBox.Show("You must type in all datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtboxLocationName.Text.Length > 255 || txtboxAddress.Text.Length > 255)
                    {
                        MessageBox.Show("The maximal length of Address and Name is 255 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // If the text boxes are not empty, update the current row in the location table
                        updateRow["LocationName"] = txtboxLocationName.Text;
                        updateRow["Address"] = txtboxAddress.Text;

                        currencyManager.EndCurrentEdit();
                        DM.UpdateLocation();
                        MessageBox.Show("Location updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Select update or add firstly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid data format: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Data position error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Null reference: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)  // 兜底
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
