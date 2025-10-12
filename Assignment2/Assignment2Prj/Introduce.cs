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
    public partial class Introduce : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public Introduce()
        {
            InitializeComponent();
        }

        /// <summary>
        /// handle the start button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //check if the name is entered
            if (string.IsNullOrWhiteSpace(txtboxName.Text))
            {
                MessageBox.Show("Please enter your name before starting the game.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            PublicDatas.currentUserName = txtboxName.Text;

            Game game = new Game();
            game.Show();
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
    }
}
