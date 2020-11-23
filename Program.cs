using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Employee Information");
            //Console.WriteLine();
            //Console.WriteLine();

            Bank b = new Bank("Sonali Bank");
            Employee e1 = new Employee("Radwan", "0001",1000);
            Employee e2 = new Employee("Rahim", "123123",1000);
            Employee e3 = new Employee("Karim", "12322",1000);
            b.AddEmployee(e1,e2,e3);
            //b.ShowAllEmployees();
            //Console.WriteLine();
            //Console.WriteLine("Customer and Account Information");
            //Console.WriteLine();
            //Console.WriteLine();
            Customer c = new Customer("121", "Radwan", "Rangpur");
            Account a1 = new SavingsAccount( "Radwan", "12121", 10000);
            Account a2 = new FixedAccount("Radwan", "12121", 10000, 2015,5);
            c.AddAccounts(a1,a2);
            FixedAccount a3 = new FixedAccount("Radwan", "12121", 10000, 2015, 5);
            Account a5 = new FixedAccount("Rahim", "12122", 10000, 2015, 5);
            //Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||Fixed Account Check|||||||||||||||||||||||");
            //Console.WriteLine();
            Console.WriteLine();
            a2.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||Fixed Account Withdraw Check|||||||||||||||||||||||");
            Console.WriteLine();
            a2.Withdraw(5000);
            a2.ShowInfo();
            
            
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||Saving Account Check|||||||||||||||||||||||");
            Account a6 = new SavingsAccount( "Radwan", "12121", 10000);
            SavingsAccount a4 = new SavingsAccount("Rahim", "12122", 10000);
            //Console.WriteLine();
            Console.WriteLine();
            a4.ShowInfo();
            a4.Deposit(100000);
            a4.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||Saving Account Withdraw Check|||||||||||||||||||||||"); 
            Console.WriteLine();
            
            a4.Withdraw(8800);
            a4.ShowInfo();


            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||Special Savings Account Check|||||||||||||||||||||||");
            Console.WriteLine();
            SpecialSavings s1= new SpecialSavings("kahim", "12123", 10000);
            SpecialSavings s2 = new SpecialSavings("Fahim", "12124", 10000);
            Console.WriteLine();
            s1.ShowInfo();
            s1.Deposit(100000);
            s1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||Special Savings Account Withdraw Check|||||||||||||||||||||||");
            Console.WriteLine();

            s2.Withdraw(3300);
            s2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||OverDraft Account Check|||||||||||||||||||||||");
            Console.WriteLine();
            Overdraft o1 = new Overdraft("Zahim", "12123", 10000);
            Overdraft o2 = new Overdraft("Jahim", "12124", 10000);
            Console.WriteLine();
            o1.ShowInfo();
            o1.Deposit(100000);
            o1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||OverDraft Account Withdraw Check|||||||||||||||||||||||");
            Console.WriteLine();

            o2.Withdraw(3300);
            o2.ShowInfo();

        }
    }
}
