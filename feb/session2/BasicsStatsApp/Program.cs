using System;
namespace BasicsStatsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please Enter SomeValue to Perform Operations. ");
            }
            else
            {
                Console.WriteLine("Count : " + args.Length);
                double sum = 0.0;
                double max = double.MinValue;
                for (int i = 0; i < args.Length; i++)
                {
                    double temp = Convert.ToDouble(args[i]);
                    max = max < temp ? temp : max;
                    sum += temp;
                }
                Console.WriteLine("Sum : " + sum);
                Console.WriteLine("Avg : " + sum / args.Length);
                Console.WriteLine("Max : " + max);
            }
        }
    }
}
