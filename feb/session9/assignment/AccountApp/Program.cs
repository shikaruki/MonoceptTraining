using AccountApp.Model;
using System;
namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountA = new Account("Ravi kumar", 1020000);
            Account accountB = new Account("Raj", 10200);
            Account accountC = new Account("jishu", 910200);
            Account accountD = new Account("Surkhia", 190900);

            Account[] manyAccounts = new Account[] { accountA, accountB, accountC, accountD };
            foreach (Account manyAccount in manyAccounts)
                PrintDetails(manyAccount, "AccountDetails");

            Account rich = new Account();
            foreach (Account account in manyAccounts)
            {
                rich = account.WhoIsReachest(rich);
            }
            Account[] longestNameList = WhoHasLongestName(manyAccounts);
            foreach (Account account in longestNameList)
                PrintDetails(account, "Account Details of Longest NamePerson");
            PrintDetails(rich, "Account Details of Richest Person");
        }
        public static Account[] WhoHasLongestName(Account[] paccount)
        {
            int count = 0;
            foreach (Account p in paccount)
            {
                if (p.Name.Length >= 7)
                    count++;
            }
            Account[] longestNameArray = new Account[count];
            int index = 0;
            foreach (Account p in paccount)
            {

                if (p.Name.Length >= 7)
                    longestNameArray[index++] = new Account(p);
            }
            return longestNameArray;
        }
        public static void PrintDetails(Account account, string description)
        {

            Console.WriteLine(description.ToUpper());
            Console.WriteLine();
            Console.WriteLine("Name : " + account.Name);
            Console.WriteLine("BAlance : " + account.Balance);
            Console.WriteLine();
        }
    }
}
