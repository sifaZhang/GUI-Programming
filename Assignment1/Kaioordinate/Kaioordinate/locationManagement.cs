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
    public partial class locationManagement : Form
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

        public locationManagement(DataModule dm)
        {
            InitializeComponent();

            DM = dm;
            BindControls();
        }

        public void BindControls()
        {
            txtBox_locationID.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationID");
            txtBox_locationNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationName");
            txtBox_addressShow.DataBindings.Add("Text", DM.dsKaioordinate, "Location.Address");

            listBox_locationName.DataSource = DM.dsKaioordinate;
            listBox_locationName.DisplayMember = "Location.LocationName";
            listBox_locationName.ValueMember = "Location.LocationID";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Location"];
        }

        private void locationManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
        }

        private void iconButton_reture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            iconButton_up.Enabled = true;
            iconButton_down.Enabled = true;
            iconButton_delete.Enabled = true;
            iconButton_return.Enabled = true;
            iconButton_update.Enabled = true;
            iconButton_add.Enabled = true;
            listBox_locationName.Show();
            panel1.Visible = false;
            eventAction = EventAction.none;
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
            listBox_locationName.Hide();
            panel1.Visible = true;

            txtBox_locationName.Text = txtBox_locationNameShow.Text;
            txtBox_address.Text = txtBox_addressShow.Text;
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
            listBox_locationName.Hide();
            panel1.Visible = true;


            txtBox_locationName.Text = "";
            txtBox_locationID.Text = "";
            txtBox_address.Text = "";
        }

        private void iconButton_delete_Click(object sender, EventArgs e)
        {
            DataRow deleteow = DM.locationTable.Rows[currencyManager.Position];
            DataRow[] dsRow = DM.eventTable.Select("LocationID = " + txtBox_locationID.Text);
            if (dsRow.Length != 0)
            {
                MessageBox.Show("You may only delete locations that have no events", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteow.Delete();
                    DM.UpdateLocation();
                }
            }
        }

        private void iconButton_save_Click(object sender, EventArgs e)
        {
            if (eventAction == EventAction.Add)
            {
                DataRow newRow = DM.locationTable.NewRow();
                if (txtBox_locationName.Text == ""
                    || txtBox_address.Text == "")
                {
                    MessageBox.Show("You must type in all datas", "Error");
                }
                else
                {
                    newRow["LocationName"] = txtBox_locationName.Text;
                    newRow["Address"] = txtBox_address.Text;

                    DM.locationTable.Rows.Add(newRow);
                    MessageBox.Show("Location added successfully", "Success");
                    DM.UpdateLocation();
                }
            }
            else if (eventAction == EventAction.Update)
            {
                DataRow updateRow = DM.locationTable.Rows[currencyManager.Position];
                if (txtBox_locationName.Text == ""
                    || txtBox_address.Text == "")
                {
                    MessageBox.Show("You must type in all datas", "Error");
                }
                else
                {
                    updateRow["LocationName"] = txtBox_locationName.Text;
                    updateRow["Address"] = txtBox_address.Text;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateLocation();
                    MessageBox.Show("Location updated successfully", "Success");
                }
            }
        }
    }
}
