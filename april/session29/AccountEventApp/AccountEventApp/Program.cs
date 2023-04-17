using AccountEventApp.Model;
using System;

namespace AccountEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Ravi");
            acc1.OnBalanceChange += (acc){
                Console.WriteLine("sending mail to :" + acc.Name);
                Console.WriteLine("Balance Changed to : " + acc.Balance);
            };
            acc1.OnBalanceChange += (acc){
                Console.WriteLine("sending sms to :" + acc.Name);
                Console.WriteLine("Balance Changed to : " + acc.Balance);
            };
            acc1.OnBalanceChange += (acc){
                Console.WriteLine("sending whats'app to :" + acc.Name);
                Console.WriteLine("Balance Changed to : " + acc.Balance);
            };
            acc1.Deposit(1000);
        }
        static void SendSms(Account acc)
        {
            Console.WriteLine("sending sms to :"+acc.Name);
            Console.WriteLine("Balance Changed to : " + acc.Balance);
        }
        static void SendEmail(Account acc)
        {
            Console.WriteLine("sending mail to :" + acc.Name);
            Console.WriteLine("Balance Changed to : " + acc.Balance);
        }
    }
}