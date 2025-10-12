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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Assignment2Prj
{
    public class Ball
    {
        /// <summary>
        /// Your Ball class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox picBall;
        private int verticalSpeed;
        private int horizontalSpeed;
        private bool isLost;

        // Sound player for wall collision 
        private static SoundPlayer player = new SoundPlayer(Properties.Resources.hit2);

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="picBall"></param>
        /// <param name="verticalSpeed"></param>
        /// <param name="horizontalSpeed"></param>
        public Ball(PictureBox picBall, int verticalSpeed, int horizontalSpeed)
        {
            try
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
        /// set the position of the ball
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public void SetPosition(int left, int top)
        {
            picBall.Left = left;
            picBall.Top = top;
        }

        /// <summary>
        /// Determines whether the current state is considered lost.
        /// </summary>
        /// <returns><see langword="true"/> if the current state is lost; otherwise, <see langword="false"/>.</returns>
        virtual public bool IsLost()
        {
            return isLost;
        }

        /// <summary>
        /// Adds the current ball control to the specified container.
        /// </summary>
        /// <param name="container">The container to which the ball control will be added. Must not be <see langword="null"/>.</param>
        public void AddToContainer(Control container)
        {
            container.Controls.Add(picBall);
        }

        /// <summary>
        /// removes the current ball control from its parent container, if it has one.
        /// </summary>
        public void RemoveFromContainer()
        {
            if (picBall.Parent != null)
            {
                picBall.Parent.Controls.Remove(picBall);
            }
        }

        /// <summary>
        /// Retrieves the current vertical and horizontal speeds.
        /// </summary>
        /// <param name="verticalSpeed">When this method returns, contains the current vertical speed.</param>
        /// <param name="horizontalSpeed">When this method returns, contains the current horizontal speed.</param>
        public void GetSpeed(out int verticalSpeed, out int horizontalSpeed)
        {
            horizontalSpeed = this.horizontalSpeed;
            verticalSpeed = this.verticalSpeed;
        }
        
        /// <summary>
        /// Retrieves the bounding rectangle of the ball.
        /// </summary>
        /// <returns>A <see cref="Rectangle"/> representing the position and dimensions of the ball.</returns>
        public Rectangle GetRectangle()
        {
            return new Rectangle(picBall.Left, picBall.Top, picBall.Width, picBall.Height);
        }

        /// <summary>
        /// Moves the object upward by setting its vertical speed to a negative value.
        /// </summary>
        /// <remarks>This method ensures that the vertical speed is always negative, indicating upward
        /// movement. The magnitude of the vertical speed is preserved, but its direction is adjusted to move
        /// upward.</remarks>
        public void MoveUp()
        {
            verticalSpeed = -1 * Math.Abs(verticalSpeed);
        }

        /// <summary>
        /// Reverses the vertical direction of movement.
        /// </summary>
        /// <remarks>This method inverts the vertical speed, effectively changing the direction of
        /// vertical movement.</remarks>
        public void ChangeDirectionVertical()
        {
            verticalSpeed = -verticalSpeed;
        }

        /// <summary>
        /// Reverses the horizontal direction of movement.
        /// </summary>
        /// <remarks>This method inverts the horizontal speed, effectively changing the direction of
        /// horizontal movement. For example, if the object is moving to the right, it will start moving to the left,
        /// and vice versa.</remarks>
        public void ChangeDirectionHorizontal()
        {
            horizontalSpeed = -horizontalSpeed;
        }

        /// <summary>
        /// Gets the parent control of the current control.
        /// </summary>
        /// <returns>The parent <see cref="Control"/> of the current control, or <see langword="null"/> if the control has no
        /// parent.</returns>
        public Control GetParent()
        {
            return picBall.Parent;
        }

        /// <summary>
        /// Handles the timer tick event to update the position of the ball and check for collisions.
        /// </summary>
        /// <remarks>This method moves the ball based on its current speed and checks for collisions with
        /// the edges of the container. If the ball collides with the left, right, or top walls, its direction is
        /// reversed, and a sound is played. If the ball goes below the bottom edge, it is considered "lost," and the
        /// necessary cleanup is performed.</remarks>
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
