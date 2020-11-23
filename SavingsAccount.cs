using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Type
{
    class SavingsAccount:Account
    {
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private int trans;
        public int Trans
        {
            get { return trans; }
            set { trans = value; }
        }
        private int noTrans;
        public int NoTrans
        {
            get { return noTrans; }
            set { noTrans = value; }
        }
        public SavingsAccount() { }
        public SavingsAccount(int amount,int trans,int noTrans,string name,string accNo, double balance) : base(name,accNo,balance)
        {
            if ( noTrans<trans)
            {
                this.trans = trans;
                this.amount = amount;
                this.noTrans = noTrans;
                balance += amount;
            }
            else
                Console.WriteLine("Not following minimal number of monthly transaction");
        }
        public override void Withdraw(double amount)
        {
            if(balance-amount>=500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }

    }
}
