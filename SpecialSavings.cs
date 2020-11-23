using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Type
{
    abstract class SpecialSavings : Account
    {
        
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
        public SpecialSavings() { }
        public  SpecialSavings(double amount, int trans, int noTrans, string name, string accNo, double balance) : base(name, accNo, balance)
        {
            this.trans = trans;
            this.noTrans = noTrans;
            if (noTrans < trans)
            {
                
                balance += amount;
            }
            else
                Console.WriteLine("Not following minimal number of monthly transaction");
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
