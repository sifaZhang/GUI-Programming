namespace week2
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxName1 = new System.Windows.Forms.TextBox();
            this.txtBoxName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Form1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Form2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxName1
            // 
            this.txtBoxName1.Location = new System.Drawing.Point(203, 276);
            this.txtBoxName1.Name = "txtBoxName1";
            this.txtBoxName1.Size = new System.Drawing.Size(164, 31);
            this.txtBoxName1.TabIndex = 2;
            // 
            // txtBoxName2
            // 
            this.txtBoxName2.Location = new System.Drawing.Point(453, 276);
            this.txtBoxName2.Name = "txtBoxName2";
            this.txtBoxName2.Size = new System.Drawing.Size(151, 31);
            this.txtBoxName2.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxName2);
            this.Controls.Add(this.txtBoxName1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoxName2;
        public System.Windows.Forms.TextBox txtBoxName1;
    }
}