using System;
namespace OverLoadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(12);
            PrintDetails(12.5);
            PrintDetails('a');
            PrintDetails("Ravi");
            PrintDetails(12.55f);
            PrintDetails(5 < 3);
        }

        private static void PrintDetails(int input)
        {
            Console.WriteLine("input integer printed {0}",input);
        }
        private static void PrintDetails(float input)
        {
            Console.WriteLine("inputed float is printed {0}", input);
        }
        private static void PrintDetails(double input)
        {
            Console.WriteLine("inputed double is printed {0}", input);
        }
        private static void PrintDetails(char input)
        {
            Console.WriteLine("inputed char is printed {0} and ascii is {1}", input,(int)input);
        }
        private static void PrintDetails(string input)
        {
            Console.WriteLine("inputed string is printed {0}",input);
        }
        private static void PrintDetails(bool input)
        {
            Console.WriteLine("inputed bool is printed {0}",input);
        }
    }
}
