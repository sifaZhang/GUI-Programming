//Author: Sifa Zhang
//Studeng ID: 1606796
//Date: 2025/10/13

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
    public class Mannger
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
        private SoundPlayer hitStretchPlayer = new SoundPlayer(Properties.Resources.scratch);
        private SoundPlayer hitShinkPlayer = new SoundPlayer(Properties.Resources.narrow);
        private SoundPlayer hit1Player = new SoundPlayer(Properties.Resources.hit1);
        private SoundPlayer hitBombPlayer = new SoundPlayer(Properties.Resources.explosion);
        private SoundPlayer hit10Player = new SoundPlayer(Properties.Resources.hitBrick);
        private SoundPlayer hit20Player = new SoundPlayer(Properties.Resources.nice);
        private SoundPlayer hit30Player = new SoundPlayer(Properties.Resources.yeah);

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="bricks"></param>
        /// <param name="ball"></param>
        /// <param name="paddle"></param>
        public Mannger(Bricks bricks, Ball ball, Paddle paddle)
        {
            try
            {
                //set the initial position of the ball
                ball.SetPosition(paddle.GetPosition().X + paddle.GetWidth() / 2, paddle.GetPosition().Y - paddle.GetHeight() - 2);
                this.bricks = bricks;
                this.balls.Add(ball);
                this.paddle = paddle;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Initialization failed: {ex.Message}", "Null Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing Paddle: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally rethrow or log
                throw;
            }
        }

        /// <summary>
        /// handle the timer event
        /// </summary>
        public void OnTimer()
        {
            //iterate through all balls
            foreach (var currentBall in balls.ToList())
            {
                //check if the ball is lost
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
                //collision with paddle
                if (paddle.IsCollided(ballRect, out verticalCollision))
                {
                    //play sound
                    hit2Player.Play();

                    //move the ball up to avoid multiple collision detection
                    if (verticalCollision)
                    {
                        currentBall.MoveUp();
                    }
                    else
                    {
                        //collision with the left or right side of the paddle
                        currentBall.ChangeDirectionHorizontal();
                    }
                }
                //collision with bricks
                else if (bricks.CheckCollision(ballRect, out score, out collisionType, out verticalCollision))
                {
                    //update score
                    currentScore += score;

                    //change ball direction
                    if (verticalCollision)
                    {
                        currentBall.ChangeDirectionVertical();
                    }
                    else
                    {
                        currentBall.ChangeDirectionHorizontal();
                    }

                    //handle different type of bricks
                    if (collisionType == Brick.BrickType.extra)
                    {
                        //play sound
                        hit1Player.Play();

                        //add a new ball
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
                    //expand paddle
                    else if (collisionType == Brick.BrickType.stretch)
                    {
                        //play expand sound
                        hitStretchPlayer.Play();

                        //expand the paddle
                        paddle.Expand();
                    }
                    //shrink paddle
                    else if (collisionType == Brick.BrickType.Shrink)
                    {
                        //play shrink sound
                        hitShinkPlayer.Play();

                        //shrink the paddle
                        paddle.Shrink();
                    }
                    //hit bomb
                    else if (collisionType == Brick.BrickType.Bomb)
                    {
                        //play bomb sound
                        hitBombPlayer.Play();
                    }
                    //hit Score20 brick
                    else if (collisionType == Brick.BrickType.Score20)
                    {
                        //play 20 sound
                        hit20Player.Play();
                    }
                    //hit Score30 brick
                    else if (collisionType == Brick.BrickType.Score30)
                    {
                        //play 30 sound
                        hit30Player.Play();
                    }
                    else
                    {
                        //play 10 sound
                        hit10Player.Play();
                    }
                }

                currentBall.OnTimner();
            }
        }

        /// <summary>
        /// get the current score
        /// </summary>
        /// <returns></returns>
        public int GetCurrentScore()
        {
            return currentScore;
        }

        /// <summary>
        /// determine if the game is over
        /// </summary>
        /// <returns></returns>
        public bool IsGameOver()
        {
            return balls.Count == 0;
        }

        /// <summary>
        /// determine if the game is win
        /// </summary>
        /// <returns></returns>
        public bool IsGameWin()
        {
            return bricks.IsAllBricksBreakout();
        }


        ////////for unit test purpose only////////
        /// <summary>
        /// get the list of balls
        /// </summary>
        /// <returns></returns>
        public List<Ball> GetBalls()
        {
            return balls;
        }

        /// <summary>
        /// get the bricks
        /// </summary>
        /// <returns></returns>
        public Bricks GetBricks()
        {
            return bricks;
        }
    }
}
