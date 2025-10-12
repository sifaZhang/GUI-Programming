namespace Assignment2Prj
{
    partial class Introduce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduce));
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.btnRanking = new FontAwesome.Sharp.IconButton();
            this.btnStart = new FontAwesome.Sharp.IconButton();
            this.btnQuit = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(350, 502);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 55);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.Location = new System.Drawing.Point(532, 502);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(524, 63);
            this.txtboxName.TabIndex = 2;
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.Location = new System.Drawing.Point(26, 33);
            this.lblIntroduction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(1423, 294);
            this.lblIntroduction.TabIndex = 3;
            this.lblIntroduction.Text = resources.GetString("lblIntroduction.Text");
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRanking.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnRanking.IconColor = System.Drawing.Color.Black;
            this.btnRanking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRanking.Location = new System.Drawing.Point(222, 637);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(280, 231);
            this.btnRanking.TabIndex = 6;
            this.btnRanking.Text = "\r\n\r\n\r\nRanking";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnStart.IconColor = System.Drawing.Color.Black;
            this.btnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStart.Location = new System.Drawing.Point(572, 637);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(280, 231);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "\r\n\r\n\r\nStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnQuit.IconColor = System.Drawing.Color.Black;
            this.btnQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuit.Location = new System.Drawing.Point(922, 637);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(280, 231);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "\r\n\r\n\r\nQuit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Introduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 942);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Introduce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblIntroduction;
        private FontAwesome.Sharp.IconButton btnStart;
        private FontAwesome.Sharp.IconButton btnRanking;
        private FontAwesome.Sharp.IconButton btnQuit;
    }
}