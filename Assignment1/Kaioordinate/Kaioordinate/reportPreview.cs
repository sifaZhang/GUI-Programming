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

        public reportPreview(DataModule dm)
        {
            InitializeComponent();

            DM = dm;
        }

        private void reportPreview_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        private void iconButton_reture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton_report_Click(object sender, EventArgs e)
        {
            Print();
        }

        public void Print()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 600
            };
            preview.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            if (currentEventIndex >= DM.eventTable.Rows.Count)
            {
                e.HasMorePages = false;
                return;
            }

            Graphics g = e.Graphics;
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font detailFont = new Font("Arial", 14);
            float y = 50;
            int column1StartPoint = 50;
            int column2StartPoint = 200;
            int column3StartPoint = 400;
            int column4StartPoint = 600;
            int rowHeight = 28;

            DataRow eventRow = DM.eventTable.Rows[currentEventIndex];
            string eventID = eventRow["EventID"].ToString();
            g.DrawString($"Event ID:", titleFont, Brushes.Black, column1StartPoint, y);
            g.DrawString($"{eventID}", detailFont, Brushes.Black, column2StartPoint, y);
            y += rowHeight + rowHeight / 2;

            string eventName = eventRow["EventName"].ToString();
            g.DrawString($"EventName:", titleFont, Brushes.Black, column1StartPoint, y);
            g.DrawString($"{eventName}", detailFont, Brushes.Black, column2StartPoint, y);
            y += rowHeight;

            string eventDate = eventRow["EventDate"].ToString();
            g.DrawString($"Date:", titleFont, Brushes.Black, column1StartPoint, y);
            g.DrawString($"{eventDate}", detailFont, Brushes.Black, column2StartPoint, y);
            y += rowHeight;

            string locationID = eventRow["LocationID"].ToString(); ;
            DataRow[] locationRow = DM.locationTable.Select("locationID = " + locationID);
            if (locationRow.Length > 0)
            {
                string locationName = locationRow[0]["LocationName"].ToString();
                g.DrawString($"Location:", titleFont, Brushes.Black, column1StartPoint, y);
                g.DrawString($"{locationName}", detailFont, Brushes.Black, column2StartPoint, y);
                y += rowHeight;

                string address = locationRow[0]["Address"].ToString();
                g.DrawString($"Location:", titleFont, Brushes.Black, column1StartPoint, y);
                g.DrawString($"{address}", detailFont, Brushes.Black, column2StartPoint, y);
                y += rowHeight;
            }

            y += rowHeight / 2;
            g.DrawString($"Attendees:", titleFont, Brushes.Black, column1StartPoint, y);
            y += rowHeight + rowHeight / 2;

            g.DrawString($"First Name", titleFont, Brushes.Black, column1StartPoint, y);
            g.DrawString($"Last Name", titleFont, Brushes.Black, column2StartPoint, y);
            g.DrawString($"Phone No.", titleFont, Brushes.Black, column3StartPoint, y);
            g.DrawString($"Helper", titleFont, Brushes.Black, column4StartPoint, y);
            y += rowHeight;

            // 获取子表数据
            DataRow[] registrationRows = DM.registrationTable.Select("EventID = " + eventID);
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

            currentEventIndex++;
            e.HasMorePages = currentEventIndex < DM.eventTable.Rows.Count;
        }

    }
}
