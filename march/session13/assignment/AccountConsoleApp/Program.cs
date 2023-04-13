using System;
using AccountLibrary;

namespace AccountConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountA = new Account(101, "Ravi Kumar", 1000);
            PrintDetails(accountA,"Details of Account A");
            accountA.Deposit(5000);
            PrintDetails(accountA, "After Deposit Operation on Account A");
            accountA.Withdraw(5000);
            PrintDetails(accountA, "After Withdraw Operation on Account A");
            accountA.Withdraw(5000);
            PrintDetails(accountA, "Withdraw Operation on InSufficient Amount on");
        }
        private static void PrintDetails(Account account,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Account Number is : "+account.AccountNo);
            Console.WriteLine("Account Holder Name : "+ account.Name);
            Console.WriteLine("Ammount is : " + account.Balance);
            Console.WriteLine();
        }
    }
}
