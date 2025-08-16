namespace Kaioordinate
{
    partial class MianFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MianFrm));
            this.picBoxBarLogo = new System.Windows.Forms.PictureBox();
            this.btnKai = new FontAwesome.Sharp.IconButton();
            this.btnEvent = new FontAwesome.Sharp.IconButton();
            this.btnWhanau = new FontAwesome.Sharp.IconButton();
            this.btnLocation = new FontAwesome.Sharp.IconButton();
            this.btnRegistration = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnCalender = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxBarLogo
            // 
            this.picBoxBarLogo.BackColor = System.Drawing.Color.White;
            this.picBoxBarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxBarLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxBarLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBarLogo.Image")));
            this.picBoxBarLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxBarLogo.Name = "picBoxBarLogo";
            this.picBoxBarLogo.Size = new System.Drawing.Size(1500, 449);
            this.picBoxBarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBarLogo.TabIndex = 0;
            this.picBoxBarLogo.TabStop = false;
            // 
            // btnKai
            // 
            this.btnKai.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKai.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnKai.IconColor = System.Drawing.Color.Black;
            this.btnKai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKai.IconSize = 150;
            this.btnKai.Location = new System.Drawing.Point(80, 510);
            this.btnKai.Name = "btnKai";
            this.btnKai.Size = new System.Drawing.Size(280, 280);
            this.btnKai.TabIndex = 1;
            this.btnKai.Text = "\r\n\r\n\r\n\r\nKAI";
            this.btnKai.UseVisualStyleBackColor = false;
            this.btnKai.Click += new System.EventHandler(this.btnKai_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEvent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnEvent.IconColor = System.Drawing.Color.Black;
            this.btnEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvent.IconSize = 150;
            this.btnEvent.Location = new System.Drawing.Point(429, 510);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(280, 280);
            this.btnEvent.TabIndex = 2;
            this.btnEvent.Text = "\r\n\r\n\r\n\r\n\r\nEVENTS";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnWhanau
            // 
            this.btnWhanau.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnWhanau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhanau.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnWhanau.IconColor = System.Drawing.Color.Black;
            this.btnWhanau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWhanau.IconSize = 150;
            this.btnWhanau.Location = new System.Drawing.Point(778, 510);
            this.btnWhanau.Name = "btnWhanau";
            this.btnWhanau.Size = new System.Drawing.Size(280, 280);
            this.btnWhanau.TabIndex = 3;
            this.btnWhanau.Text = "\r\n\r\n\r\n\r\n\r\nWHᾹNAU";
            this.btnWhanau.UseVisualStyleBackColor = false;
            this.btnWhanau.Click += new System.EventHandler(this.btnWhanau_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLocation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.IconChar = FontAwesome.Sharp.IconChar.MapMarked;
            this.btnLocation.IconColor = System.Drawing.Color.Black;
            this.btnLocation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLocation.IconSize = 150;
            this.btnLocation.Location = new System.Drawing.Point(1127, 510);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(280, 280);
            this.btnLocation.TabIndex = 4;
            this.btnLocation.Text = "\r\n\r\n\r\n\r\n\r\nLOCATIONS";
            this.btnLocation.UseVisualStyleBackColor = false;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegistration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnRegistration.IconColor = System.Drawing.Color.Black;
            this.btnRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistration.IconSize = 150;
            this.btnRegistration.Location = new System.Drawing.Point(80, 837);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(280, 280);
            this.btnRegistration.TabIndex = 5;
            this.btnRegistration.Text = "\r\n\r\n\r\n\r\n\r\nREGISTRATION";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnReport.IconColor = System.Drawing.Color.Black;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 150;
            this.btnReport.Location = new System.Drawing.Point(429, 837);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(280, 280);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "\r\n\r\n\r\n\r\n\r\nREPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 150;
            this.btnExit.Location = new System.Drawing.Point(1127, 837);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(280, 280);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "\r\n\r\n\r\n\r\n\r\nEXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalender
            // 
            this.btnCalender.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalender.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnCalender.IconColor = System.Drawing.Color.Black;
            this.btnCalender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalender.IconSize = 150;
            this.btnCalender.Location = new System.Drawing.Point(778, 837);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(280, 280);
            this.btnCalender.TabIndex = 8;
            this.btnCalender.Text = "\r\n\r\n\r\n\r\n\r\nCALENDER";
            this.btnCalender.UseVisualStyleBackColor = false;
            this.btnCalender.Click += new System.EventHandler(this.btnCalender_Click);
            // 
            // MianFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1500, 1161);
            this.Controls.Add(this.btnCalender);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnWhanau);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnKai);
            this.Controls.Add(this.picBoxBarLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MianFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaioordinate - Community event management software";
            this.Load += new System.EventHandler(this.MianFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBarLogo;
        private FontAwesome.Sharp.IconButton btnKai;
        private FontAwesome.Sharp.IconButton btnEvent;
        private FontAwesome.Sharp.IconButton btnWhanau;
        private FontAwesome.Sharp.IconButton btnLocation;
        private FontAwesome.Sharp.IconButton btnRegistration;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnCalender;
    }
}

