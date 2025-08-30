// this file is used to manage kai (food) records in the Kaioordinate application.
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
    public partial class kaiManagementFrm : Form
    {
        // add a class to save event names for combox
        public class EventItem
        {
            public string EventName { get; set; }
            public int? EventID { get; set; } //  nullable int
        }

        // define an enum to represent the action being performed on the kai records
        enum EventAction
        {
            none,
            Add,
            Update
        }

        // define private fields for the data module, currency manager, and current event action
        private DataModule DM;
        private CurrencyManager currencyManager;
        private EventAction eventAction = EventAction.none;
        private List<EventItem> eventList = new List<EventItem>();

        /// <summary>
        /// constructor for the kaiManagement form.
        /// </summary>
        /// <param name="dm"></param>
        public kaiManagementFrm(DataModule dm)
        {
            InitializeComponent();

            DM = dm;
            BindControls();
        }

        /// <summary>
        /// binds the controls on the form to the data source.
        /// </summary>
        public void BindControls()
        {
            try
            {
                // bind the text boxes to the corresponding fields in the data source
                txtboxKaiID.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiID");
                txtboxKaiNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiName");
                txtboxPreparation.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationRequired");
                txtboxTme.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationMinutes");
                txtboxQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.ServeQuantity");
                txtboxEvent.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.EventName");

                // set the data source for the list box to the kai records in the data source
                lstboxKaiName.DataSource = DM.dsKaioordinate;
                lstboxKaiName.DisplayMember = "Kai.KaiName";
                lstboxKaiName.ValueMember = "Kai.KaiName";

                // create a currency manager to manage the current position in the kai records
                currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Kai"];
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
        /// handles the click event for the return button, closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// form load event handler, sets the background color of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kaiManagementFrm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        /// <summary>
        /// update eventList, add a default null to the first
        /// </summary>
        private void UpdateEventitems()
        {
            eventList.Clear();

            // add default item
            eventList.Add(new EventItem { EventName = "Please select", EventID = null });

            // add real data
            foreach (DataRow row in DM.dsKaioordinate.Tables["Event"].Rows)
            {
                eventList.Add(new EventItem
                {
                    EventName = row["EventName"].ToString(),
                    EventID = Convert.ToInt32(row["EventID"])
                });
            }
        }

        /// <summary>
        /// handles the click event for the update button, allowing the user to update a kai record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // define the action as Update
            eventAction = EventAction.Update;

            // disable the buttons and controls that should not be used during the update process
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            lstboxKaiName.Hide();
            panel1.Visible = true;

            // set the data source for the combo box to the event records in the data source
            UpdateEventitems();
            cmboxEvent.DisplayMember = "EventName";
            cmboxEvent.ValueMember = "EventID";
            cmboxEvent.DataSource = eventList;
            // select current index according to the event name
            int idx = cmboxEvent.FindStringExact(txtboxEvent.Text);
            if (idx >= 0)
            {
                cmboxEvent.SelectedIndex = idx;
            }

            // set the text boxes to the values from the data source
            txtboxKaiName.Text = txtboxKaiNameShow.Text;
            ckboxPreparation.Checked = txtboxPreparation.Text == "True";

            // set the numeric up-down controls to the values from the text boxes, or 0 if the text boxes are empty
            numericQuantity.Value = string.IsNullOrEmpty(txtboxQuantity.Text) ? 0 : Convert.ToDecimal(txtboxQuantity.Text);
            numericTime.Value = string.IsNullOrEmpty(txtboxTme.Text) ? 0 : Convert.ToDecimal(txtboxTme.Text);
        }

        /// <summary>
        /// handles the click event for the cancel button, resetting the form to its initial state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // reset the form to its initial state by enabling the buttons and controls
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;
            lstboxKaiName.Show();
            panel1.Visible = false;

            // clear the text boxes and numeric up-down controls
            eventAction = EventAction.none;
        }

        /// <summary>
        /// handles the click event for the up button, moving the current position in the currency manager up by one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            // if the current position is greater than 0, move up one position in the currency manager
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// handles the click event for the down button, moving the current position in the currency manager down by one.
        /// </summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            // if the current position is less than the total count minus one, move down one position in the currency manager
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// handles the click event for the add button, allowing the user to add a new kai record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // define the action as Add
            eventAction = EventAction.Add;

            // disable the buttons and controls that should not be used during the add process
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            lstboxKaiName.Hide();
            panel1.Visible = true;

            // set the data source for the combo box to the event records in the data source
            UpdateEventitems();
            cmboxEvent.DisplayMember = "EventName";
            cmboxEvent.ValueMember = "EventID";
            cmboxEvent.DataSource = eventList;
            //default to null
            cmboxEvent.SelectedIndex = 0;

            // clear the text boxes and numeric up-down controls
            txtboxKaiName.Text = "";
            numericQuantity.Value = 0;
            numericTime.Value = 0;
        }

        /// <summary>
        /// handles the click event for the save button, saving the changes made to the kai record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // if the event action is none, do nothing
                if (eventAction == EventAction.Add)
                {
                    DataRow newRow = DM.kaiTable.NewRow();
                    if (txtboxKaiName.Text == ""
                        || cmboxEvent.Text == ""
                        || numericQuantity.Text == ""
                        || numericTime.Text == ""
                        || Convert.ToInt32(numericQuantity.Text) < 0
                        || Convert.ToInt32(numericTime.Text) < 0)
                    {
                        // if any of the required fields are empty or invalid, show an error message
                        MessageBox.Show("You must type in all datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtboxKaiName.Text.Length > 255)
                    {
                        MessageBox.Show("The maximal length of Kai name is 255 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // if all fields are valid, set the values for the new row and add it to the kai table
                        if (cmboxEvent.SelectedValue == null)
                        {
                            newRow["EventID"] = DBNull.Value;
                        }
                        else
                        {
                            newRow["EventID"] = Convert.ToInt32(cmboxEvent.SelectedValue);
                        }

                        newRow["KaiName"] = txtboxKaiName.Text;
                        newRow["PreparationRequired"] = ckboxPreparation.Checked;
                        newRow["PreparationMinutes"] = numericTime.Value;
                        newRow["ServeQuantity"] = numericQuantity.Value;

                        DM.kaiTable.Rows.Add(newRow);
                        MessageBox.Show("Kai added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DM.UpdateKai();
                    }
                }
                else if (eventAction == EventAction.Update)
                {
                    DataRow updateRow = DM.kaiTable.Rows[currencyManager.Position];
                    if (txtboxKaiName.Text == ""
                        || cmboxEvent.Text == ""
                        || numericQuantity.Text == ""
                        || numericTime.Text == ""
                        || Convert.ToInt32(numericQuantity.Text) < 0
                        || Convert.ToInt32(numericTime.Text) < 0)
                    {
                        // if any of the required fields are empty or invalid, show an error message
                        MessageBox.Show("You must type in all datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtboxKaiName.Text.Length > 255)
                    {
                        MessageBox.Show("The maximal length of Kai name is 255 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // if all fields are valid, set the values for the update row and save the changes
                        if (cmboxEvent.SelectedValue != null)
                        {
                            updateRow["EventID"] = Convert.ToInt32(cmboxEvent.SelectedValue);
                        }
                        else
                        {
                            updateRow["EventID"] = DBNull.Value;
                        }
                        updateRow["KaiName"] = txtboxKaiName.Text;
                        updateRow["PreparationRequired"] = ckboxPreparation.Checked;
                        updateRow["PreparationMinutes"] = numericTime.Value;
                        updateRow["ServeQuantity"] = numericQuantity.Value;

                        currencyManager.EndCurrentEdit();
                        DM.UpdateKai();
                        MessageBox.Show("Kai updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /// <summary>
        /// handles the click event for the delete button, allowing the user to delete a kai record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow deleteow = DM.kaiTable.Rows[currencyManager.Position];
                if (txtboxEvent.Text != "")
                {
                    //must delete the event firstly.
                    MessageBox.Show("You may only delete kai that have no event relation", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        deleteow.Delete();
                        DM.UpdateKai();
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

    }
}
