// this file is used to manage events in the Kaioordinate application.
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
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;

namespace Kaioordinate
{
    public partial class eventManagementFrm : Form
    {
        // define an enum to represent the action being performed
        enum EventAction
        {
            none,
            Add,
            Update
        }

        // private fields to hold the data module and currency manager
        private DataModule DM;
        private CurrencyManager currencyManager;
        private EventAction eventAction = EventAction.none;

        /// <summary>
        /// constructor for the eventManagement form
        /// </summary>
        /// <param name="dm"></param>
        public eventManagementFrm(DataModule dm)
        {
            InitializeComponent();

            DM = dm;
            BindControls();
        }

        /// <summary>
        /// binds the controls to the data source
        /// </summary>
        public void BindControls()
        {
            // Bind the text boxes to the event data
            txtboxEventID.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventID");
            txtboxEventNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventName");
            txtboxLocation.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.LocationID");

            // Bind the date control with a custom format
            System.Windows.Forms.Binding binding = new System.Windows.Forms.Binding("Text", DM.dsKaioordinate, "EVENT.EventDate");
            binding.Format += (s, e) =>
            {
                if (e.DesiredType == typeof(string) && e.Value != DBNull.Value)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("yyyy-MM-dd"); // only the date part
                }
            };
            txtboxDate.DataBindings.Add(binding);

            // Bind the date time picker to the event date
            lstboxEventName.DataSource = DM.dsKaioordinate;
            lstboxEventName.DisplayMember = "EVENT.EventName";
            lstboxEventName.ValueMember = "EVENT.EventName";

            // Bind the list box to the event name
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT"];
        }

        /// <summary>
        /// handles the return button click event to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// handles the cancel button click event to reset the form state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reset the action to none and enable all buttons
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;
            lstboxEventName.Show();
            panel1.Visible = false;

            // Reset the text boxes
            eventAction = EventAction.none; 
        }

        /// <summary>
        /// handles the update button click event to prepare for updating an event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Set the action to update and disable other buttons
            eventAction = EventAction.Update;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            lstboxEventName.Hide();
            panel1.Visible = true;

            // Populate the text boxes with the current event data
            txtboxEventName.Text = txtboxEventNameShow.Text;
            datepickerDate.Text = txtboxDate.Text;
            cmboxLocation.DisplayMember = "LocationName";
            cmboxLocation.ValueMember = "LocationID";
            cmboxLocation.DataSource = DM.dsKaioordinate.Tables["location"];

            // Set the selected value for the location combo box
            cmboxLocation.SelectedValue = txtboxLocation.Text;
        }

        /// <summary>
        /// load event handler for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventManagementFrm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        /// <summary>
        /// handles the up button click event to navigate to the previous event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            // Move to the previous event if not at the first position
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// handles the down button click event to navigate to the next event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            // Move to the next event if not at the last position
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// handles the add button click event to prepare for adding a new event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Set the action to add a new event
            eventAction = EventAction.Add;

            // Disable navigation and action buttons
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            lstboxEventName.Hide();
            panel1.Visible = true;

            // Clear the text boxes for new event input
            txtboxEventName.Text = "";
            datepickerDate.Text = "";
            cmboxLocation.DisplayMember = "LocationName";
            cmboxLocation.ValueMember = "LocationID";
            cmboxLocation.DataSource = DM.dsKaioordinate.Tables["location"];
        }

        /// <summary>
        /// handles the save button click event to save the new or updated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check the action type and perform add or update accordingly
            if (eventAction == EventAction.Add)
            {
                DataRow newEvent = DM.eventTable.NewRow();
                if ((txtboxEventName.Text == "") 
                    || (datepickerDate.Text == "") 
                    || cmboxLocation.Text == "")
                {
                    // Show an error message if any field is empty
                    MessageBox.Show("You must type in all datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Add the new event with the provided details
                    newEvent["EventName"] = txtboxEventName.Text;
                    newEvent["LocationID"] = Convert.ToInt32(cmboxLocation.SelectedValue);
                    newEvent["EventDate"] = datepickerDate.Value.Date;

                    DM.eventTable.Rows.Add(newEvent);
                    MessageBox.Show("Event added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DM.UpdateEvent();
                }
            }
            else if (eventAction == EventAction.Update)
            {
                DataRow updateEvent = DM.eventTable.Rows[currencyManager.Position];
                if ((txtboxEventName.Text == "") 
                    || (datepickerDate.Text == "") 
                    || cmboxLocation.Text == "")
                {
                    // Show an error message if any field is empty
                    MessageBox.Show("You must type in all datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Update the existing event with the new details
                    updateEvent["EventName"] = txtboxEventName.Text;
                    updateEvent["LocationID"] = Convert.ToInt32(cmboxLocation.SelectedValue);
                    updateEvent["EventDate"] = datepickerDate.Value.Date;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateEvent();
                    MessageBox.Show("Event updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select update or add firstly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// handles the delete button click event to remove the current event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the current event can be deleted
            DataRow deleteEventRow = DM.eventTable.Rows[currencyManager.Position];
            DataRow[] dsRow = DM.kaiTable.Select("EventID = " + txtboxEventID.Text);
            DataRow[] dsRegisterRow = DM.registrationTable.Select("EventID = " + txtboxEventID.Text);
            if (dsRow.Length != 0 && dsRegisterRow.Length != 0)
            {
                // Show an error message if the event has associated kai or registrations
                MessageBox.Show("You may only delete an event that has no kai and register", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Confirm deletion and remove the event
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    DM.UpdateEvent();
                }
            }
        }
    }
}
