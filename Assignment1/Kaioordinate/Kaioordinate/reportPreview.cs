// this file is used to preview reports in the Kaioordinate application.
// Author: Sifa Zhang
// Date: 08/16/2025

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate
{
    public partial class reportPreview : Form
    {
        private DataModule DM;
        private int currentEventIndex = 0;

        /// <summary>
        /// Constructor for reportPreview
        /// </summary>
        /// <param name="dm"></param>
        public reportPreview(DataModule dm)
        {
            InitializeComponent();

            DM = dm;
        }

        /// <summary>
        /// form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportPreview_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        /// <summary>
        /// Prepare the preview to print events report
        /// </summary>
        public void PrintEvents()
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += DrawEventPage;
                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = pd,
                    Width = 800,
                    Height = 600
                };
                preview.ShowDialog();
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
        /// Prepare the preview to print whanaus report
        /// </summary>
        public void PrintWhanaus()
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += DrawWhanauPage;
                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = pd,
                    Width = 800,
                    Height = 600
                };
                preview.ShowDialog();
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
        /// draw whanau page for printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawWhanauPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // prepare the graphics and fonts for drawing
                Graphics g = e.Graphics;
                Font titleFont = new Font("Arial", 14, FontStyle.Bold);
                Font detailFont = new Font("Arial", 14);
                float y = 50;
                int column1StartPoint = 20;
                int column2StartPoint = 160;
                int column3StartPoint = 360;
                int column4StartPoint = 560;
                int column5StartPoint = 700;
                int rowHeight = 28;

                // draw the title
                g.DrawString($"WhanauID", titleFont, Brushes.Black, column1StartPoint, y);
                g.DrawString($"Name", titleFont, Brushes.Black, column2StartPoint, y);
                g.DrawString($"Phone", titleFont, Brushes.Black, column3StartPoint, y);
                g.DrawString($"Participation", titleFont, Brushes.Black, column4StartPoint, y);
                g.DrawString($"Preparation", titleFont, Brushes.Black, column5StartPoint, y);
                g.DrawLine(Pens.Black, column1StartPoint, y + rowHeight, column5StartPoint + 200, y + rowHeight);
                y += rowHeight * 2;

                // draw the data rows
                for (int i = 0; i < DM.whanauTable.Rows.Count - 1; i++)
                {
                    DataRow whanauRow = DM.whanauTable.Rows[i];
                    string whanauID = whanauRow["WhanauID"].ToString();
                    g.DrawString($"{whanauID}", detailFont, Brushes.Black, column1StartPoint, y);

                    string firstName = whanauRow["FirstName"].ToString();
                    string lastName = whanauRow["LastName"].ToString();
                    g.DrawString($"{firstName} {lastName}", detailFont, Brushes.Black, column2StartPoint, y);

                    string phone = whanauRow["Phone"].ToString();
                    g.DrawString($"{phone}", detailFont, Brushes.Black, column3StartPoint, y);

                    int ParticipationCount = DM.registrationTable.Select("WhanauID = " + whanauID).Length;
                    g.DrawString($"{ParticipationCount}", detailFont, Brushes.Black, column4StartPoint, y);

                    int PreparationCount = DM.registrationTable.Select("WhanauID = " + whanauID + " AND KaiPreparation = true").Length;
                    g.DrawString($"{PreparationCount}", detailFont, Brushes.Black, column5StartPoint, y);

                    y += rowHeight;
                }

                // draw the horizontal line at the bottom
                g.DrawLine(Pens.Black, column1StartPoint, y, column5StartPoint + 200, y);

                // reset the current event index for the next print
                e.HasMorePages = false;
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
        /// draw event page for printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawEventPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // find if there is a event that has been registrated.
                bool findCurrent = false;
                bool findNext = false;
                DataRow eventRow = null;
                string eventID = "";
                DataRow[] registrationRows = null;
                for (int i = currentEventIndex; i < DM.eventTable.Rows.Count; i++)
                {
                    eventRow = DM.eventTable.Rows[i];
                    eventID = eventRow["EventID"].ToString();
                    registrationRows = DM.registrationTable.Select("EventID = " + eventID);

                    if (registrationRows.Length > 0)
                    {
                        // find one
                        if (findCurrent)
                        {
                            // find the next event
                            findNext = true;
                            break;
                        }
                        else
                        {
                            // find the current event
                            currentEventIndex = i;
                            findCurrent = true;
                        }
                    }
                }

                // Check if there are more events to print
                if (findCurrent)
                {
                    eventRow = DM.eventTable.Rows[currentEventIndex];
                    eventID = eventRow["EventID"].ToString();
                    registrationRows = DM.registrationTable.Select("EventID = " + eventID);

                    // Check if there are any registrations for the current event
                    if (registrationRows.Length > 0)
                    {
                        // Prepare the graphics and fonts for drawing
                        Graphics g = e.Graphics;
                        Font titleFont = new Font("Arial", 14, FontStyle.Bold);
                        Font detailFont = new Font("Arial", 14);
                        float y = 50;
                        int column1StartPoint = 50;
                        int column2StartPoint = 200;
                        int column3StartPoint = 400;
                        int column4StartPoint = 600;
                        int rowHeight = 28;

                        // Draw the summary
                        g.DrawString($"Event ID:", titleFont, Brushes.Black, column1StartPoint, y);
                        g.DrawString($"{eventID}", detailFont, Brushes.Black, column2StartPoint, y);
                        y += rowHeight + rowHeight / 2;

                        string eventName = eventRow["EventName"].ToString();
                        g.DrawString($"EventName:", titleFont, Brushes.Black, column1StartPoint, y);
                        g.DrawString($"{eventName}", detailFont, Brushes.Black, column2StartPoint, y);
                        y += rowHeight;

                        DateTime raw = Convert.ToDateTime(eventRow["EventDate"]);
                        string eventDate = raw.Date.ToString("MM-dd-yyyy");
                        g.DrawString($"Date:", titleFont, Brushes.Black, column1StartPoint, y);
                        g.DrawString($"{eventDate}", detailFont, Brushes.Black, column2StartPoint, y);
                        y += rowHeight;

                        // Get the location information
                        string locationID = eventRow["LocationID"].ToString(); ;
                        DataRow[] locationRow = DM.locationTable.Select("locationID = " + locationID);
                        if (locationRow.Length > 0)
                        {
                            string locationName = locationRow[0]["LocationName"].ToString();
                            g.DrawString($"Location:", titleFont, Brushes.Black, column1StartPoint, y);
                            g.DrawString($"{locationName}", detailFont, Brushes.Black, column2StartPoint, y);
                            y += rowHeight;

                            string address = locationRow[0]["Address"].ToString();
                            g.DrawString($"Address:", titleFont, Brushes.Black, column1StartPoint, y);
                            g.DrawString($"{address}", detailFont, Brushes.Black, column2StartPoint, y);
                            y += rowHeight;
                        }

                        // Draw the attendees section
                        y += rowHeight / 2;
                        g.DrawString($"Attendees:", titleFont, Brushes.Black, column1StartPoint, y);
                        y += rowHeight + rowHeight / 2;

                        g.DrawString($"First Name", titleFont, Brushes.Black, column1StartPoint, y);
                        g.DrawString($"Last Name", titleFont, Brushes.Black, column2StartPoint, y);
                        g.DrawString($"Phone No.", titleFont, Brushes.Black, column3StartPoint, y);
                        g.DrawString($"Helper", titleFont, Brushes.Black, column4StartPoint, y);
                        y += rowHeight;

                        // Draw whanaus registered for the event
                        foreach (DataRow task in registrationRows)
                        {
                            string WhanauID = task["WhanauID"].ToString();
                            DataRow[] whanauRows = DM.whanauTable.Select("WhanauID = " + WhanauID);
                            if (whanauRows.Length > 0)
                            {
                                string firstName = whanauRows[0]["FirstName"].ToString();
                                g.DrawString($"{firstName}", detailFont, Brushes.Black, column1StartPoint, y);
                                string lastName = whanauRows[0]["LastName"].ToString();
                                g.DrawString($"{lastName}", detailFont, Brushes.Black, column2StartPoint, y);
                                string phone = whanauRows[0]["Phone"].ToString();
                                g.DrawString($"{phone}", detailFont, Brushes.Black, column3StartPoint, y);
                                string helper = registrationRows[0]["KaiPreparation"].ToString();
                                g.DrawString($"{helper}", detailFont, Brushes.Black, column4StartPoint, y);

                                y += rowHeight;
                            }
                        }
                    }

                    currentEventIndex++;
                    // do not print the next page if there is no more events to print
                    e.HasMorePages = findNext;
                }
                else
                {
                    e.HasMorePages = false;
                    return;
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
        /// Handles the click event of the Return button.
        /// </summary>
        /// <remarks>This method closes the current form when the Return button is clicked.</remarks>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An <see cref="EventArgs"/> object containing event data.</param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the click event for the Event Report button.
        /// </summary>
        /// <remarks>This method triggers the generation of an event report by invoking the <see
        /// cref="PrintEvents"/> method.</remarks>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An <see cref="EventArgs"/> object containing event data.</param>
        private void btnEventReport_Click(object sender, EventArgs e)
        {
            currentEventIndex = 0;
            PrintEvents();
        }

        /// <summary>
        /// handles the click event for the Participation Report button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipationRreport_Click(object sender, EventArgs e)
        {
            PrintWhanaus();
        }
    }
}
