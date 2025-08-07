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
        private InvoiceForm invoiceForm;
        private TreatmentForm treatmentForm;
        private VeterinarianForm veterinarianForm;
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
    }
}
