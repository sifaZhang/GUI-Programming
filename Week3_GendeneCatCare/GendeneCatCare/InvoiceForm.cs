using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GendeneCatCare
{
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmCat;
            CurrencyManager cmOwner;
            CurrencyManager cmTreatment;
            CurrencyManager cmVeterinarian;
            string visitText = "";
            double visitTotal = 0;
            cmCat = (CurrencyManager)this.BindingContext[DM.dsGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.dsGlendene, "OWNER"];
            cmTreatment = (CurrencyManager)this.BindingContext[DM.dsGlendene, "TREATMENT"];
            cmVeterinarian = (CurrencyManager)this.BindingContext[DM.dsGlendene, "VETERINARIAN"];
            txtInvoices.Text = "";
            foreach (DataRow drVisit in DM.dtVisit.Rows)
            {
                string visitStatus = drVisit["Status"].ToString();
                if (visitStatus.Equals("Pending") == true)
                {
                    // get the cat record matching the cat ID from the visit record
                    int aCatID = Convert.ToInt32(drVisit["CatID"].ToString());
                    cmCat.Position = DM.catView.Find(aCatID);
                    DataRow drCat = DM.dtCat.Rows[cmCat.Position];
                    // get the owner record matching the owner ID from the cat record
                    int anOwnerID = Convert.ToInt32(drCat["OwnerID"].ToString());
                    cmOwner.Position = DM.ownerView.Find(anOwnerID);
                    DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
                    visitText += "Owner ID: " + drOwner["OwnerID"] + "\r\n";
                    visitText += drOwner["LastName"] + ", " + drOwner["FirstName"] + "\r\n";
                    visitText += drOwner["StreetAddress"] + "\r\n";
                    visitText += drOwner["Suburb"] + "\r\n\r\n\r\n";
                    visitText += "Cat Name: " + drCat["Name"] + "Visit ID: " + drVisit["VisitID"] +
                    "Visit Date: " + drVisit["VisitDate"] + "\r\n\r\n\r\n";
                }

                // get the veterinarian record matching the veterinarian ID from the visit record
                int aVeterinarianID = Convert.ToInt32(drVisit["VeterinarianID"].ToString());
                cmVeterinarian.Position = DM.veterinarianView.Find(aVeterinarianID);
                DataRow drVeterinarian = DM.dtVeterinarian.Rows[cmVeterinarian.Position];
                visitText += drVeterinarian["LastName"] + ", " + drVeterinarian["FirstName"] + "\r\n";
                visitTotal += Convert.ToDouble(drVeterinarian["Rate"]);
                DataRow[] drTreatments = drVisit.GetChildRows(DM.dtVisit.ChildRelations["FK_VISIT_VISITTREATMENT"]);
                if (drTreatments.Length > 0)
                {
                    txtInvoices.Text += visitText;
                    foreach (DataRow drVisitTreatment in drTreatments)
                    {
                        string treatmentText = "";
                        int aTreatmentID = Convert.ToInt32(drVisitTreatment["TreatmentID"].ToString());
                        cmTreatment.Position = DM.treatmentView.Find(aTreatmentID);
                        DataRow drTreatment = DM.dtTreatment.Rows[cmTreatment.Position];
                        double treatmentCost;
                        treatmentCost = Convert.ToInt32(drVisitTreatment["Quantity"]) *
                        Convert.ToDouble(drTreatment["Cost"]);
                        visitTotal += treatmentCost;
                        treatmentText = "\tTreatment Description: " + drTreatment["Description"]
                        + "\tQuantity: " + drVisitTreatment["Quantity"]
                        + "\tTreatment Cost: " + Convert.ToString(treatmentCost)
                        + "\r\n";
                        txtInvoices.Text += treatmentText;
                    }
                    txtInvoices.Text += "\r\n";
                    txtInvoices.Text += "\t\t\t\t\t\t\t\t\t\t\t\t\tGross Due: " + Convert.ToString(visitTotal);
                    txtInvoices.Text += "\r\n\r\n\r\n\r\n";
                }
                visitText = "";
                visitTotal = 0;
            }
        }
    }
}
