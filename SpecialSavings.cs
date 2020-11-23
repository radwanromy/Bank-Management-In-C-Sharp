using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Type
{
    class SpecialSavings : Account
    {

        int transaction = 0;
        int minimalNo = 3;

        public SpecialSavings() { }
        public SpecialSavings(string name, string accNo, double balance) : base(name, accNo, balance)
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

            if (balance - amount >= balance*0.2)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Withdraw Balance Must Be Minimum 20% Of Openning Balance");
        }
    }
}
