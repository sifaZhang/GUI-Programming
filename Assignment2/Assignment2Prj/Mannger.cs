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

        public Mannger(Bricks bricks, Ball ball, Paddle paddle)
        {
            this.bricks = bricks;
            this.ball = ball;
            this.paddle = paddle;
        }

        public void OnTimer()
        {
            //determine the collision with paddle
            Rectangle ballRect = ball.GetRectangle();
            int score = 0;
            if (paddle.IsCollided(ballRect) || bricks.IsCollided(ballRect, out score))
            {
                // 碰撞发生
                ball.ChangeDirectionVertical();

                currentScore += score;
            } 

            ball.OnTimner();
        }

        public int GetCurrentScore()
        {
            return currentScore;
        }
    }
}
