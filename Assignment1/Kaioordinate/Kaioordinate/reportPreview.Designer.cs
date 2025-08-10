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
            this.iconButton_reture = new FontAwesome.Sharp.IconButton();
            this.iconButton_report = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconButton_reture
            // 
            this.iconButton_reture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_reture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_reture.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton_reture.IconColor = System.Drawing.Color.Black;
            this.iconButton_reture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_reture.IconSize = 150;
            this.iconButton_reture.Location = new System.Drawing.Point(398, 60);
            this.iconButton_reture.Name = "iconButton_reture";
            this.iconButton_reture.Size = new System.Drawing.Size(280, 301);
            this.iconButton_reture.TabIndex = 75;
            this.iconButton_reture.Text = "\r\n\r\n\r\n\r\n\r\nRETURN";
            this.iconButton_reture.UseVisualStyleBackColor = false;
            this.iconButton_reture.Click += new System.EventHandler(this.iconButton_reture_Click);
            // 
            // iconButton_report
            // 
            this.iconButton_report.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton_report.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_report.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton_report.IconColor = System.Drawing.Color.Black;
            this.iconButton_report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_report.IconSize = 150;
            this.iconButton_report.Location = new System.Drawing.Point(75, 60);
            this.iconButton_report.Name = "iconButton_report";
            this.iconButton_report.Size = new System.Drawing.Size(280, 301);
            this.iconButton_report.TabIndex = 76;
            this.iconButton_report.Text = "\r\n\r\n\r\n\r\n\r\nGENERATE\r\nREPORT";
            this.iconButton_report.UseVisualStyleBackColor = false;
            this.iconButton_report.Click += new System.EventHandler(this.iconButton_report_Click);
            // 
            // reportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 436);
            this.Controls.Add(this.iconButton_report);
            this.Controls.Add(this.iconButton_reture);
            this.Name = "reportPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Preview";
            this.Load += new System.EventHandler(this.reportPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton_reture;
        private FontAwesome.Sharp.IconButton iconButton_report;
    }
}