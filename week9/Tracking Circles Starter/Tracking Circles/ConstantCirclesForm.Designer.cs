namespace Tracking_Circles
{
    partial class ConstantCirclesForm
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
            this.btnShowForm3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowForm3
            // 
            this.btnShowForm3.Location = new System.Drawing.Point(184, 430);
            this.btnShowForm3.Name = "btnShowForm3";
            this.btnShowForm3.Size = new System.Drawing.Size(256, 40);
            this.btnShowForm3.TabIndex = 4;
            this.btnShowForm3.Text = "Form 3 Storing the results";
            this.btnShowForm3.Click += new System.EventHandler(this.btnShowForm3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(176, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Try clicking on the form several times then drag the form half off the page and b" +
    "ack";
            // 
            // ConstantCirclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 485);
            this.Controls.Add(this.btnShowForm3);
            this.Controls.Add(this.label1);
            this.Name = "ConstantCirclesForm";
            this.Text = "ConstantCirclesForm";
            this.Load += new System.EventHandler(this.ConstantCirclesForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConstantCirclesForm_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConstantCirclesForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm3;
        private System.Windows.Forms.Label label1;
    }
}