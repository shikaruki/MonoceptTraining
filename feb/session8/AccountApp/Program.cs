using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountA = new Account(100,"Ravi");
            Console.WriteLine("Name : "+accountA.Name);
            Console.WriteLine("Account No. : " + accountA.AccountNo);
            Console.WriteLine("Balance : " + accountA.Balance);

            Account accountB = new Account(101, "Shikaruki", 5004);
            Console.WriteLine( );
            Console.WriteLine("Name : "+accountB.Name);
            Console.WriteLine("Account No. : "+accountB.AccountNo);
            Console.WriteLine("Balance : "+accountB.Balance);

            Console.WriteLine();
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            Account accountA = new Account(1001, "Ravi", 1500);
            accountA.Withdraw(1000);
            PrintDetails(accountA);
        }

        private static void CaseStudy3()
        {
            Account accountA = new Account(1001, "Ravi");
            accountA.Deposit(1000);
            PrintDetails(accountA);
        }
        private static void CaseStudy2()
        {
            Account accountA = new Account(1002, "Ravi", 1000);
            PrintDetails(accountA);
        }
        private static void CaseStudy1()
        {

            Account accountA = new Account(1002, "Ravi");
            PrintDetails(accountA);
        }
        static void PrintDetails(Account account)
        {
            Console.WriteLine();
            Console.WriteLine("Name : " + account.Name);
            Console.WriteLine("Account No. : " + account.AccountNo);
            Console.WriteLine("Balance : " + account.Balance);
        }
    }
}
