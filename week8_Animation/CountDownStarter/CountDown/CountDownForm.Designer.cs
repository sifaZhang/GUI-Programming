namespace CountDown
{
    partial class CountDownForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrLaps = new System.Windows.Forms.Timer(this.components);
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.btnCheck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tmrQuit = new System.Windows.Forms.Timer(this.components);
            this.lblRemaining = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.btnlapStart = new System.Windows.Forms.Button();
            this.spinMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.spinSec = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLapTimer = new System.Windows.Forms.Label();
            this.txtLaps = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSecs = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSec)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // tmrLaps
            // 
            this.tmrLaps.Tick += new System.EventHandler(this.tmrLaps_Tick);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(36, 77);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 37);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(72, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 160);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(216, 74);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(298, 44);
            this.dtpTime.TabIndex = 1;
            this.dtpTime.Value = new System.DateTime(2005, 1, 28, 7, 30, 0, 0);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(36, 12);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(478, 44);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Value = new System.DateTime(2005, 1, 31, 0, 0, 0, 0);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCheck);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dtpTime);
            this.tabPage4.Controls.Add(this.dtpDate);
            this.tabPage4.Location = new System.Drawing.Point(8, 51);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(524, 323);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Countdown";
            // 
            // tmrQuit
            // 
            this.tmrQuit.Tick += new System.EventHandler(this.tmrQuit_Tick);
            // 
            // lblRemaining
            // 
            this.lblRemaining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRemaining.Location = new System.Drawing.Point(252, 209);
            this.lblRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(204, 49);
            this.lblRemaining.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "remaining";
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(192, 111);
            this.btnStartTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(144, 62);
            this.btnStartTimer.TabIndex = 5;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(24, 74);
            this.btnLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(112, 49);
            this.btnLap.TabIndex = 2;
            this.btnLap.Text = "Lap";
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // btnlapStart
            // 
            this.btnlapStart.Location = new System.Drawing.Point(24, 12);
            this.btnlapStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlapStart.Name = "btnlapStart";
            this.btnlapStart.Size = new System.Drawing.Size(112, 49);
            this.btnlapStart.TabIndex = 1;
            this.btnlapStart.Text = "Start";
            this.btnlapStart.Click += new System.EventHandler(this.btnlapStart_Click);
            // 
            // spinMin
            // 
            this.spinMin.Location = new System.Drawing.Point(156, 25);
            this.spinMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spinMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spinMin.Name = "spinMin";
            this.spinMin.Size = new System.Drawing.Size(108, 44);
            this.spinMin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes";
            // 
            // spinSec
            // 
            this.spinSec.Location = new System.Drawing.Point(408, 25);
            this.spinSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spinSec.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spinSec.Name = "spinSec";
            this.spinSec.Size = new System.Drawing.Size(108, 44);
            this.spinSec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seconds";
            // 
            // lblLapTimer
            // 
            this.lblLapTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblLapTimer.Location = new System.Drawing.Point(156, 12);
            this.lblLapTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLapTimer.Name = "lblLapTimer";
            this.lblLapTimer.Size = new System.Drawing.Size(348, 62);
            this.lblLapTimer.TabIndex = 5;
            // 
            // txtLaps
            // 
            this.txtLaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLaps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLaps.Location = new System.Drawing.Point(156, 86);
            this.txtLaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLaps.Multiline = true;
            this.txtLaps.Name = "txtLaps";
            this.txtLaps.ReadOnly = true;
            this.txtLaps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLaps.Size = new System.Drawing.Size(347, 196);
            this.txtLaps.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(24, 135);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 49);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblLapTimer);
            this.tabPage2.Controls.Add(this.txtLaps);
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.btnLap);
            this.tabPage2.Controls.Add(this.btnlapStart);
            this.tabPage2.Location = new System.Drawing.Point(8, 51);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(524, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Laps";
            // 
            // lblSecs
            // 
            this.lblSecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecs.Location = new System.Drawing.Point(276, 25);
            this.lblSecs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecs.Name = "lblSecs";
            this.lblSecs.Size = new System.Drawing.Size(204, 62);
            this.lblSecs.TabIndex = 2;
            this.lblSecs.Click += new System.EventHandler(this.lblSecs_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(60, 111);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(420, 62);
            this.lblDate.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTime.Location = new System.Drawing.Point(60, 25);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(180, 62);
            this.lblTime.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSecs);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Location = new System.Drawing.Point(8, 51);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(524, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clock";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblRemaining);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnStartTimer);
            this.tabPage3.Controls.Add(this.spinMin);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.spinSec);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(8, 51);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(524, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Timer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(166, 128);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // CountDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 638);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CountDownForm";
            this.Text = "Count Down";
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSec)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Timer tmrLaps;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Timer tmrQuit;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Button btnlapStart;
        private System.Windows.Forms.NumericUpDown spinMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spinSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLapTimer;
        private System.Windows.Forms.TextBox txtLaps;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSecs;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

