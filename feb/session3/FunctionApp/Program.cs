using System;

namespace FunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            //PrintName("ravi", 10);
            Console.WriteLine(CheckIsEven1(1));
            Console.WriteLine(CheckIsEven2(2));
            Console.WriteLine(CheckIsEven3(3));
            Console.WriteLine(CheckIsEven4(4));
            PrintTodayDate();
            //Console.WriteLine(GetDevloperNames());

            //string[] devName = GetDevloperNames();
            //foreach(string name in devName)
            //{
            //    Console.WriteLine(name.ToUpper());
            //}
        }

        static bool CheckIsEven1(int input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
        static bool CheckIsEven2(int input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static bool CheckIsEven3(int input)
        {
            return (input % 2 == 0);
        }
        static string CheckIsEven4(int input)
        {
            return (input % 2 == 0) ? "Even No" : "Odd NO."; 
        }

        static void RollDice(int rolls)
        {
            if (rolls < 1)
            {
                Console.WriteLine("Invalid input : number of rolls must be at least 1.");
                return;
            }
            Random rand = new Random();
            Console.WriteLine("Rolling dice. . ...");
            for (int i = 0; i < rolls; i++)
            {
                int rollResult = rand.Next(1, 7);
                Console.WriteLine("{0} time {1}", i, rollResult);
            }
        }
        private static void PrintTodayDate()
        {
            Console.WriteLine(DateTime.Now.ToString("M"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
        }
        private static string[] GetDevloperNames()
        {
            string[] devNames = { "abc", "def", "ghi", "jkl", "mnb" };
            return devNames;
        }


        static void PrintName(string userName, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine(userName.ToUpper());
            }
        }
    }
}
