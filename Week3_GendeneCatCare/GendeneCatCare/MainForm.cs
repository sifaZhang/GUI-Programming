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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private CatForm catForm;
        private OwnerForm ownerForm;
        private InvoiceForm frmInvoice;
        private TreatmentForm treatmentForm;
        private VeterinarianForm frmVet;
        private VisitForm visitForm;
        private VisitTreatmentForm visitTreatmentForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            if(treatmentForm == null)
            {
                treatmentForm = new TreatmentForm(DM, this);
            }
            treatmentForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVeterinarian_Click(object sender, EventArgs e)
        {
            if (frmVet == null)
            {
                frmVet = new VeterinarianForm(DM, this);
            }
            frmVet.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();
        }
    }
}
