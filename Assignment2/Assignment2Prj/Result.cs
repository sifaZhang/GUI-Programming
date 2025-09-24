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
        public Result()
        {
            InitializeComponent();
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

            Game game = new Game();
            game.Show();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            int ranking = -1;
            int topScore = PublicDatas.GetMyTopScore(out ranking);

            lblResult.Text = "Game Over! \r\n" + PublicDatas.currentUserName + ", your final score is: "  + PublicDatas.currentScore + "\r\n"
                + "Your best ranking is " + ranking + " with score(" + topScore + ")";
        }
    }
}
