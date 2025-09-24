using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
        private Paddle paddle;
        private int currentScore = 0;
        private List<Ball> balls = new List<Ball>();
        private SoundPlayer hit2Player = new SoundPlayer(Properties.Resources.hit2);
        private SoundPlayer hitStetchPlayer = new SoundPlayer(Properties.Resources.yeah);
        private SoundPlayer hit1Player = new SoundPlayer(Properties.Resources.hit1);
        private SoundPlayer hitBombPlayer = new SoundPlayer(Properties.Resources.explosion);
        private SoundPlayer hit10Player = new SoundPlayer(Properties.Resources.hitBrick);
        private SoundPlayer hit20Player = new SoundPlayer(Properties.Resources.nice);
        private SoundPlayer hit30Player = new SoundPlayer(Properties.Resources.applause);


        public Mannger(Bricks bricks, Ball ball, Paddle paddle)
        {
            ball.SetPosition(paddle.GetPosition().X + paddle.GetWidth() / 2,  paddle.GetPosition().Y - paddle.GetHeight() - 2);
            this.bricks = bricks;
            this.balls.Add(ball);
            this.paddle = paddle;
        }

        public void OnTimer()
        {
            foreach (var currentBall in balls.ToList())
            {
                if (currentBall.IsLost())
                {
                    balls.Remove(currentBall);
                    continue;
                }

                //determine the collision with paddle
                Rectangle ballRect = currentBall.GetRectangle();
                int score = 0;
                bool verticalCollision = true;
                Brick.BrickType collisionType = Brick.BrickType.Normal;
                if (paddle.IsCollided(ballRect, out verticalCollision))
                {
                    hit2Player.Play();

                    if (verticalCollision)
                    {
                        currentBall.MoveUp();
                    }
                    else
                    {
                        currentBall.ChangeDirectionHorizontal();
                    }
                }
                else if (bricks.CheckCollision(ballRect, out score, out collisionType, out verticalCollision))
                {
                    currentScore += score;

                    if (verticalCollision)
                    {
                        currentBall.ChangeDirectionVertical();
                    }
                    else
                    {
                        currentBall.ChangeDirectionHorizontal();
                    }

                    if (collisionType == Brick.BrickType.extra)
                    {
                        hit1Player.Play();

                        if (balls.Count > 0)
                        {
                            balls[0].GetSpeed(out int verticalSpeed, out int horizontalSpeed);
                            verticalSpeed = verticalSpeed > 0 ? verticalSpeed * -1 : verticalSpeed;
                            balls.Add(new Ball(null, verticalSpeed, horizontalSpeed));
                            balls.Last().AddToContainer(balls[0].GetParent());
                            balls.Last().SetPosition(paddle.GetPosition().X + paddle.GetWidth() / 2, paddle.GetPosition().Y - paddle.GetHeight() - 2);
                        }
                        else
                        {
                            //game over
                        }
                    }
                    else if (collisionType == Brick.BrickType.Stetch)
                    {
                        hitStetchPlayer.Play();

                        paddle.Expand();
                    }
                    else if (collisionType == Brick.BrickType.Bomb)
                    {
                        hitBombPlayer.Play();
                    }
                    else if (collisionType == Brick.BrickType.Score20)
                    {
                        hit20Player.Play();
                    }
                    else if (collisionType == Brick.BrickType.Score30)
                    {
                        hit30Player.Play();
                    }
                    else
                    {
                        hit10Player.Play();
                    }
                }

                currentBall.OnTimner();
            }
        }

        public int GetCurrentScore()
        {
            return currentScore;
        }

        public bool IsGameOver()
        {
            return balls.Count == 0;
        }

        public bool IsGameWin()
        {
            return bricks.IsAllBricksBreakout();
        }
    }
}
