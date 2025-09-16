using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    public partial class Game : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// 

        private Bricks bricks;
        private Ball ball;
        private Paddle paddle;
        private Mannger mannger;

        private int verticalSpeed;
        private int horizontalSpeed;
        private int bricksRows;
        private int bricksCols;
        private int paddleSpeed;





        public Game()
        {
            InitializeComponent();
            //Adjust these numbers 
            this.verticalSpeed = -3;
            this.horizontalSpeed = 3;
            this.bricksRows = 8;
            this.bricksCols = 12;
            this.paddleSpeed = 5;

            //Create objects 
            this.ball = new Ball(picBall, verticalSpeed, horizontalSpeed);
            this.paddle = new Paddle(picPaddle, paddleSpeed);
            this.bricks = new Bricks(bricksRows, bricksCols);

            //MessageBox.Show(this.Width.ToString() + ", " +this.ClientSize.Width.ToString());
            this.mannger = new Mannger(bricks, ball, paddle);
            bricks.AddToContainer(this);
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void picPaddle_Paint(object sender, PaintEventArgs e)
        {
            paddle.Paddle_Paint(sender, e);
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
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

        private void timer_Tick(object sender, EventArgs e)
        {
            mannger.OnTimer();

            mannger.GetCurrentScore();
            lblScore.Text = "Score: " + mannger.GetCurrentScore().ToString();
        }
    }
}
