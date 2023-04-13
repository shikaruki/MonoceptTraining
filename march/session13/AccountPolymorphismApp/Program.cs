using AccountApp.Model;
using AccountPolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        {
            SavingAccount acc1 = new SavingAccount(100, "Ravi", 5000);
            PrintDetails(acc1, "acc1 Saving Account");
            acc1.Deposit(500);
            PrintDetails(acc1, "Acc1 deposited 500");
           // acc1.Withdraw(5000);
            PrintDetails(acc1, "Acc1 Withdraw 5000 , Must give no sufficient Funds");
        }

        private static void CaseStudy2()
        {
            CurrentAccount acc2 = new CurrentAccount(101, "Jishu", 200);
            PrintDetails(acc2, "acc2 Current Account Details");
            acc2.Deposit(500);
            PrintDetails(acc2, "acc2 Current Accoutn Deposited with 500");
            acc2.Withdraw(5500);
            PrintDetails(acc2, "acc2 Current Account Withdraw with 5500 didn't give error");
           // acc2.Withdraw(300); // Give OverDraft LimitExceeds 
            PrintDetails(acc2, "Details of acc2 Current Account After OverDraft Limit Exceeds ");
        }
        static void PrintDetails(Account account, string description)
        {
            Console.WriteLine();
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Account NO : {0}", account.AccountNo);
            Console.WriteLine("Name : {0}", account.Name);
            Console.WriteLine("Balance : {0}", account.Balance);
            Console.WriteLine();
        }
    }
}
