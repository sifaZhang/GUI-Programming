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
using System.Security.Cryptography.X509Certificates;

namespace Kaioordinate
{
    public partial class DataModule : Form
    {
        public DataTable kaiTable;
        public DataTable eventTable;
        public DataTable whanauTable;
        public DataTable registrationTable;
        public DataTable locationTable;
        public DataView kaiView;
        public DataView eventView;
        public DataView whanauView;
        public DataView registrationView;
        public DataView locationView;


        public DataModule()
        {
            InitializeComponent();

            dsKaioordinate.EnforceConstraints = false;
            daEvent.Fill(dsKaioordinate);
            daKai.Fill(dsKaioordinate);
            daWhanau.Fill(dsKaioordinate);
            daRegistration.Fill(dsKaioordinate);
            daLocation.Fill(dsKaioordinate);
            kaiTable = dsKaioordinate.Tables["Kai"];
            eventTable = dsKaioordinate.Tables["Event"];
            whanauTable = dsKaioordinate.Tables["Whanau"];
            registrationTable = dsKaioordinate.Tables["Registration"];
            locationTable = dsKaioordinate.Tables["Location"];

            dsKaioordinate.Relations.Add("Kai_Event",
                dsKaioordinate.Tables["Event"].Columns["EventID"],
                dsKaioordinate.Tables["Kai"].Columns["EventID"]);
            DataColumn eventNameCol = new DataColumn("EventName", typeof(string));
            eventNameCol.Expression = "Parent(Kai_Event).EventName";
            dsKaioordinate.Tables["Kai"].Columns.Add(eventNameCol);

            dsKaioordinate.EnforceConstraints = true;
        }
        public void UpdateEvent()
        {
            daEvent.Update(eventTable);
        }

        private void daEvent_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnKaioordinate);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EventID"] = newID;
            }
        }

        public void UpdateKai()
        {
            daKai.Update(kaiTable);
        }

        private void daKai_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnKaioordinate);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["KaiID"] = newID;
            }
        }
    }
}
