using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            m_strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Temp\\CDmaker.mdb";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(m_strConn);
            
        }

        private string m_strConn;
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataReader rdr;

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM Song", conn);
            rdr = cmd.ExecuteReader();
            rdr.Read();

            string strSongs = "Songs\r\n";
            while (rdr.Read())
            {
                strSongs += rdr[1] + "    by    " + rdr[2] + "\r\n";
            }

            textBox1.Text = strSongs;
        }
    }
}
