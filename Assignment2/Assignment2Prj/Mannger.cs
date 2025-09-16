using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    class Mannger
    {
        /// <summary>
        /// Your Manager class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private Bricks bricks;
        private Ball ball;
        private Paddle paddle;
        private int currentScore = 0;
        private List<Ball> balls = new List<Ball>();

        public Mannger(Bricks bricks, Ball ball, Paddle paddle)
        {
            this.bricks = bricks;
            this.ball = ball;
            this.balls.Add(ball);
            this.paddle = paddle;
        }

        public void OnTimer()
        {
            foreach (var currentBall in balls.ToList())
            {
                //determine the collision with paddle
                Rectangle ballRect = currentBall.GetRectangle();
                int score = 0;
                Bricks.BrickType collisionType = Bricks.BrickType.Normal;
                if (paddle.IsCollided(ballRect))
                {
                    // 碰撞发生
                    currentBall.ChangeDirectionVertical();
                }
                else if (bricks.CheckCollision(ballRect, out score, out collisionType))
                {
                    currentBall.ChangeDirectionVertical();

                    currentScore += score;

                    if (collisionType == Bricks.BrickType.extra)
                    {
                        ball.GetSpeed(out int verticalSpeed, out int horizontalSpeed);
                        PictureBox pb = new PictureBox();
                        pb.Width = 18;
                        pb.Height = 18;
                        pb.Left = 350;
                        pb.Top = 400;
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Image = Properties.Resources.ball;
                        pb.Parent = ball.GetParent();
                        verticalSpeed = verticalSpeed > 0 ? verticalSpeed * -1 : verticalSpeed;
                        balls.Add(new Ball(pb, verticalSpeed, horizontalSpeed));
                    }
                    else if (collisionType == Bricks.BrickType.Stetch)
                    {
                        paddle.Expand();
                    }
                }

                currentBall.OnTimner();
            }
           
        }

        public int GetCurrentScore()
        {
            return currentScore;
        }
    }
}
