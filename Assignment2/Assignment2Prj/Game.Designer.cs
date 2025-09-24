namespace Assignment2Prj
{
    partial class Game
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnPause = new FontAwesome.Sharp.IconButton();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(8, 494);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPause.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.btnPause.IconColor = System.Drawing.Color.Black;
            this.btnPause.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPause.IconSize = 24;
            this.btnPause.Location = new System.Drawing.Point(860, 487);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(97, 36);
            this.btnPause.TabIndex = 5;
            this.btnPause.TabStop = false;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Silver;
            this.picPaddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaddle.Location = new System.Drawing.Point(493, 466);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(109, 19);
            this.picPaddle.TabIndex = 2;
            this.picPaddle.TabStop = false;
            this.picPaddle.Paint += new System.Windows.Forms.PaintEventHandler(this.picPaddle_Paint);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = global::Assignment2Prj.Properties.Resources.ball;
            this.picBall.Location = new System.Drawing.Point(539, 424);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(18, 18);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 528);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picPaddle);
            this.Controls.Add(this.picBall);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakout";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.Label lblScore;
        private FontAwesome.Sharp.IconButton btnPause;
    }
}

