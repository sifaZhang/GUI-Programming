namespace EventPlay
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
            this.components = new System.ComponentModel.Container();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNumPlus = new System.Windows.Forms.TextBox();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOnMove = new System.Windows.Forms.Button();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Yellow;
            this.lblResult.Location = new System.Drawing.Point(812, 338);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(208, 46);
            this.lblResult.TabIndex = 11;
            // 
            // txtNumPlus
            // 
            this.txtNumPlus.AcceptsReturn = true;
            this.txtNumPlus.Location = new System.Drawing.Point(444, 323);
            this.txtNumPlus.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumPlus.Name = "txtNumPlus";
            this.txtNumPlus.Size = new System.Drawing.Size(236, 31);
            this.txtNumPlus.TabIndex = 10;
            this.txtNumPlus.Text = "0";
            this.txtNumPlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPlus_KeyPress);
            // 
            // txtNumbers
            // 
            this.txtNumbers.AcceptsReturn = true;
            this.txtNumbers.Location = new System.Drawing.Point(444, 185);
            this.txtNumbers.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(236, 31);
            this.txtNumbers.TabIndex = 9;
            this.txtNumbers.Text = "0";
            this.txtNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(60, 431);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 92);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOnMove
            // 
            this.btnOnMove.Location = new System.Drawing.Point(60, 308);
            this.btnOnMove.Margin = new System.Windows.Forms.Padding(6);
            this.btnOnMove.Name = "btnOnMove";
            this.btnOnMove.Size = new System.Drawing.Size(176, 92);
            this.btnOnMove.TabIndex = 7;
            this.btnOnMove.Text = "Click Me";
            this.btnOnMove.Click += new System.EventHandler(this.btnOnMove_Click);
            this.btnOnMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOnMove_MouseMove);
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(60, 185);
            this.btnClickMe.Margin = new System.Windows.Forms.Padding(6);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(176, 92);
            this.btnClickMe.TabIndex = 6;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            this.btnClickMe.MouseEnter += new System.EventHandler(this.btnClickMe_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 710);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumPlus);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOnMove);
            this.Controls.Add(this.btnClickMe);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Some events other than the Click event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNumPlus;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOnMove;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Timer timer1;
    }
}

