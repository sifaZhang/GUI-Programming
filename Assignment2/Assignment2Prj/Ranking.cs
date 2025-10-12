//Author: Sifa Zhang
//Studeng ID: 1606796
//Date: 2025/10/13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    public partial class Ranking : Form
    {
        private Form parent;

        /// <summary>
        /// constructor
        /// </summary>
        public Ranking()
        {
            InitializeComponent();

            this.parent = null;
        }

        /// <summary>
        /// set the parent form
        /// </summary>
        /// <param name="parent"></param>
        public void SetParent(Form parent)
        {
            this.parent = parent;
        }

        /// <summary>
        /// handle the exit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (parent != null)
                parent.Show();
        }

        /// <summary>
        /// load the top users when the form is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ranking_Activated(object sender, EventArgs e)
        {
            PublicDatas.LoadTopUsersFromFile();

            dgvTop5.DataSource = PublicDatas.topUsers;
        }
    }
}
