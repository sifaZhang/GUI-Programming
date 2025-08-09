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
    public partial class kaiManagement : Form
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

        public kaiManagement(DataModule dm)
        {
            InitializeComponent();

            DM = dm;
            BindControls();
        }

        public void BindControls()
        {
            txtBox_kaiID.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiID");
            txtBox_kaiNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiName");
            txtBox_preparation.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationRequired");
            txtBox_time.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationMinutes");
            txtBox_quantity.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.ServeQuantity");
            txtBox_event.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.EventName");

            listBox_kaiName.DataSource = DM.dsKaioordinate;
            listBox_kaiName.DisplayMember = "Kai.KaiName";
            listBox_kaiName.ValueMember = "Kai.KaiName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Kai"];
        }

        private void iconButton_reture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaiManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
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
            listBox_kaiName.Hide();
            panel1.Visible = true;

            comboBox_event.DisplayMember = "EventName";
            comboBox_event.ValueMember = "EventID";
            comboBox_event.DataSource = DM.dsKaioordinate.Tables["Event"];
            comboBox_event.SelectedItem = txtBox_event.Text;

            txtBox_kaiName.Text = txtBox_kaiNameShow.Text;
            checkBox_preparation.Checked = txtBox_preparation.Text == "True";

            numericUpDown_quantity.Value = string.IsNullOrEmpty(txtBox_quantity.Text) ? 0 : Convert.ToDecimal(txtBox_quantity.Text);
            numericUpDown_time.Value = string.IsNullOrEmpty(txtBox_time.Text) ? 0 : Convert.ToDecimal(txtBox_time.Text);
        }

        private void iconButton_cancel_Click(object sender, EventArgs e)
        {
            iconButton_up.Enabled = true;
            iconButton_down.Enabled = true;
            iconButton_delete.Enabled = true;
            iconButton_return.Enabled = true;
            iconButton_update.Enabled = true;
            iconButton_add.Enabled = true;
            listBox_kaiName.Show();
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
            listBox_kaiName.Hide();
            panel1.Visible = true;


            comboBox_event.DisplayMember = "EventName";
            comboBox_event.ValueMember = "EventID";
            comboBox_event.DataSource = DM.dsKaioordinate.Tables["Event"];

            txtBox_kaiName.Text = "";
            numericUpDown_quantity.Value = 0;
            numericUpDown_time.Value = 0;
        }

        private void iconButton_save_Click(object sender, EventArgs e)
        {
            if (eventAction == EventAction.Add)
            {
                DataRow newRow = DM.kaiTable.NewRow();
                if (txtBox_kaiName.Text == ""
                    || comboBox_event.Text == ""
                    ||  numericUpDown_quantity.Text == ""
                    || numericUpDown_time.Text == ""
                    || Convert.ToInt32(numericUpDown_quantity.Text) <= 0
                    || Convert.ToInt32(numericUpDown_time.Text) < 0)
                {
                    MessageBox.Show("You must type in all datas", "Error");
                }
                else
                {
                    newRow["EventID"] = Convert.ToInt32(comboBox_event.SelectedValue);
                    newRow["KaiName"] = txtBox_kaiName.Text;
                    newRow["PreparationRequired"] = checkBox_preparation.Checked;
                    newRow["PreparationMinutes"] = numericUpDown_time.Value;
                    newRow["ServeQuantity"] = numericUpDown_quantity.Value;

                    DM.kaiTable.Rows.Add(newRow);
                    MessageBox.Show("Kai added successfully", "Success");
                    DM.UpdateKai();
                }
            }
            else if (eventAction == EventAction.Update)
            {
                DataRow updateRow = DM.kaiTable.Rows[currencyManager.Position];
                if (txtBox_kaiName.Text == ""
                    || comboBox_event.Text == ""
                    || numericUpDown_quantity.Text == ""
                    || numericUpDown_time.Text == ""
                    || Convert.ToInt32(numericUpDown_quantity.Text) <= 0
                    || Convert.ToInt32(numericUpDown_time.Text) < 0)
                {
                    MessageBox.Show("You must type in all datas", "Error");
                }
                else
                {
                    updateRow["EventID"] = Convert.ToInt32(comboBox_event.SelectedValue);
                    updateRow["KaiName"] = txtBox_kaiName.Text;
                    updateRow["PreparationRequired"] = checkBox_preparation.Checked;
                    updateRow["PreparationMinutes"] = numericUpDown_time.Value;
                    updateRow["ServeQuantity"] = numericUpDown_quantity.Value;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateKai();
                    MessageBox.Show("Kai updated successfully", "Success");
                }
            }
        }

        private void iconButton_delete_Click(object sender, EventArgs e)
        {
            DataRow deleteow = DM.kaiTable.Rows[currencyManager.Position];
            //if (txtBox_event.Text != "")
            //{
            //    MessageBox.Show("You may only delete kai that have no event relation", "Error");
            //}
            //else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteow.Delete();
                    DM.UpdateKai();
                }
            }
        }
    }
}
