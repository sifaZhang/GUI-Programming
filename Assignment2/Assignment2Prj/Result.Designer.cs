namespace Assignment2Prj
{
    partial class Result
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnQuit = new FontAwesome.Sharp.IconButton();
            this.btnStart = new FontAwesome.Sharp.IconButton();
            this.btnRanking = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(69, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 27);
            this.lblResult.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnQuit.IconColor = System.Drawing.Color.Black;
            this.btnQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuit.Location = new System.Drawing.Point(369, 291);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(140, 120);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "\r\n\r\n\r\nQuit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnStart.IconColor = System.Drawing.Color.Black;
            this.btnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStart.Location = new System.Drawing.Point(211, 291);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 120);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "\r\n\r\n\r\nReplay";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRanking.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnRanking.IconColor = System.Drawing.Color.Black;
            this.btnRanking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRanking.Location = new System.Drawing.Point(53, 291);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(140, 120);
            this.btnRanking.TabIndex = 7;
            this.btnRanking.Text = "\r\n\r\n\r\nRanking";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private FontAwesome.Sharp.IconButton btnRanking;
        private FontAwesome.Sharp.IconButton btnStart;
        private FontAwesome.Sharp.IconButton btnQuit;
    }
}