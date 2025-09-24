using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    public partial class Game : Form
    {
        private Bricks bricks;
        private Ball ball;
        private Paddle paddle;
        private Mannger manager;

        private int verticalSpeed;
        private int horizontalSpeed;
        private int bricksRows;
        private int bricksCols;
        private int paddleSpeed;

        public Game()
        {
            InitializeComponent();

            //Adjust these numbers 
            this.verticalSpeed = -4;
            this.horizontalSpeed = 4;
            this.bricksRows = 8;
            this.bricksCols = 12;
            this.paddleSpeed = 9;

            //Create objects 
            this.ball = new Ball(picBall, verticalSpeed, horizontalSpeed);
            this.paddle = new Paddle(picPaddle, paddleSpeed);
            this.bricks = new Bricks(bricksRows, bricksCols);

            //MessageBox.Show(this.Width.ToString() + ", " +this.ClientSize.Width.ToString());
            this.manager = new Mannger(bricks, ball, paddle);
            this.bricks.AddToContainer(this);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void picPaddle_Paint(object sender, PaintEventArgs e)
        {
            paddle.Paddle_Paint(sender, e);
        }

        private void HandleKey(Keys key)
        {
            if (!timer.Enabled) return;

            switch (key)
            {
                case Keys.Left:
                    paddle.MoveLeft();
                    break;
                case Keys.Right:
                    paddle.MoveRight();
                    break;
                default:
                    break;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKey(e.KeyCode);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            manager.OnTimer();

            lblScore.Text = "Score: " + manager.GetCurrentScore().ToString();

            bool bOver = false;
            if (manager.IsGameOver())
            {
                bOver = true;
                SoundPlayer player = new SoundPlayer(Properties.Resources.death);
                player.Play();
            }

            if(manager.IsGameWin())
            {
                bOver = true;
                SoundPlayer player = new SoundPlayer(Properties.Resources.goodjob);
                player.Play();
            }

            if (bOver)
            {
                timer.Stop();

                PublicDatas.currentScore = manager.GetCurrentScore();
                PublicDatas.UpdateScores();

                this.Close();
                this.Dispose();

                Result result = new Result();
                result.Show();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                btnPause.IconChar = FontAwesome.Sharp.IconChar.Play;
                timer.Enabled = false;
            }
            else
            {
                btnPause.IconChar = FontAwesome.Sharp.IconChar.Pause;
                timer.Enabled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            HandleKey(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
