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
using static Assignment2Prj.Bricks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Assignment2Prj
{
    //define the Brick class
    public class Brick
    {
        private PictureBox brick;
        private BrickType brickType;

        static private int defaultScore = 10;

        //define the type of brick
        public enum BrickType
        {
            Normal,
            Score20,
            Score30,
            Bomb,
            stretch,
            Shrink,
            extra
        }

        /// <summary>
        /// Gets the width of the brick.
        /// </summary>
        public int Width { get { return brick.Width; } }

        /// <summary>
        /// Gets the height of the brick.
        /// </summary>
        public int Height { get { return brick.Height; } }

        /// <summary>
        /// constructor
        /// </summary>
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

        /// <summary>
        /// Sets the type of the brick.
        /// </summary>
        /// <param name="type">The <see cref="BrickType"/> to assign to the brick. This value determines the brick's behavior and
        /// appearance.</param>
        public void SetBrickType(BrickType type)
        {
            this.brickType = type;
        }

        /// <summary>
        /// gets the type of the brick.
        /// </summary>
        /// <returns></returns>
        public BrickType GetBrickType()
        {
            return this.brickType;
        }

        /// <summary>
        /// gets the score of the brick.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// sets the background color of the brick.
        /// </summary>
        /// <param name="color"></param>
        public void SetBackgroundColor(Color color)
        {
            brick.BackColor = color;
        }

        /// <summary>
        /// Handles the painting of a brick in the game, rendering its appearance based on its type.
        /// </summary>
        /// <remarks>This method customizes the appearance of a brick based on its type, such as
        /// displaying a score,  or rendering specific images for special brick types like bombs or power-ups. The
        /// brick's type  is determined by its associated <see cref="BrickType"/> value.</remarks>
        /// <param name="sender">The <see cref="PictureBox"/> that triggered the paint event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> containing the graphics context for drawing.</param>
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
                    // set desired size for the image
                    int desiredWidth = 18;
                    int desiredHeight = 18;

                    // set position to center the image
                    int centerX = (pic.Width - desiredWidth) / 2;
                    int centerY = (pic.Height - desiredHeight) / 2;

                    // create destination rectangle
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
                        case BrickType.stretch:
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

        /// <summary>
        /// adds the brick to the specified container control.
        /// </summary>
        /// <param name="container"></param>
        public void AddToContainer(Control container)
        {
            container.Controls.Add(brick);
        }

        /// <summary>
        /// removes the brick from its parent container, if it has one.
        /// </summary>
        public void RemoveFromContainer()
        {
            if (brick.Parent != null)
            {
                brick.Parent.Controls.Remove(brick);
            }
        }

        /// <summary>
        /// sets the position of the brick.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public void SetPosition(int left, int top)
        {
            brick.Left = left;
            brick.Top = top;
        }

        /// <summary>
        /// sets the tag of the brick.
        /// </summary>
        /// <param name="tag"></param>
        public void SetTag(object tag)
        {
            brick.Tag = tag;
        }

        /// <summary>
        /// determines whether the brick intersects with the specified rectangle, indicating a collision.
        /// </summary>
        /// <param name="ballRect"></param>
        /// <param name="verticalCollision"></param>
        /// <returns></returns>
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

    //define the Bricks class
    public class Bricks
    {
        /// <summary>
        /// Your Brick class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private Brick[,] bricks;
        private int rows;
        private int cols;
        private Random rand = new Random();

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
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

            //Randomly assign special brick types
            for (int r = 0; r < rows; r++)
            {
                bricks[r, rand.Next(0, cols)].SetBrickType(Brick.BrickType.Score20);
            }

            // Ensure unique positions for bomb bricks
            for (int i = 0; i < rows / 2; i++)
            {
                Point PointBomb = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[PointBomb.X, PointBomb.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    PointBomb.Y = (PointBomb.Y + 1) % cols;
                }
                bricks[PointBomb.X, PointBomb.Y].SetBrickType(Brick.BrickType.Bomb);
            }

            // Ensure unique positions for score30 bricks
            for (int i = 0; i < rows / 2; i++)
            {
                Point score30 = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[score30.X, score30.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    score30.Y = (score30.Y + 1) % cols;
                }
                bricks[score30.X, score30.Y].SetBrickType(Brick.BrickType.Score30);
            }

            // Ensure unique positions for stretch bricks
            for (int i = 0; i < rows / (2 * PublicDatas.currentLevel); i++)
            {
                Point stretch = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[stretch.X, stretch.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    stretch.Y = (stretch.Y + 1) % cols;
                }
                bricks[stretch.X, stretch.Y].SetBrickType(Brick.BrickType.stretch);
            }

            // Ensure unique positions for shrink bricks
            for (int i = 0; i < rows && i < PublicDatas.currentLevel * 2; i++)
            {
                Point stretch = new Point(rand.Next(0, rows), rand.Next(0, cols));
                while (bricks[stretch.X, stretch.Y].GetBrickType() != Brick.BrickType.Normal)
                {
                    stretch.Y = (stretch.Y + 1) % cols;
                }
                bricks[stretch.X, stretch.Y].SetBrickType(Brick.BrickType.Shrink);
            }

            // Ensure unique positions for extra ball bricks
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

        /// <summary>
        /// determines whether all bricks have been broken.
        /// </summary>
        /// <returns></returns>
        virtual public bool IsAllBricksBreakout()
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

        /// <summary>
        /// generates a Color from HSV values.
        /// </summary>
        /// <param name="hue"></param>
        /// <param name="saturation"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// adds all bricks to the specified container control.
        /// </summary>
        /// <param name="container"></param>
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

        /// <summary>
        /// checks for collisions between the ball and the bricks, updating the score and brick states accordingly.
        /// </summary>
        /// <param name="ballRect"></param>
        /// <param name="score"></param>
        /// <param name="collisionType"></param>
        /// <param name="verticalCollision"></param>
        /// <returns></returns>
        virtual public bool CheckCollision(Rectangle ballRect, out int score, out Brick.BrickType collisionType, out bool verticalCollision)
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

                        // If the brick is a bomb, remove adjacent bricks as well
                        if (collisionType == Brick.BrickType.Bomb)
                        {
                            // up
                            if (i > 0 && bricks[i - 1, j] != null)
                            {
                                score += bricks[i - 1, j].GetBrickScore();

                                bricks[i - 1, j].RemoveFromContainer();
                                bricks[i - 1, j] = null;
                            }

                            // down
                            if (i < rows - 1 && bricks[i + 1, j] != null) 
                            {
                                score += bricks[i + 1, j].GetBrickScore();

                                bricks[i + 1, j].RemoveFromContainer();
                                bricks[i + 1, j] = null;
                            }

                            // left
                            if (j > 0 && bricks[i, j - 1] != null)
                            {
                                score += bricks[i, j - 1].GetBrickScore();

                                bricks[i, j - 1].RemoveFromContainer();
                                bricks[i, j - 1] = null;
                            }

                            // right
                            if (j < cols - 1 && bricks[i, j + 1] != null)
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


        //////for test purpose//////
        /// <summary>
        /// clears all bricks from the container and sets them to null.
        /// </summary>
        public void ClearBricks()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (bricks[i, j] != null)
                    {
                        bricks[i, j].RemoveFromContainer();
                        bricks[i, j] = null;
                    }
                }
            }
        }
    }
}
