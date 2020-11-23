using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Type
{
    class SavingsAccount:Account
    {

        int transaction = 0;
        int minimalNo = 3;

        public SavingsAccount(string name, string accNo, double balance) : base(name, accNo, balance)
        {

        }

        override public void Deposit(double amount)
        {

            if (transaction >= minimalNo)
            {
                Console.WriteLine("You Can Not Have Any More Transaction For This Month.");
            }
            else
            {
                this.balance = this.balance + amount;
                transaction++;
            }

        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= 500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance To Withdraw The Ammount");
        }
        

    }
}
