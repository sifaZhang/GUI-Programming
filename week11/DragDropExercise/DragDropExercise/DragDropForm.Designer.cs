namespace DragDropExercise
{
    partial class DragDropForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.timer2 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(36, 85);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 300);
            this.listBox1.TabIndex = 12;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 454);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 108);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Win";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(884, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lose";
            // 
            // lblWin
            // 
            this.lblWin.AllowDrop = true;
            this.lblWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblWin.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(420, 162);
            this.lblWin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(336, 246);
            this.lblWin.TabIndex = 8;
            this.lblWin.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblWin_DragDrop);
            this.lblWin.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblWin_DragEnter);
            // 
            // lblLose
            // 
            this.lblLose.AllowDrop = true;
            this.lblLose.BackColor = System.Drawing.Color.LightCoral;
            this.lblLose.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(788, 162);
            this.lblLose.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(368, 246);
            this.lblLose.TabIndex = 7;
            this.lblLose.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblLose_DragDrop);
            this.lblLose.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblLose_DragEnter);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000D;
            this.timer1.SynchronizingObject = this;
            // 
            // timer2
            // 
            this.timer2.Interval = 2000D;
            this.timer2.SynchronizingObject = this;
            // 
            // DragDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 612);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblLose);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DragDropForm";
            this.Text = "Drag & Drop Exercise";
            this.Load += new System.EventHandler(this.DragDropForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Timers.Timer timer1;
        private System.Timers.Timer timer2;
    }
}

