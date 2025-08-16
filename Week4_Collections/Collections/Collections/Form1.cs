using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Collections
{
    public partial class Form1 : Form
    {
        SimpleClass[] Points;
        int ObjectCount;
        Random rndm;
        string[] Names = { "Alice", "Bob", "Charlie", "Diana", "Ethan", "Fiona", "George", "Hannah", "Ian", "Jasmine" };

        public Form1()
        {
            InitializeComponent();

            Points = new SimpleClass[10];
            ObjectCount = 0;
            rndm = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ObjectCount < 9 )
            {
                int age = rndm.Next(1, 100);
                int nameIndex = rndm.Next(0, Names.Length);
                string name = Names[nameIndex];
                SimpleClass newPerson = new SimpleClass(name, age);
                Points[ObjectCount] = newPerson;
                ObjectCount++;
            }
            else
            {
                MessageBox.Show("Array is full. Cannot add more objects.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int count = 0;
            foreach (SimpleClass ob in Points)
            {
                if(count >= ObjectCount)
                {
                    break;
                }
                else
                {
                    count++;
                    label1.Text += ob.Show() + "\r\n";  // "\r\n" forces a new line
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text += "Total is  " + ObjectCount.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < ObjectCount; i++)
            {
                listBox1.Items.Add(Points[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "";
            label2.Text = "";
            ObjectCount = 0;
            Array.Clear(Points, 0, Points.Length); // Clear the array
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = listBox1.SelectedItem.ToString();
        }
    }
}
