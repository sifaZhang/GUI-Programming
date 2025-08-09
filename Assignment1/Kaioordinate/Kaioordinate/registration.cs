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
    public partial class registration : Form
    {
        private DataModule DM;
        private CurrencyManager cmEvent;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmRegistration;

        public registration(DataModule dM)
        {
            InitializeComponent();

            DM = dM;
            BindControls();
        }

        private void BindControls()
        {
            dgEvent.DataSource = DM.dsKaioordinate;
            dgEvent.DataMember = "Event";
            dgEvent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgEvent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Event"];

            dgWhanau.DataSource = DM.dsKaioordinate;
            dgWhanau.DataMember = "Whanau";
            dgWhanau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgWhanau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgWhanau.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Whanau"];

            dgRegistration.DataSource = DM.dsKaioordinate;
            dgRegistration.DataMember = "EventRegister";
            dgRegistration.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgRegistration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgRegistration.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmRegistration = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EventRegister"];
        }

        private void registration_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        private void iconButton_reture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton_add_Click(object sender, EventArgs e)
        {
            DataRow eventRow = DM.eventTable.Rows[cmEvent.Position];
            DataRow whanauRow = DM.whanauTable.Rows[cmWhanau.Position];

            int eventID = Convert.ToInt32(eventRow["EventID"]);
            int whanauID = Convert.ToInt32(whanauRow["WhanauID"]);

            DataRow[] selectRow = DM.registrationTable.Select("EventID = " + eventID + " AND WhanauID = " + whanauID);
            if (selectRow.Length > 0)
            {
                MessageBox.Show("Whanau can only be registered to an event once.", "Error");
            }
            else
            {
                DataRow newRegistration = DM.registrationTable.NewRow();
                newRegistration["EventID"] = eventID;
                newRegistration["WhanauID"] = whanauID;
                newRegistration["KaiPreparation"] = checkBox_preparation.Checked;
                DM.registrationTable.Rows.Add(newRegistration);
                DM.UpdateRegistration();
                MessageBox.Show("Entry added successfully.", "Success");
            }
        }

        private void iconButton_delete_Click(object sender, EventArgs e)
        {
            DataRow deleteow = DM.registrationTable.Rows[cmRegistration.Position];

            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteow.Delete();
                DM.UpdateRegistration();
            }

        }
    }
}
