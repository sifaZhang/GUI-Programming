using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print
{
    public partial class MyPreview : Form
    {
        public MyPreview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //printPreviewControl1.Document.Print();
            printPreviewControl1.Zoom += 0.1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.Zoom - 0.1 > 0)
            {  
                printPreviewControl1.Zoom -= 0.1; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewControl1.AutoZoom = true;
        }
    }
}
