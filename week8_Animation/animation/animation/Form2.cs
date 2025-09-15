using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animation
{
    public partial class Form2 : Form
    {
        int verticalSize = 1;
        int horizontallSize = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 水平方向判断
            if (pictureBox1.Left + horizontallSize < 0 ||
                pictureBox1.Left + pictureBox1.Width + horizontallSize > this.ClientSize.Width)
            {
                horizontallSize *= -1; // 反弹
            }

            // 垂直方向判断
            if (pictureBox1.Top + verticalSize < 0 ||
                pictureBox1.Top + pictureBox1.Height + verticalSize > this.ClientSize.Height)
            {
                verticalSize *= -1; // 反弹
            }

            // 更新位置
            pictureBox1.Left += horizontallSize;
            pictureBox1.Top += verticalSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
