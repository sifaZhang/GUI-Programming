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
        public Result(bool bWin)
        {
            InitializeComponent();

            this.bWin = bWin;
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            PublicDatas.ranking.SetParent(this);
            PublicDatas.ranking.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();

            PublicDatas.currentLevel = 1;
            PublicDatas.currentScore = 0;

            Game game = new Game();
            game.Show();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            int ranking = -1;
            int topScore = PublicDatas.GetMyTopScore(out ranking);

            if(PublicDatas.currentLevel < PublicDatas.maxLevel && bWin)
            {
               btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }

            if(bWin)
                lblResult.Text = "Congratulations! \r\n" + PublicDatas.currentUserName + "You have completed level " + PublicDatas.currentLevel + ".\r\n"
                    + "Your current score is: " + PublicDatas.currentScore + ".\r\n"
                    + "Your best ranking is " + ranking + " with score(" + topScore + ")";
            else
                lblResult.Text = "Game Over! \r\n" + PublicDatas.currentUserName + ", your final score is: " + PublicDatas.currentScore + ".\r\n"
                    + "Your best ranking is " + ranking + " with score(" + topScore + ").";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();

            PublicDatas.AddLevel();

            Game game = new Game();
            game.Show();
        }
    }
}
