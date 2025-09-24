using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    class Paddle
    {
        /// <summary>
        /// Your Paddle class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox picPaddle;
        private int paddleSpeed;
        private int boxNumber = 6;

        public Paddle(PictureBox picPaddle, int paddleSpeed)
        {
            this.picPaddle = picPaddle;
            this.paddleSpeed = paddleSpeed;
            this.picPaddle.BackColor = Color.Gray; // 设置背景为黑色
            this.picPaddle.Height = 16;
            this.picPaddle.Width = boxNumber * picPaddle.Height;
        }

        public Point GetPosition()
        {
            return new Point(picPaddle.Left, picPaddle.Top);
        }

        public int GetWidth()
        {
            return picPaddle.Width;
        }

        public int GetHeight()
        {
            return picPaddle.Height;
        }

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

        public bool IsCollided(Rectangle ballRect, out bool verticalCollision)
        {
            verticalCollision = true;
            if (picPaddle.Bounds.IntersectsWith(ballRect))
            {
                Point ballCenter = new Point(ballRect.X + ballRect.Width / 2, ballRect.Y + ballRect.Height / 2);

                if (ballCenter.Y < picPaddle.Bounds.Top)
                {
                    verticalCollision = true;
                }
                else if (ballCenter.X < picPaddle.Bounds.Left)
                {
                    verticalCollision = false;
                }
                else if (ballCenter.X > picPaddle.Bounds.Right)
                {
                    verticalCollision = false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

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
                picPaddle.Invalidate(); // 触发重绘
            }
        }
    }
}
