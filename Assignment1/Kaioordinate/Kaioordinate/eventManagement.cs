using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;

namespace Kaioordinate
{
    public partial class eventManagement : Form
    {
        enum EventAction
        {
            none,
            Add,
            Update
        }

        private DataModule DM;
        private MianFrm frmMenu;
        private CurrencyManager currencyManager;
        private EventAction eventAction = EventAction.none;

        public eventManagement(DataModule dm, MianFrm mnu)
        {
            InitializeComponent();

            DM = dm;
            frmMenu = mnu;
            BindControls();


            // 运行时强制统一字体
            //var commonFont = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            //this.Font = commonFont;
            //txtBox_eventID.Height = TextRenderer.MeasureText("测试", commonFont).Height;
        }

        public void BindControls()
        {
            txtBox_eventID.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventID");
            txtBox_eventNameShow.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventName");
            txtBox_location.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.LocationID");

            System.Windows.Forms.Binding binding = new System.Windows.Forms.Binding("Text", DM.dsKaioordinate, "EVENT.EventDate");
            binding.Format += (s, e) =>
            {
                if (e.DesiredType == typeof(string) && e.Value != DBNull.Value)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("yyyy-MM-dd"); // 只要日期
                }
            };
            txtBox_date.DataBindings.Add(binding);

            listBox_eventName.DataSource = DM.dsKaioordinate;
            listBox_eventName.DisplayMember = "EVENT.EventName";
            listBox_eventName.ValueMember = "EVENT.EventName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT"];
        }

        private void iconButton_reture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton_cancel_Click(object sender, EventArgs e)
        {
            iconButton_up.Enabled = true;
            iconButton_down.Enabled = true;
            iconButton_delete.Enabled = true;
            iconButton_return.Enabled = true;
            iconButton_update.Enabled = true;
            iconButton_add.Enabled = true;
            listBox_eventName.Show();
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
            listBox_eventName.Hide();
            panel1.Visible = true;

            txtBox_eventName.Text = txtBox_eventNameShow.Text;
            dateTimePicker_date.Text = txtBox_date.Text;
            comboBox_location.DisplayMember = "LocationName";
            comboBox_location.ValueMember = "LocationID";
            comboBox_location.DataSource = DM.dsKaioordinate.Tables["location"];

            // 选中对应项
            comboBox_location.SelectedValue = txtBox_location.Text;
        }

        private void eventManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(6, 73, 41);
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
            listBox_eventName.Hide();
            panel1.Visible = true;


            txtBox_eventName.Text = "";
            dateTimePicker_date.Text = "";
            comboBox_location.DisplayMember = "LocationName";
            comboBox_location.ValueMember = "LocationID";
            comboBox_location.DataSource = DM.dsKaioordinate.Tables["location"];
        }

        private void iconButton_save_Click(object sender, EventArgs e)
        {
            if (eventAction == EventAction.Add)
            {
                DataRow newEvent = DM.eventTable.NewRow();
                if ((txtBox_eventName.Text == "") 
                    || (dateTimePicker_date.Text == "") 
                    || comboBox_location.Text == "")
                {
                    MessageBox.Show("You must type in all datas", "Error");
                }
                else
                {
                    newEvent["EventName"] = txtBox_eventName.Text;
                    newEvent["LocationID"] = Convert.ToInt32(comboBox_location.SelectedValue);
                    newEvent["EventDate"] = dateTimePicker_date.Value.Date;

                    DM.eventTable.Rows.Add(newEvent);
                    MessageBox.Show("Event added successfully", "Success");
                    DM.UpdateEvent();
                }
            }
            else if (eventAction == EventAction.Update)
            {
                DataRow updateEvent = DM.eventTable.Rows[currencyManager.Position];
                if ((txtBox_eventName.Text == "") 
                    || (dateTimePicker_date.Text == "") 
                    || comboBox_location.Text == "")
                {
                    MessageBox.Show("You must type in all datas", "Error");
                }
                else
                {
                    updateEvent["EventName"] = txtBox_eventName.Text;
                    updateEvent["LocationID"] = Convert.ToInt32(comboBox_location.SelectedValue);
                    updateEvent["EventDate"] = dateTimePicker_date.Value.Date;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateEvent();
                    MessageBox.Show("Event updated successfully", "Success");
                }
            }
        }

        private void iconButton_delete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.eventTable.Rows[currencyManager.Position];
            DataRow[] VisitTreatmentRow = DM.kaiTable.Select("EventID = " + txtBox_eventID.Text);
            if (VisitTreatmentRow.Length != 0)
            {
                MessageBox.Show("You may only delete an event that has no kai", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    DM.UpdateEvent();
                }
            }
        }
    }
}
