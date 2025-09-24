using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
        private bool isLost;

        private static SoundPlayer player = new SoundPlayer(Properties.Resources.hitWall);

        public Ball(PictureBox picBall, int verticalSpeed, int horizontalSpeed)
        {
            if (picBall == null)
            {
                this.picBall = new PictureBox();
            }
            else
            {
                this.picBall = picBall;
            }

            this.picBall.Width = 18;
            this.picBall.Height = 18;
            this.picBall.Left = 550;
            this.picBall.Top = 400;
            this.picBall.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picBall.Image = Properties.Resources.ball;

            this.verticalSpeed = verticalSpeed;
            this.horizontalSpeed = horizontalSpeed;

            isLost = false;
        }

        public void SetPosition(int left, int top)
        {
            picBall.Left = left;
            picBall.Top = top;
        }

        public bool IsLost()
        {
            return isLost;
        }
        public void AddToContainer(Control container)
        {
            container.Controls.Add(picBall);
        }

        public void RemoveFromContainer()
        {
            if (picBall.Parent != null)
            {
                picBall.Parent.Controls.Remove(picBall);
            }
        }

        public void GetSpeed(out int verticalSpeed, out int horizontalSpeed)
        {
            horizontalSpeed = this.horizontalSpeed;
            verticalSpeed = this.verticalSpeed;
        }
        
        public Rectangle GetRectangle()
        {
            return new Rectangle(picBall.Left, picBall.Top, picBall.Width, picBall.Height);
        }

        public void ChangeDirectionVertical()
        {
            verticalSpeed = -verticalSpeed;
        }

        public void ChangeDirectionHorizontal()
        {
            horizontalSpeed = -horizontalSpeed;
        }

        public Control GetParent()
        {
            return picBall.Parent;
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
                player.Play();
            }

            // Check for collision with top wall
            if (picBall.Top <= 0)
            {
                verticalSpeed = -verticalSpeed; // Reverse vertical direction
                player.Play();
            }

            // Check if the ball goes below the bottom edge (missed by paddle)
            if (picBall.Top >= picBall.Parent.ClientSize.Height)
            {
                isLost = true;
                RemoveFromContainer();
            }
        }
    }
}
