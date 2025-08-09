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
    public partial class whānauManagement : Form
    {
        enum EventAction
        {
            none,
            Add,
            Update
        }

        private DataModule DM;
        private CurrencyManager currencyManager;
        private EventAction eventAction = EventAction.none;

        public whānauManagement(DataModule dm)
        {
            InitializeComponent();

            DM = dm;
            BindControls();
        }

        public void BindControls()
        {
            txtBox_whanauID.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.WhanauID");
            txtBox_firstNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.FirstName");
            txtBox_lastNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.LastName");
            txtBox_phoneShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Phone");
            txtBox_emailShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Email");
            txtBox_addressShow.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Address");

            // 假设 dsKaioordinate.Tables["Whanau"] 已经存在
            if (!DM.dsKaioordinate.Tables["Whanau"].Columns.Contains("FullName"))
            {
                DM.dsKaioordinate.Tables["Whanau"].Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
            }
            listBox_whanauName.DataSource = DM.dsKaioordinate;
            listBox_whanauName.DisplayMember = "Whanau.FullName";
            listBox_whanauName.ValueMember = "Whanau.WhanauID";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Whanau"];
        }

        private void iconButton_update_Click(object sender, EventArgs e)
        {
            eventAction = EventAction.Update;
            iconButton_up.Enabled = false;
            iconButton_down.Enabled = false;
            iconButton_delete.Enabled = false;
            iconButton_return.Enabled = false;
            iconButton_update.Enabled = false;
            iconButton_add.Enabled = false;
            listBox_whanauName.Hide();
            panel1.Visible = true;

            txtBox_firstName.Text = txtBox_firstNameShow.Text;
            txtBox_lastName.Text = txtBox_lastNameShow.Text;
            txtBox_phone.Text = txtBox_phoneShow.Text;
            txtBox_email.Text = txtBox_emailShow.Text;
            txtBox_address.Text = txtBox_addressShow.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void iconButton_reture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WhānauManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            iconButton_up.Enabled = true;
            iconButton_down.Enabled = true;
            iconButton_delete.Enabled = true;
            iconButton_return.Enabled = true;
            iconButton_update.Enabled = true;
            iconButton_add.Enabled = true;
            listBox_whanauName.Show();
            panel1.Visible = false;
            eventAction = EventAction.none;
        }

        private void iconButton_up_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void iconButton_down_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void iconButton_add_Click(object sender, EventArgs e)
        {
            eventAction = EventAction.Add;
            iconButton_up.Enabled = false;
            iconButton_down.Enabled = false;
            iconButton_delete.Enabled = false;
            iconButton_return.Enabled = false;
            iconButton_update.Enabled = false;
            iconButton_add.Enabled = false;
            listBox_whanauName.Hide();
            panel1.Visible = true;

            txtBox_firstName.Text = "";
            txtBox_lastName.Text = "";
            txtBox_phone.Text = "";
            txtBox_email.Text = "";
            txtBox_address.Text = "";
        }

        private void iconButton_delete_Click(object sender, EventArgs e)
        {
            DataRow deleteow = DM.whanauTable.Rows[currencyManager.Position];
            DataRow[] dsRow = DM.registrationTable.Select("WhanauID = " + txtBox_whanauID.Text);
            if (dsRow.Length != 0)
            {
                MessageBox.Show("You may only delete records that have no registrations", "Error");
            } else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteow.Delete();
                    DM.UpdateWhanau();
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (eventAction == EventAction.Add)
            {
                DataRow newRow = DM.whanauTable.NewRow();
                if (txtBox_firstName.Text == ""
                    || txtBox_lastName.Text == ""
                    || txtBox_phone.Text == ""
                    || txtBox_email.Text == ""
                    || txtBox_address.Text == "")
                {
                    MessageBox.Show("You must type in all datas", "Error");
                }
                else if (!txtBox_email.Text.Contains('@'))
                {
                    MessageBox.Show("Email is not valid", "Error");
                }
                else
                {
                    newRow["FirstName"] = txtBox_firstName.Text;
                    newRow["LastName"] = txtBox_lastName.Text;
                    newRow["Phone"] = txtBox_phone.Text;
                    newRow["Email"] = txtBox_email.Text;
                    newRow["Address"] = txtBox_address.Text;

                    DM.whanauTable.Rows.Add(newRow);
                    MessageBox.Show("Whanau added successfully", "Success");
                    DM.UpdateWhanau();
                }
            }
            else if (eventAction == EventAction.Update)
            {
                DataRow updateRow = DM.whanauTable.Rows[currencyManager.Position];
                if (txtBox_firstName.Text == ""
                    || txtBox_lastName.Text == ""
                    || txtBox_phone.Text == ""
                    || txtBox_email.Text == ""
                    || txtBox_address.Text == "" )
                {
                    MessageBox.Show("You must type in all datas", "Error");
                }
                else if (!txtBox_email.Text.Contains('@'))
                {
                    MessageBox.Show("Email is not valid", "Error");
                }
                else
                {
                    updateRow["FirstName"] = txtBox_firstName.Text;
                    updateRow["LastName"] = txtBox_lastName.Text;
                    updateRow["Phone"] = txtBox_phone.Text;
                    updateRow["Email"] = txtBox_email.Text;
                    updateRow["Address"] = txtBox_address.Text;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateWhanau();
                    MessageBox.Show("Whanau updated successfully", "Success");
                }
            }
        }
    }
}
