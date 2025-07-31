using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class Form2 : Form
    {
        public Form2(string transformName)
        {
            InitializeComponent();
            m_strName = transformName;
        }

        private string m_strName = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(m_strName))
            {
                label1.Text = "Welcome to form2, " + m_strName;
            }
            else
            {
                label1.Text = "Welcome to form2";
            }
        }
    }
}
