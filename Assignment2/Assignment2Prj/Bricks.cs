using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    class Bricks
    {
        /// <summary>
        /// Your Brick class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox[,] bricks;
        private int[,] scores;
        private int rows;
        private int cols;

        public Bricks(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.bricks = new PictureBox[rows, cols];
            this.scores = new int[rows, cols];
            //Initialize the bricks array with PictureBox objects
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bricks[i, j] = new PictureBox();
                    bricks[i, j].BorderStyle = BorderStyle.FixedSingle;
                    // Set properties for each PictureBox as needed
                    bricks[i, j].Width = 60; 
                    bricks[i, j].Height = 20; 
                    bricks[i, j].Left = j * (bricks[i, j].Width); 
                    bricks[i, j].Top = i * (bricks[i, j].Height);

                    scores[i, j] = 10; // 每个砖块的分数
                }

                float hue = (float)i / rows * 360f; // 色相从 0 到 360
                Color rowColor = ColorFromHSV(hue, 0.6f, 0.9f); // 饱和度和亮度可调

                for (int j = 0; j < cols; j++)
                {
                    bricks[i, j].BackColor = rowColor;
                }
            }
        }

        //Add methods 
        public Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            switch (hi)
            {
                case 0:
                    return Color.FromArgb(255, v, t, p);
                case 1:
                    return Color.FromArgb(255, q, v, p);
                case 2:
                    return Color.FromArgb(255, p, v, t);
                case 3:
                    return Color.FromArgb(255, p, q, v);
                case 4:
                    return Color.FromArgb(255, t, p, v);
                default:
                    return Color.FromArgb(255, v, p, q);
            }
        }

        public void AddToContainer(Control container)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    container.Controls.Add(bricks[i, j]);
                }
            }
        }

        public bool IsCollided(Rectangle ballRect, out int score)
        {
            score = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (bricks[i, j] != null && ballRect.IntersectsWith(new Rectangle(bricks[i, j].Left, bricks[i, j].Top, bricks[i, j].Width, bricks[i, j].Height)))
                    {
                        // Remove the brick from the container and set it to null
                        bricks[i, j].Parent.Controls.Remove(bricks[i, j]);
                        bricks[i, j] = null;
                        score = scores[i, j]; // Return the score of the hit brick
                        return true; // Return true on first collision
                    }
                }
            }

            return false; // No collision detected
        }
    }
}
