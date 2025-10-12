//Author: Sifa Zhang
//Studeng ID: 1606796
//Date: 2025/10/13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    public partial class Result : Form
    {
        private bool bWin;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="bWin"></param>
        public Result(bool bWin)
        {
            InitializeComponent();

            this.bWin = bWin;
        }

        /// <summary>
        /// handle the ranking button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            PublicDatas.ranking.SetParent(this);
            PublicDatas.ranking.Show();
        }

        /// <summary>
        /// handle the quit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// handle the start button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();

            PublicDatas.currentLevel = 1;
            PublicDatas.currentScore = 0;

            Game game = new Game();
            game.Show();
        }

        /// <summary>
        /// show the result when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Result_Load(object sender, EventArgs e)
        {
            int ranking = -1;
            int topScore = PublicDatas.GetMyTopScore(out ranking);

            //enable the next level button if the user wins and there are more levels
            if (PublicDatas.currentLevel < PublicDatas.maxLevel && bWin)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }

            if (bWin)
            {
                //win message
                lblResult.Text = "Congratulations! \r\n" + PublicDatas.currentUserName + "You have completed level " + PublicDatas.currentLevel + ".\r\n"
                    + "Your current score is: " + PublicDatas.currentScore + ".\r\n"
                    + "Your best ranking is " + ranking + " with score(" + topScore + ")";
            }
            else
            {
                //game over message
                lblResult.Text = "Game Over! \r\n" + PublicDatas.currentUserName + ", your final score is: " + PublicDatas.currentScore + ".\r\n"
                    + "Your best ranking is " + ranking + " with score(" + topScore + ").";
            }
        }

        /// <summary>
        /// handle the next level button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();

            PublicDatas.AddLevel();

            Game game = new Game();
            game.Show();
        }
    }
}
