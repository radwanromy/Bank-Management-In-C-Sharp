using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Type
{
    abstract class Overdarft : Account
    {
        private int overdraftLimit;
        public int OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }
        
        public Overdarft() { }
        public Overdarft(int overdraftLimit,  string name, string accNo, double balance) : base(name, accNo, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override void Withdraw(double amount)
        {

            if (balance - amount >= 500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }
    }
}
