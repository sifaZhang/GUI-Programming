using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDropExercise
{
    public partial class DragDropForm : Form
    {
        private BankAccount[] accounts = new BankAccount[5];
        Timer timerWin = new Timer();
        Timer timerLose = new Timer();

        public DragDropForm()
        {
            InitializeComponent();
        }

        private void DragDropForm_Load(object sender, EventArgs e)
        {
            accounts[0] = new BankAccount("Joe~1~200");
            accounts[1] = new BankAccount("Sally~2~300");
            accounts[2] = new BankAccount("Freda~3~3000");
            accounts[3] = new BankAccount("Max~4~500");
            accounts[4] = new BankAccount("Bill~5~2000");

            foreach (BankAccount ac in accounts)
            {
                listBox1.Items.Add(ac);
            }

            timerWin.Interval = 2000; // 单位是毫秒，2000ms = 2秒
            timerWin.Tick += timerLose_Tick; // 绑定事件处理方法

            timerLose.Interval = 2000; // 单位是毫秒，2000ms = 2秒
            timerLose.Tick += timerLose_Tick; // 绑定事件处理方法
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lsBox = sender as ListBox;
            int index = lsBox.IndexFromPoint(e.X, e.Y);
            if (index != -1)
            {

                DragDropEffects result = DoDragDrop(lsBox.Items[index], DragDropEffects.Scroll);

                if (result != DragDropEffects.None)
                {
                }
            }
        }

        private void lblWin_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lblWin_DragDrop(object sender, DragEventArgs e)
        {
            BankAccount account = (BankAccount)e.Data.GetData(typeof(BankAccount));
            account.Win();

            timerWin.Stop();
            timerWin.Start();
            lblWin.Text = account.ToString() + " wins!!";

            label5.Text = account.Display();
        }

        private void lblLose_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lblLose_DragDrop(object sender, DragEventArgs e)
        {
            BankAccount account = (BankAccount)e.Data.GetData(typeof(BankAccount));
            account.Lose();

            timerLose.Stop();
            timerLose.Start();
            lblLose.Text = account.ToString() + " lose!!";

            label5.Text = account.Display();
        }

        private void timerWin_Tick(object sender, EventArgs e)
        {
            lblWin.Text = "";
            timerWin.Stop();
        }

        private void timerLose_Tick(object sender, EventArgs e)
        {
            lblLose.Text = "";
            timerLose.Stop();
        }
    }
}
