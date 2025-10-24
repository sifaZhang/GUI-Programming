using System;

namespace DragDropExercise
{
    /// <summary>
    /// Summary description for BankAccount.
    /// </summary>
    public class BankAccount
    {
        private string acName;
        private int acNumber;
        private double acBalance;

        public BankAccount(string Name, int Num, double Balance) // constructor
        {
            acName = Name;
            acNumber = Num;
            acBalance = Balance;
        }

        public BankAccount(string AccountAsText) // constructor
                                                 //used in recovering bank account objects from a text file
        {
            string[] parts = AccountAsText.Split('~');

            acName = parts[0];
            acNumber = Convert.ToInt32(parts[1]);
            acBalance = Convert.ToDouble(parts[2]);
        }

        public void Win()
        {
            acBalance += 10;
        }

        public void Lose()
        {
            acBalance -= 10;
        }

        public string ToText()
        //used in saving Account objects as text
        {
            return acName + "~" + acNumber.ToString() + "~" + acBalance.ToString();
        }

        public string Display()
        //used in saving Account objects as text
        {
            return acName + "\r\n"
                + "#" + acNumber.ToString() + "  $" + acBalance.ToString();
        }

        public override string ToString()
        //for use in listboxes
        {
            return acName;
        }

    }
}

