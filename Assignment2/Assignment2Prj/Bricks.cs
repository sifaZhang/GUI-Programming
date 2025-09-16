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
        public enum BrickType
        {
            Normal,
            Score20,
            Score30,
            Bomb,
            Stetch,
            extra
        }

        /// <summary>
        /// Your Brick class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox[,] bricks;
        private BrickType[,] brickTypes;
        private int rows;
        private int cols;
        private int defaultScore = 10;
        private Random rand = new Random();
        private Image bombImage = Properties.Resources.bomb;
        private Image extraImage = Properties.Resources.plus;
        private Image stretchImage = Properties.Resources.expand;

        public Bricks(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.bricks = new PictureBox[rows, cols];
            this.brickTypes = new BrickType[rows, cols];

            //Initialize the bricks array with PictureBox objects
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bricks[i, j] = new PictureBox();
                    bricks[i, j].BorderStyle = BorderStyle.FixedSingle;
                    // Set properties for each PictureBox as needed
                    bricks[i, j].Width = 80; 
                    bricks[i, j].Height = 30; 
                    bricks[i, j].Left = j * (bricks[i, j].Width); 
                    bricks[i, j].Top = i * (bricks[i, j].Height);
                    bricks[i, j].Tag = new Point(i, j);

                    bricks[i, j].Paint += Brick_Paint;
                    brickTypes[i, j] = BrickType.Normal;
                }

                float hue = (float)i / rows * 360f; // 色相从 0 到 360
                Color rowColor = ColorFromHSV(hue, 0.6f, 0.9f); // 饱和度和亮度可调

                for (int j = 0; j < cols; j++)
                {
                    bricks[i, j].BackColor = rowColor;
                }
            }

            for (int r = 0; r < rows; r++)
            {
                brickTypes[r, rand.Next(0, cols)] = BrickType.Score20;
            }

            for (int i = 0; i < rows / 2; i++)
            {
                Point PointBomb = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (brickTypes[PointBomb.X, PointBomb.Y] != BrickType.Normal)
                {
                    PointBomb.Y = (PointBomb.Y + 1) % cols;
                }
                brickTypes[PointBomb.X, PointBomb.Y] = BrickType.Bomb;
            }

            for (int i = 0; i < rows / 2; i++)
            {
                Point score30 = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (brickTypes[score30.X, score30.Y] != BrickType.Normal)
                {
                    score30.Y = (score30.Y + 1) % cols;
                }
                brickTypes[score30.X, score30.Y] = BrickType.Score30;
            }

            for (int i = 0; i < rows / 2; i++)
            {
                Point stretch = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (brickTypes[stretch.X, stretch.Y] != BrickType.Normal)
                {
                    stretch.Y = (stretch.Y + 1) % cols;
                }
                brickTypes[stretch.X, stretch.Y] = BrickType.Stetch;
            }

            for (int i = 0; i < rows / 2; i++)
            {
                Point extraBall = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (brickTypes[extraBall.X, extraBall.Y] != BrickType.Normal)
                {
                    extraBall.Y = (extraBall.Y + 1) % cols;
                }
                brickTypes[extraBall.X, extraBall.Y] = BrickType.extra;
            }
        }

        private void Brick_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic?.Tag is Point index)
            {
                int i = index.X;
                int j = index.Y;

                using (Font font = new Font("Arial", 10, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.White))
                {
                    // 设置缩放后的尺寸
                    int desiredWidth = 18;
                    int desiredHeight = 18;

                    // 计算居中位置
                    int centerX = (pic.Width - desiredWidth) / 2;
                    int centerY = (pic.Height - desiredHeight) / 2;

                    // 创建目标矩形区域
                    Rectangle destRect = new Rectangle(centerX, centerY, desiredWidth, desiredHeight);

                    string scoreText = "";
                    switch (brickTypes[i, j])
                    {
                        case BrickType.Score20:
                            scoreText = "+" + (20 - defaultScore).ToString();
                            e.Graphics.DrawString(scoreText, font, brush, new PointF(25, 6));
                            break;
                        case BrickType.Score30:
                            scoreText = "+" + (30 - defaultScore).ToString();
                            e.Graphics.DrawString(scoreText, font, brush, new PointF(25, 6));
                            break;
                        case BrickType.Bomb:
                            e.Graphics.DrawImage(bombImage, destRect);
                            break;
                        case BrickType.Stetch:
                            e.Graphics.DrawImage(stretchImage, destRect);
                            break;
                        case BrickType.extra:
                            e.Graphics.DrawImage(extraImage, destRect);
                            break;
                        default:
                            break;
                    }
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

        private int GetBrickScore(int i, int j)
        {
            switch (brickTypes[i, j])
            {
                case BrickType.Score20:
                    return 20;
                case BrickType.Score30:
                    return 30;
                default:
                    return defaultScore;
            }
        }

        public bool CheckCollision(Rectangle ballRect, out int score, out BrickType collisionType)
        {
            score = 0;
            collisionType = BrickType.Normal;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (bricks[i, j] != null && ballRect.IntersectsWith(new Rectangle(bricks[i, j].Left, bricks[i, j].Top, bricks[i, j].Width, bricks[i, j].Height)))
                    {
                        // Remove the brick from the container and set it to null
                        bricks[i, j].Parent.Controls.Remove(bricks[i, j]);
                        bricks[i, j] = null;
                        // Return the score of the hit brick
                        score = GetBrickScore(i,j);
                        collisionType = brickTypes[i, j];

                        if (brickTypes[i, j] == BrickType.Bomb)
                        {
                            if(i > 0 && bricks[i - 1, j] != null) // 上
                            {
                                bricks[i - 1, j].Parent.Controls.Remove(bricks[i - 1, j]);
                                bricks[i - 1, j] = null;
                                score += GetBrickScore(i - 1, j);
                            }

                            if(i < rows - 1 && bricks[i + 1, j] != null) // 下
                            {
                                bricks[i + 1, j].Parent.Controls.Remove(bricks[i + 1, j]);
                                bricks[i + 1, j] = null;
                                score += GetBrickScore(i + 1, j);
                            }

                            if (j > 0 && bricks[i, j - 1] != null) // 左
                            {
                                bricks[i, j - 1].Parent.Controls.Remove(bricks[i, j - 1]);
                                bricks[i, j - 1] = null;
                                score += GetBrickScore(i, j - 1);
                            }

                            if(j < cols - 1 && bricks[i, j + 1] != null) // 右
                            {
                                bricks[i, j + 1].Parent.Controls.Remove(bricks[i, j + 1]);
                                bricks[i, j + 1] = null;
                                score += GetBrickScore(i, j + 1);
                            }
                        }

                        return true; // Return true on first collision
                    }
                }
            }

            return false; // No collision detected
        }
    }
}
