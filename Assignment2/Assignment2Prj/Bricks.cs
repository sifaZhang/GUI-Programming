using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment2Prj.Bricks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Assignment2Prj
{
    public class Brick
    {
        public enum BrickType
        {
            Normal,
            Score20,
            Score30,
            Bomb,
            Stetch,
            Shrink,
            extra
        }

        public int Width { get { return brick.Width; } }
        public int Height { get { return brick.Height; } }

        private PictureBox brick;
        private BrickType brickType;

        static private int defaultScore = 10;

        public Brick()
        {
            this.brick = new PictureBox();
            this.brickType = BrickType.Normal;
            defaultScore = 10;
            brick.BorderStyle = BorderStyle.FixedSingle;
            brick.Width = 80;
            brick.Height = 30;
            brick.Paint += Brick_Paint;
        }

        public void SetBrickType(BrickType type)
        {
            this.brickType = type;
        }

        public BrickType GetBrickType()
        {
            return this.brickType;
        }

        public int GetBrickScore()
        {
            switch (brickType)
            {
                case BrickType.Score20:
                    return 20;
                case BrickType.Score30:
                    return 30;
                default:
                    return defaultScore;
            }
        }

        public void SetBackgroundColor(Color color)
        {
            brick.BackColor = color;
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
                    switch (brickType)
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
                            e.Graphics.DrawImage(Properties.Resources.bomb, destRect);
                            break;
                        case BrickType.Stetch:
                            e.Graphics.DrawImage(Properties.Resources.Stretch, destRect);
                            break;
                        case BrickType.Shrink:
                            e.Graphics.DrawImage(Properties.Resources.shrink, destRect);
                            break;
                        case BrickType.extra:
                            e.Graphics.DrawImage(Properties.Resources.plus, destRect);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void AddToContainer(Control container)
        {
            container.Controls.Add(brick);
        }

        public void RemoveFromContainer()
        {
            if (brick.Parent != null)
            {
                brick.Parent.Controls.Remove(brick);
            }
        }

        public void SetPosition(int left, int top)
        {
            brick.Left = left;
            brick.Top = top;
        }

        public void SetTag(object tag)
        {
            brick.Tag = tag;
        }

        public bool IntersectsWith(Rectangle ballRect, out bool verticalCollision)
        {
            verticalCollision = true;
            if ( brick.Bounds.IntersectsWith(ballRect))
            {
                Point ballCenter = new Point(ballRect.X + ballRect.Width / 2, ballRect.Y + ballRect.Height / 2);

                if (ballCenter.Y < brick.Bounds.Top)
                {
                    verticalCollision = true;
                }
                else if (ballCenter.Y > brick.Bounds.Bottom)
                {
                    verticalCollision = true;
                }
                else if (ballCenter.X < brick.Bounds.Left)
                {
                    verticalCollision = false;
                }
                else if (ballCenter.X > brick.Bounds.Right)
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
    }

    class Bricks
    {
        /// <summary>
        /// Your Brick class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private Brick[,] bricks;
        private int rows;
        private int cols;
        private Random rand = new Random();

        public Bricks(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.bricks = new Brick[rows, cols];

            //Initialize the bricks array with PictureBox objects
            for (int i = 0; i < rows; i++)
            {
                float hue = (float)i / rows * 360f; // 色相从 0 到 360
                Color rowColor = ColorFromHSV(hue, 0.6f, 0.9f); // 饱和度和亮度可调

                for (int j = 0; j < cols; j++)
                {
                    bricks[i, j] = new Brick();
                    bricks[i, j].SetPosition(j * (bricks[i, j].Width), i * (bricks[i, j].Height));
                    bricks[i, j].SetTag(new Point(i, j));
                    bricks[i, j].SetBackgroundColor(rowColor);
                }
            }

            for (int r = 0; r < rows; r++)
            {
                bricks[r, rand.Next(0, cols)].SetBrickType(Brick.BrickType.Score20);
            }

            for (int i = 0; i < rows / 2; i++)
            {
                Point PointBomb = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[PointBomb.X, PointBomb.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    PointBomb.Y = (PointBomb.Y + 1) % cols;
                }
                bricks[PointBomb.X, PointBomb.Y].SetBrickType(Brick.BrickType.Bomb);
            }

            for (int i = 0; i < rows / 2; i++)
            {
                Point score30 = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[score30.X, score30.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    score30.Y = (score30.Y + 1) % cols;
                }
                bricks[score30.X, score30.Y].SetBrickType(Brick.BrickType.Score30);
            }

            for (int i = 0; i < rows / (2 * PublicDatas.currentLevel); i++)
            {
                Point stretch = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[stretch.X, stretch.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    stretch.Y = (stretch.Y + 1) % cols;
                }
                bricks[stretch.X, stretch.Y].SetBrickType(Brick.BrickType.Stetch);
            }

            for (int i = 0; i < rows && i < PublicDatas.currentLevel * 2; i++)
            {
                Point stretch = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[stretch.X, stretch.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    stretch.Y = (stretch.Y + 1) % cols;
                }
                bricks[stretch.X, stretch.Y].SetBrickType(Brick.BrickType.Shrink);
            }

            for (int i = 0; i < rows / 2; i++)
            {
                Point extraBall = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[extraBall.X, extraBall.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    extraBall.Y = (extraBall.Y + 1) % cols;
                }
                bricks[extraBall.X, extraBall.Y].SetBrickType(Brick.BrickType.extra);
            }
        }

        //Add methods 
        public bool IsAllBricksBreakout()
        {
            bool allBroken = true;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (bricks[i, j] != null)
                    {
                        allBroken = false;
                        break;
                    }
                }

                if (!allBroken)
                    break;
            }

            return allBroken;
        }

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
                    bricks[i, j].AddToContainer(container);
                }
            }
        }

        public bool CheckCollision(Rectangle ballRect, out int score, out Brick.BrickType collisionType, out bool verticalCollision)
        {
            score = 0;
            collisionType = Brick.BrickType.Normal;
            verticalCollision = true;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (bricks[i, j] != null && bricks[i, j].IntersectsWith(ballRect, out verticalCollision))
                    {
                        // Remove the brick from the container and set it to null
                        collisionType = bricks[i, j].GetBrickType();

                        score = bricks[i, j].GetBrickScore();
                        if (collisionType == Brick.BrickType.Bomb)
                        {
                            if(i > 0 && bricks[i - 1, j] != null) // 上
                            {
                                score += bricks[i - 1, j].GetBrickScore();

                                bricks[i - 1, j].RemoveFromContainer();
                                bricks[i - 1, j] = null;
                            }

                            if(i < rows - 1 && bricks[i + 1, j] != null) // 下
                            {
                                score += bricks[i + 1, j].GetBrickScore();

                                bricks[i + 1, j].RemoveFromContainer();
                                bricks[i + 1, j] = null;
                            }

                            if (j > 0 && bricks[i, j - 1] != null) // 左
                            {
                                score += bricks[i, j - 1].GetBrickScore();

                                bricks[i, j - 1].RemoveFromContainer();
                                bricks[i, j - 1] = null;
                            }

                            if(j < cols - 1 && bricks[i, j + 1] != null) // 右
                            {
                                score += bricks[i, j + 1].GetBrickScore();

                                bricks[i, j + 1].RemoveFromContainer();
                                bricks[i, j + 1] = null;
                            }
                        }

                        bricks[i, j].RemoveFromContainer();
                        bricks[i, j] = null;

                        return true; // Return true on first collision
                    }
                }
            }

            return false; // No collision detected
        }
    }
}
