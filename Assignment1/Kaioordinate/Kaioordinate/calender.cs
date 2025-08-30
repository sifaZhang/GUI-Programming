// this file is used to display a calendar and events associated with selected dates.
// Author: Sifa Zhang
// Date: 08/16/2025

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate
{
    public partial class calenderFrm : Form
    {
        private DataModule DM;

        /// <summary>
        /// constructor for the calendar form.
        /// </summary>
        /// <param name="dM"></param>
        public calenderFrm(DataModule dM)
        {
            InitializeComponent();

            DM = dM;
            //BindControls();
        }

        /// <summary>
        /// Handles the click event for the return button and closes the current form.
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// displays events and related information for the selected date in txtBoxEvents.
        /// </summary>
        /// <param name="selectedDate"></param>
        private void loadCalender(DateTime selectedDate)
        {
            // Clear the text box before loading new events
            txtboxEvents.Clear();

            // Filter the event table for the selected date
            DM.eventTable.DefaultView.RowFilter = $"EventDate = #{selectedDate:MM/dd/yyyy}#";
            DataTable dtEvents = DM.eventTable.DefaultView.ToTable();

            // loop through the filtered events and display their details
            foreach (DataRow row in dtEvents.Rows)
            {
                string eventInfo = $"EventName: {row["EventName"]}\r\n";

                DateTime raw = Convert.ToDateTime(row["EventDate"]);
                string eventDate = raw.Date.ToString("MM-dd-yyyy");
                eventInfo += $"EventDate: {eventDate}\r\n";

                DataRow[] locationRow = DM.locationTable.Select("locationID = " + row["locationID"]);
                if (locationRow.Length > 0)
                {
                    string locationName = locationRow[0]["LocationName"].ToString();
                    eventInfo += $"Location: {locationName}\r\n";

                    string address = locationRow[0]["Address"].ToString();
                    eventInfo += $"Address: {address}\r\n";
                }

                eventInfo += "Attendees:\r\n";

                // Get the registrations for the event
                DataRow[] registrationRows = DM.registrationTable.Select("EventID = " + row["eventID"]);
                foreach (DataRow task in registrationRows)
                {
                    string WhanauID = task["WhanauID"].ToString();
                    DataRow[] whanauRows = DM.whanauTable.Select("WhanauID = " + WhanauID);
                    if (whanauRows.Length > 0)
                    {
                        string firstName = whanauRows[0]["FirstName"].ToString();
                        string lastName = whanauRows[0]["LastName"].ToString();
                        string phone = whanauRows[0]["Phone"].ToString();
                        string helper = registrationRows[0]["KaiPreparation"].ToString() == "True" ? "Kai Preparetion" : "No";
                        eventInfo += $"  {firstName} {lastName}, {phone}, {helper}";
                        eventInfo += "\r\n";
                    }
                }

                // Add a separator for readability
                eventInfo += "\r\n";

                // Append the event information to the text box
                txtboxEvents.Text += eventInfo;
            }

            // If no events are found, display a message
            if (dtEvents.Rows.Count == 0)
            {
                txtboxEvents.Text = "No events on this day.";
            }

            DM.eventTable.DefaultView.RowFilter = null;
        }

        /// <summary>
        /// Handles the event triggered when a date is selected in the calendar.
        /// </summary>
        /// <remarks>This method processes the selected date and updates the calendar view accordingly.
        /// Only the start date of the selected range is used.</remarks>
        /// <param name="sender">The source of the event, typically the calendar control.</param>
        /// <param name="e">An instance of <see cref="DateRangeEventArgs"/> containing the start and end dates of the selected range.</param>
        private void calendarEvent_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start.Date;

            loadCalender(selectedDate);
        }

        /// <summary>
        /// form load event handler. Displays the current date's events when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calenderFrm_Load(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Now.Date;
            loadCalender(selectedDate);
        }

        /// <summary>
        /// Handles the click event for the "Today" button. Displays the current date's events.
        /// </summary>
        /// <remarks>This method sets the calendar to display the current date.</remarks>
        /// <param name="sender">The source of the event, typically the "Today" button.</param>
        /// <param name="e">The event data associated with the click action.</param>
        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Now.Date;
            loadCalender(selectedDate);
        }
    }
}
