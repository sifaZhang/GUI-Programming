namespace DrawExample
{
    partial class Form1
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
            this.button5 = new System.Windows.Forms.Button();
            this.pnlGDI = new System.Windows.Forms.Panel();
            this.btnDrawOnOff = new System.Windows.Forms.Button();
            this.btnRectangles = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(686, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 32);
            this.button5.TabIndex = 15;
            this.button5.Text = "Draw Temp";
            this.button5.Click += new System.EventHandler(this.btnDrawTemp);
            // 
            // pnlGDI
            // 
            this.pnlGDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlGDI.Location = new System.Drawing.Point(684, 36);
            this.pnlGDI.Name = "pnlGDI";
            this.pnlGDI.Size = new System.Drawing.Size(312, 320);
            this.pnlGDI.TabIndex = 14;
            this.pnlGDI.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGDI_Paint);
            // 
            // btnDrawOnOff
            // 
            this.btnDrawOnOff.Location = new System.Drawing.Point(550, 468);
            this.btnDrawOnOff.Name = "btnDrawOnOff";
            this.btnDrawOnOff.Size = new System.Drawing.Size(128, 32);
            this.btnDrawOnOff.TabIndex = 13;
            this.btnDrawOnOff.Text = "Draw On/Off";
            this.btnDrawOnOff.Click += new System.EventHandler(this.btnDrawOnOff_Click);
            // 
            // btnRectangles
            // 
            this.btnRectangles.Location = new System.Drawing.Point(422, 468);
            this.btnRectangles.Name = "btnRectangles";
            this.btnRectangles.Size = new System.Drawing.Size(120, 32);
            this.btnRectangles.TabIndex = 12;
            this.btnRectangles.Text = "Rectangles";
            this.btnRectangles.Click += new System.EventHandler(this.btnRectangles_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.Location = new System.Drawing.Point(294, 468);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(120, 32);
            this.btnElipse.TabIndex = 11;
            this.btnElipse.Text = "Elipses";
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(166, 468);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(120, 32);
            this.btnLine.TabIndex = 10;
            this.btnLine.Text = "Line";
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 606);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pnlGDI);
            this.Controls.Add(this.btnDrawOnOff);
            this.Controls.Add(this.btnRectangles);
            this.Controls.Add(this.btnElipse);
            this.Controls.Add(this.btnLine);
            this.Name = "Form1";
            this.Text = "Draw Example";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlGDI;
        private System.Windows.Forms.Button btnDrawOnOff;
        private System.Windows.Forms.Button btnRectangles;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Button btnLine;
    }
}

