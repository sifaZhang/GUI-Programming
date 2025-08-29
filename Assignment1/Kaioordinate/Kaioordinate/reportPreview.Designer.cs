namespace Kaioordinate
{
    partial class reportPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportPreview));
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnEventReport = new FontAwesome.Sharp.IconButton();
            this.btnParticipationRreport = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 80;
            this.btnReturn.Location = new System.Drawing.Point(396, 29);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(156, 144);
            this.btnReturn.TabIndex = 75;
            this.btnReturn.Text = "\r\n\r\n\r\n\r\n\r\nRETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEventReport
            // 
            this.btnEventReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEventReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnEventReport.IconColor = System.Drawing.Color.Black;
            this.btnEventReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEventReport.IconSize = 80;
            this.btnEventReport.Location = new System.Drawing.Point(38, 29);
            this.btnEventReport.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEventReport.Name = "btnEventReport";
            this.btnEventReport.Size = new System.Drawing.Size(156, 144);
            this.btnEventReport.TabIndex = 76;
            this.btnEventReport.Text = "\r\n\r\n\r\n\r\n\r\nGENERATE\r\nREPORT";
            this.btnEventReport.UseVisualStyleBackColor = false;
            this.btnEventReport.Click += new System.EventHandler(this.btnEventReport_Click);
            // 
            // btnParticipationRreport
            // 
            this.btnParticipationRreport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnParticipationRreport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipationRreport.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnParticipationRreport.IconColor = System.Drawing.Color.Black;
            this.btnParticipationRreport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParticipationRreport.IconSize = 80;
            this.btnParticipationRreport.Location = new System.Drawing.Point(216, 29);
            this.btnParticipationRreport.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnParticipationRreport.Name = "btnParticipationRreport";
            this.btnParticipationRreport.Size = new System.Drawing.Size(156, 144);
            this.btnParticipationRreport.TabIndex = 77;
            this.btnParticipationRreport.Text = "\r\n\r\n\r\n\r\n\r\nPARTICIPATION\r\nREPORT";
            this.btnParticipationRreport.UseVisualStyleBackColor = false;
            this.btnParticipationRreport.Click += new System.EventHandler(this.btnParticipationRreport_Click);
            // 
            // reportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 208);
            this.Controls.Add(this.btnParticipationRreport);
            this.Controls.Add(this.btnEventReport);
            this.Controls.Add(this.btnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "reportPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Preview";
            this.Load += new System.EventHandler(this.reportPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnEventReport;
        private FontAwesome.Sharp.IconButton btnParticipationRreport;
    }
}