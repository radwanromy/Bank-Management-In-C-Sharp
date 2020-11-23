using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Type
{
    class Overdraft : Account
    {
        int overdraftLimit = 0;

        public Overdraft(string name, string accNo, double balance) : base(name, accNo, balance)
        {

        }
        override public void Deposit(double amount)
        {
            if (overdraftLimit>=1)
            {
                
                Console.WriteLine("You Can Not Have More Than One OverDraft In A Month");
            }
            else
            {
                this.balance = this.balance + amount;
                overdraftLimit++;
            }
        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance To Withdraw The Ammount");
        }
    }
}
