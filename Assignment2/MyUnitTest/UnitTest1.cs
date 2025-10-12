//Author: Sifa Zhang
//Studeng ID: 1606796
//Date: 2025/10/13

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using Assignment2Prj;
using System.Windows.Forms;

namespace MyUnitTest
{
    //fake classes for testing
    public class FakeBricks : Bricks
    {
        public FakeBricks(int rows, int cols) : base(rows, cols)
        {

        }

        /// <summary>
        /// mock CheckCollision method to simulate different collision scenarios
        /// </summary>
        /// <param name="ballRect"></param>
        /// <param name="score"></param>
        /// <param name="collisionType"></param>
        /// <param name="verticalCollision"></param>
        /// <returns></returns>
        public override bool CheckCollision(Rectangle ballRect, out int score, out Brick.BrickType collisionType, out bool verticalCollision)
        {
            bool bReturn = false;
            if (ballRect.X == 300 && ballRect.Y == 300)
            {
                score = 10;
                collisionType = Brick.BrickType.Normal;
                verticalCollision = true;
                bReturn = true; // Simulate a collision
            }
            else if (ballRect.X == 301 && ballRect.Y == 301)
            {
                score = 20;
                collisionType = Brick.BrickType.Score20;
                verticalCollision = true;
                bReturn = true; // Simulate a collision
            }
            else if (ballRect.X == 302 && ballRect.Y == 302)
            {
                score = 30;
                collisionType = Brick.BrickType.Score30;
                verticalCollision = true;
                bReturn = true; // Simulate a collision

            }
            else 
            {
                score = 0;
                collisionType = Brick.BrickType.Normal;
                verticalCollision = false;
                bReturn = false; // No collision
            }

            return bReturn; 
        }
    }

    //fake Ball class for testing
    public class FakeBall : Ball
    {
        public FakeBall(PictureBox picBall, int verticalSpeed, int horizontalSpeed) : base(picBall, verticalSpeed, horizontalSpeed)
        {
        }
    }

    //fake Paddle class for testing
    public class FakePaddle : Paddle
    {
        public FakePaddle(PictureBox picPaddle, int paddleSpeed) : base(picPaddle, paddleSpeed)
        {
        }
    }


    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// create a manager with fake bricks, ball, and paddle for testing
        /// </summary>
        /// <returns></returns>
        private Mannger CreateManagerWithMocks()
        {
            var bricks = new FakeBricks(5, 10);
            PictureBox pictureBoxBall = new PictureBox();
            pictureBoxBall.Parent = new Game(); // Ensure the PictureBox has a parent
            var ball = new FakeBall(pictureBoxBall, -3, 3);
            PictureBox pictureBoxPaddle = new PictureBox();
            pictureBoxPaddle.Parent = pictureBoxBall.Parent; // Ensure the PictureBox has a parent
            var paddle = new FakePaddle(pictureBoxPaddle, 9);
            return new Mannger(bricks, ball, paddle);
        }

        /// <summary>
        /// test initial score is zero
        /// </summary>
        [TestMethod]
        public void GetCurrentScore_ReturnsInitialScoreZero()
        {
            var manager = CreateManagerWithMocks();
            Assert.AreEqual(0, manager.GetCurrentScore());

        }

        /// <summary>
        /// test game over when no balls
        /// </summary>
        [TestMethod]
        public void IsGameOver_ReturnsTrue_WhenNoBalls()
        {
            var manager = CreateManagerWithMocks();
            manager.GetBalls().Clear(); // simulate no balls
            Assert.IsTrue(manager.IsGameOver());
        }

        /// <summary>
        /// test game not over when balls exist
        /// </summary>
        [TestMethod]
        public void IsGameOver_ReturnsFalse_WhenBallsExist()
        {
            var manager = CreateManagerWithMocks();
            Assert.IsFalse(manager.IsGameOver());
        }

        /// <summary>
        /// test game win when all bricks are broken
        /// </summary>
        [TestMethod]
        public void IsGameWin_ReturnsTrue_WhenAllBricksBroken()
        {
            var manager = CreateManagerWithMocks();
            manager.GetBricks().ClearBricks(); // simulate all bricks broken
            Assert.IsTrue(manager.IsGameWin());
        }

        /// <summary>
        /// test game not win when bricks remain
        /// </summary>
        [TestMethod]
        public void IsGameWin_ReturnsFalse_WhenBricksRemain()
        {
            var manager = CreateManagerWithMocks();
            Assert.IsFalse(manager.IsGameWin());
        }

        /// <summary>
        /// test score updates correctly on score 10 brick collisions
        /// </summary>
        [TestMethod]
        public void OnTimer_UpdatesScore_OnBrickCollisionNormal()
        {
            var manager = CreateManagerWithMocks();
            var ball = manager.GetBalls()[0];
            ball.SetPosition(300, 300); // Position that triggers Score20 in FakeBricks
            manager.OnTimer();
            Assert.AreEqual(10, manager.GetCurrentScore());
        }

        /// <summary>
        /// test score updates correctly on score 20 brick collisions
        /// </summary>
        [TestMethod]
        public void OnTimer_UpdatesScore_OnBrickCollisionScore20()
        {
            var manager = CreateManagerWithMocks();
            // Simulate ball position to trigger Score20 collision
            var ball = manager.GetBalls()[0];
            ball.SetPosition(301, 301); // Position that triggers Score20 in FakeBricks
            manager.OnTimer();
            Assert.AreEqual(20, manager.GetCurrentScore());
        }

        /// <summary>
        /// test score updates correctly on score 30 brick collisions
        /// </summary>
        [TestMethod]
        public void OnTimer_UpdatesScore_OnBrickCollisionScore30()
        {
            var manager = CreateManagerWithMocks();
            // Simulate ball position to trigger Score30 collision
            var ball = manager.GetBalls()[0];
            ball.SetPosition(302, 302); // Position that triggers Score30 in FakeBricks
            manager.OnTimer();
            Assert.AreEqual(30, manager.GetCurrentScore());
        }

        /// <summary>
        /// test score does not update when no collision occurs
        /// </summary>
        [TestMethod]
        public void OnTimer_DoesNotUpdateScore_WhenNoCollision()
        {
            var manager = CreateManagerWithMocks();
            var ball = manager.GetBalls()[0];
            ball.SetPosition(303, 303); // Position that does not trigger collision
            manager.OnTimer();
            Assert.AreEqual(0, manager.GetCurrentScore());
        }

    }
}
