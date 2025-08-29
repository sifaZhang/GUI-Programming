namespace Kaioordinate
{
    partial class calenderFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calenderFrm));
            this.calendarEvent = new System.Windows.Forms.MonthCalendar();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnToday = new FontAwesome.Sharp.IconButton();
            this.txtboxEvents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calendarEvent
            // 
            this.calendarEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarEvent.Location = new System.Drawing.Point(24, 21);
            this.calendarEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calendarEvent.Name = "calendarEvent";
            this.calendarEvent.TabIndex = 0;
            this.calendarEvent.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarEvent_DateSelected);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 80;
            this.btnReturn.Location = new System.Drawing.Point(337, 235);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 134);
            this.btnReturn.TabIndex = 75;
            this.btnReturn.Text = "\r\n\r\n\r\n\r\n\r\nRETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnToday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.IconChar = FontAwesome.Sharp.IconChar.Th;
            this.btnToday.IconColor = System.Drawing.Color.Black;
            this.btnToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToday.IconSize = 80;
            this.btnToday.Location = new System.Drawing.Point(91, 235);
            this.btnToday.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(140, 134);
            this.btnToday.TabIndex = 77;
            this.btnToday.Text = "\r\n\r\n\r\n\r\n\r\nToday";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // txtboxEvents
            // 
            this.txtboxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEvents.Location = new System.Drawing.Point(271, 21);
            this.txtboxEvents.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtboxEvents.Multiline = true;
            this.txtboxEvents.Name = "txtboxEvents";
            this.txtboxEvents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxEvents.Size = new System.Drawing.Size(282, 180);
            this.txtboxEvents.TabIndex = 78;
            // 
            // calenderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(579, 402);
            this.Controls.Add(this.txtboxEvents);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.calendarEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "calenderFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calender";
            this.Load += new System.EventHandler(this.calenderFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarEvent;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnToday;
        private System.Windows.Forms.TextBox txtboxEvents;
    }
}