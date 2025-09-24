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

        public Ranking()
        {
            InitializeComponent();

            this.parent = null;
        }

        public void SetParent(Form parent)
        {
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (parent != null)
                parent.Show();
        }

        private void Ranking_Activated(object sender, EventArgs e)
        {
            PublicDatas.LoadTopUsersFromFile();

            dgvTop5.DataSource = PublicDatas.topUsers;
        }
    }
}
