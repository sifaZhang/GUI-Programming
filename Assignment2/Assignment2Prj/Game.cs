//Author: Sifa Zhang
//Studeng ID: 1606796
//Date: 2025/10/13

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
        private bool isDragging;


        //default game class
        public Game()
        {
            InitializeComponent();

            //Adjust these numbers 
            this.verticalSpeed = -2 - 3 * PublicDatas.currentLevel;
            this.horizontalSpeed = 2 + 3 * PublicDatas.currentLevel;
            this.bricksRows = 8;
            this.bricksCols = 12;
            this.paddleSpeed = 9;

            //Create objects 
            this.ball = new Ball(picBall, verticalSpeed, horizontalSpeed);
            this.paddle = new Paddle(picPaddle, paddleSpeed);
            this.bricks = new Bricks(bricksRows, bricksCols);

            this.manager = new Mannger(bricks, ball, paddle);
            this.bricks.AddToContainer(this);

            isDragging = false;
        }

        /// <summary>
        /// start the timer when loading the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;

            lblLevel.Text = "Level: " + PublicDatas.currentLevel.ToString();
        }

        /// <summary>
        /// handle the paint event of the paddle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picPaddle_Paint(object sender, PaintEventArgs e)
        {
            paddle.Paddle_Paint(sender, e);
        }

        /// <summary>
        /// handle the key event
        /// </summary>
        /// <param name="key"></param>
        private void HandleKey(Keys key)
        {
            if (!timer.Enabled) return;

            paddle.HandleKey(key);
        }

        /// <summary>
        /// handle the key down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKey(e.KeyCode);
        }

        /// <summary>
        /// handle the timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            //call the manager to handle the timer event
            manager.OnTimer();

            //update the score
            lblScore.Text = "Score: " + manager.GetCurrentScore().ToString();

            //check if the game is over or win
            bool bOver = false;
            if (manager.IsGameOver())
            {
                bOver = true;
                SoundPlayer player = new SoundPlayer(Properties.Resources.death);
                player.Play();
            }

            //check if the game is win
            bool bWin = false;
            if (manager.IsGameWin())
            {
                bWin = true;
                SoundPlayer player = new SoundPlayer(Properties.Resources.goodjob);
                player.Play();
            }

            //if over or win, stop the timer and show the result form
            if (bOver || bWin)
            {
                timer.Stop();

                PublicDatas.currentScore += manager.GetCurrentScore();
                PublicDatas.UpdateScores();

                this.Close();
                this.Dispose();

                //show the result form
                Result result = new Result(bWin);
                result.Show();
            }
        }

        /// <summary>
        /// handle the pause button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// handle the command key event
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            HandleKey(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// handle the mouse move event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer.Enabled) return;

            if (isDragging)
            {
                paddle.MouseMove(sender, e);
            }
        }

        /// <summary>
        /// handle the mouse down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        /// <summary>
        /// handle the mouse up event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
