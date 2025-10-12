//Author: Sifa Zhang
//Studeng ID: 1606796
//Date: 2025/10/13

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    public class Paddle
    {
        /// <summary>
        /// Your Paddle class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox picPaddle;
        private int paddleSpeed;
        private int boxNumber = 6;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="picPaddle"></param>
        /// <param name="paddleSpeed"></param>
        public Paddle(PictureBox picPaddle, int paddleSpeed)
        {
            try
            {
                this.picPaddle = picPaddle;
                this.paddleSpeed = paddleSpeed;
                this.picPaddle.BackColor = Color.Gray; // 设置背景为黑色
                this.picPaddle.Height = 16;
                this.picPaddle.Width = boxNumber * picPaddle.Height;
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
        /// get the position of the paddle
        /// </summary>
        /// <returns></returns>
        virtual public Point GetPosition()
        {
            return new Point(picPaddle.Left, picPaddle.Top);
        }

        /// <summary>
        /// get the width of the paddle
        /// </summary>
        /// <returns></returns>
        virtual public int GetWidth()
        {
            return picPaddle.Width;
        }

        /// <summary>
        /// get the height of the paddle
        /// </summary>
        /// <returns></returns>
        virtual public int GetHeight()
        {
            return picPaddle.Height;
        }

        /// <summary>
        /// move the paddle to left
        /// </summary>
        public void MoveLeft()
        {
            if (picPaddle.Left - paddleSpeed >= 0)
            {
                picPaddle.Left -= paddleSpeed;
            }
            else
            {
                picPaddle.Left = 0;
            }
        }

        /// <summary>
        /// move the paddle to right
        /// </summary>
        public void MoveRight()
        {
            if (picPaddle.Right + paddleSpeed <= picPaddle.Parent.ClientSize.Width)
            {
                picPaddle.Left += paddleSpeed;
            }
            else
            {
                picPaddle.Left = picPaddle.Parent.ClientSize.Width - picPaddle.Width;
            }
        }

        /// <summary>
        /// handle the paint event of the paddle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Paddle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float blockWidth = (float)picPaddle.ClientSize.Width / boxNumber;
            int blockHeight = picPaddle.ClientSize.Height;

            using (Pen pen = new Pen(Color.White, 2))
            {
                for (int i = 0; i < boxNumber; i++)
                {
                    int x = (int)Math.Round(i * blockWidth);
                    int w = (int)Math.Round(blockWidth);
                    Rectangle rect = new Rectangle(x, 0, w, blockHeight);
                    g.DrawRectangle(pen, rect);
                }
            }
        }

        /// <summary>
        /// mouse move event to control the paddle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MouseMove(object sender, MouseEventArgs e)
        {
            // Ensure the paddle stays within the bounds of its parent container
            if (e.X < 0)
            {
                picPaddle.Left = 0;
            }
            else if(e.X > picPaddle.Parent.ClientSize.Width - picPaddle.Width)
            {
                picPaddle.Left = picPaddle.Parent.ClientSize.Width - picPaddle.Width;
            }
            else
            {
                picPaddle.Left = e.X;
            }
        }

        /// <summary>
        /// handle the key event to control the paddle
        /// </summary>
        /// <param name="key"></param>
        public void HandleKey(Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                    MoveLeft();
                    break;
                case Keys.Right:
                    MoveRight();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// determine whether the ball is collided with the paddle
        /// </summary>
        /// <param name="ballRect"></param>
        /// <param name="verticalCollision"></param>
        /// <returns></returns>
        public bool IsCollided(Rectangle ballRect, out bool verticalCollision)
        {
            verticalCollision = true;
            if (picPaddle.Bounds.IntersectsWith(ballRect))
            {
                Point ballCenter = new Point(ballRect.X + ballRect.Width / 2, ballRect.Y + ballRect.Height / 2);

                // top collision
                if (ballCenter.Y < picPaddle.Bounds.Top)
                {
                    verticalCollision = true;
                }
                // left collision
                else if (ballCenter.X < picPaddle.Bounds.Left)
                {
                    verticalCollision = false;
                }
                // right collision
                else if (ballCenter.X > picPaddle.Bounds.Right)
                {
                    verticalCollision = false;
                }
                else
                {
                    // bottom collision is not considered
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// expand the paddle
        /// </summary>
        public void Expand()
        {
            if (boxNumber < 10)
            {
                boxNumber++;
                int newWidth = boxNumber * picPaddle.Height;
                if (picPaddle.Left + newWidth > picPaddle.Parent.ClientSize.Width)
                {
                    picPaddle.Left = picPaddle.Parent.ClientSize.Width - newWidth;
                }
                picPaddle.Width = newWidth;
                picPaddle.Invalidate(); 
            }
        }

        /// <summary>
        /// shrink the paddle
        /// </summary>
        public void Shrink()
        {
            if (boxNumber > 2)
            {
                boxNumber--;
                int newWidth = boxNumber * picPaddle.Height;
                if (picPaddle.Left + newWidth > picPaddle.Parent.ClientSize.Width)
                {
                    picPaddle.Left = picPaddle.Parent.ClientSize.Width - newWidth;
                }
                picPaddle.Width = newWidth;
                picPaddle.Invalidate(); 
            }
        }
    }
}
