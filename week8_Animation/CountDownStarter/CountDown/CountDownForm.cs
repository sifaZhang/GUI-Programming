using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class CountDownForm : Form
    {
        private bool noSeconds = false;
        private DateTime raceStart, lapBegan;
        private int lapCount;
        private DateTime timeIntervalBegan, timeIntervalEnd;

        /// <summary> method: lblSecs_Click
        /// Toggle the true/false value of the noSeconds flag
        /// when the user clicks on the seconds label
        /// </summary>
        private void lblSecs_Click(object sender, EventArgs e)
        {
            noSeconds = !noSeconds;
        }

        /// <summary> method: btnlapStart_Click
        /// For the stopwatch on the Laps tabbed page when
        /// the Start button is clicked record the start time
        /// and the time the lap started then start the timer 
        /// </summary>
        private void btnlapStart_Click(object sender, EventArgs e)
        {
            lapCount = 0;
            txtLaps.Text = "";
            raceStart = DateTime.Now;
            lapBegan = raceStart;
            tmrLaps.Enabled = true;
        }

        /// <summary> method: tmrLaps_Tick
        /// Each time tmrlaps has a Tick event
        /// Display the amount of time that has passed
        /// since the stopwatch was started
        /// </summary>
        private void tmrLaps_Tick(object sender, EventArgs e)
        {
            DateTime rightNow;
            TimeSpan howLong;
            rightNow = DateTime.Now;
            howLong = (rightNow - raceStart);
            lblLapTimer.Text = DisplayTimeSpan(howLong);
        }


        /// <summary> method: tmrClock_Tick
        /// Update the text in three labels that make up 
        /// a digital clock on the first tabbed page
        /// Use the noSeconds flag to decide if the seconds update
        /// </summary>
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h : mm tt");
            lblDate.Text = DateTime.Now.ToString("dddd d MMMM yyyy");

            if (!noSeconds)
            {
                lblSecs.Text = DateTime.Now.ToString("ss");
            }
            else
            {
                lblSecs.Text = "";
            }
        }

        public CountDownForm()
        {
            InitializeComponent();
        }

        /// <summary> method: btnLap_Click
        /// Calculate the lap time and display it
        /// store a new starting point for lapBegan 
        /// as a new lap is starting now
        /// </summary>
        private void btnLap_Click(object sender, EventArgs e)
        {
            DateTime rightNow;
            TimeSpan howLong;
            lapCount += 1;
            rightNow = DateTime.Now;
            howLong = (rightNow - lapBegan);
            lapBegan = rightNow;
            if(txtLaps.Text == "")
            {
                txtLaps.Text = "Lap" + lapCount.ToString("00") + "   " + DisplayTimeSpan(howLong);
            }
            else
            {
                txtLaps.Text = txtLaps.Text + "\r\n" + "Lap" + lapCount.ToString("00") + "   " + DisplayTimeSpan(howLong);
            }
        }

        /// <summary> method: btnStop_Click
        /// Stop the stopwatch and call the btnLap_Click method
        /// in order to calculate and display the final lap details
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrLaps.Enabled = false;
            btnLap_Click(sender, e);
        }

        /// <summary> method: btnStartTimer_Click
        /// The timer on the Timer tabbed page counts down from
        /// a starting time in minutes and seconds that the user
        /// sets using two NumericUpDown controls
        /// 
        /// this button to start the timer stores the DateTime values
        /// for the start and finish of the timer action
        /// </summary>
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            tmrTimer.Enabled = true;
            TimeSpan ts = new TimeSpan(0, 0, (int)spinMin.Value, (int)spinSec.Value, 0);
            timeIntervalEnd = DateTime.Now + ts;
            timeIntervalBegan = DateTime.Now;
        }

        /// <summary> method: tmrTimer_Tick
        /// The timer on the Timer tabbed page counts down from
        /// a starting time in minutes and seconds that the user
        /// sets using two NumericUpDown controls
        /// 
        /// Each time the timer ticks the remaining time is calculated 
        /// and displayed
        /// </summary>
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if(timeIntervalEnd >= DateTime.Now)
            {
                lblRemaining.Text = DisplayTimeSpan(timeIntervalEnd - DateTime.Now);
            }
            else
            {
                lblRemaining.Text = "Finished";
                tmrTimer.Enabled = false;
            }
        }

        /// <summary> method: btnCheck_Click
        /// Calculate and display the time remaining from the start date and time given 
        /// on the Countdown tabbed page. The starting date and time
        /// are displayed in DateTimePicker controls
        /// </summary>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime When;
            When = new DateTime(dtpDate.Value.Year,
                                dtpDate.Value.Month,
                                dtpDate.Value.Day,
                                dtpTime.Value.Hour,
                                dtpTime.Value.Minute,
                                 dtpTime.Value.Second);
            label4.Text = DisplayLongTimeSpan(When - DateTime.Now);
        }

        private void tmrQuit_Tick(object sender, EventArgs e)
        {

        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {

        }

        /// <summary> method: DisplayTimeSpan
        /// 
        /// </summary>
        private string DisplayTimeSpan(TimeSpan howLong)
        {
            return (

                howLong.Hours.ToString("00") + ":"
                + howLong.Minutes.ToString("00") + ":"
                + howLong.Seconds.ToString("00") + ":"
                + howLong.Milliseconds.ToString("0000"));
        }

        /// <summary> method: DisplayLongTimeSpan
        /// A Timespan object stores the difference between two times
        /// this method displays that time interval
        /// as four lines of text for easy reading
        /// </summary>
        private string DisplayLongTimeSpan(TimeSpan howLong)
        {
            return (
                howLong.Days.ToString("0") + " days" + "\r\n"
                + howLong.Hours.ToString("0") + " hours" + "\r\n"
                + howLong.Minutes.ToString("0") + " minutes" + "\r\n"
                + howLong.Seconds.ToString("0") + " seconds" + "\r\n"
                );
        }

    }
}
