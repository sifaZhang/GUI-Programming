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
    public partial class Form1 : Form
    {
        Image[] images;
        public Form1()
        {
            InitializeComponent();
            images = new Image[10];
            loadImages();
        }

        private void loadImages()
        {
            for (int i = 0; i < images.Length; i++)
            {
                images[i] = (Bitmap)Properties.Resources.ResourceManager.GetObject("T" + i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < images.Length; i++)
            {
                pictureBox1.Image = images[i];
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);

                if( i == images.Length - 1)
                    i = 0;
            }
        }
    }
}
