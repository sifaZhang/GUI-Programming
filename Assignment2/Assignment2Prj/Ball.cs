using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    class Ball
    {
        /// <summary>
        /// Your Ball class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox picBall;
        private int verticalSpeed, horizontalSpeed;

        public Ball(PictureBox picBall, int verticalSpeed, int horizontalSpeed)
        {
            this.picBall = picBall;
            this.verticalSpeed = verticalSpeed;
            this.horizontalSpeed = horizontalSpeed;
        }
        
        public Rectangle GetRectangle()
        {
            return new Rectangle(picBall.Left, picBall.Top, picBall.Width, picBall.Height);
        }

        public void ChangeDirectionVertical()
        {
            verticalSpeed = -verticalSpeed;
        }

        public void OnTimner()
        {
            // Move the ball
            picBall.Left += horizontalSpeed;
            picBall.Top += verticalSpeed;
            // Check for collision with left or right walls
            if (picBall.Left <= 0 || picBall.Right >= picBall.Parent.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed; // Reverse horizontal direction
            }
        }
    }
}
