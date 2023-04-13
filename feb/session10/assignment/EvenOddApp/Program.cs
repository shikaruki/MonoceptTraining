using EvenOddApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.WriteLine();
            CaseStudy2();
        }
        public static void CaseStudy1()
        {
            Even even1 = new Even(21);
            int[] evenNo1 = even1.GetEven();
            PrintDetails(evenNo1, "even no in range ", 1, 21);

            Even even2 = new Even(20);
            int[] evenNo2 = even2.GetEven();
            PrintDetails(evenNo2, "even no in range ", 1, 20);

            Even even3 = new Even(21, 31);
            int[] evenNo3 = even3.GetEven();
            PrintDetails(evenNo3, "even no in range ", 21, 31);

            Even even4 = new Even(20, 31);
            int[] evenNo4 = even4.GetEven();
            PrintDetails(evenNo4, "even no in range ", 20, 31);

            Even even5 = new Even(21, 30);
            int[] evenNo5 = even5.GetEven();
            PrintDetails(evenNo5, "even no in range ", 21, 30);

            Even even6 = new Even(20, 30);
            int[] evenNo6 = even6.GetEven();
            PrintDetails(evenNo6, "even no in range ", 20, 30);
        }

        public static void CaseStudy2()
        {
            Odd odd1 = new Odd(21);
            int[] oddNo1 = odd1.GetOdd();
            PrintDetails(oddNo1, "odd no in range ", 1, 21);

            Odd odd2 = new Odd(20);
            int[] oddNo2 = odd2.GetOdd();
            PrintDetails(oddNo2, "odd no in range ", 1, 20);

            Odd odd3 = new Odd(20, 30);
            int[] oddNo3 = odd3.GetOdd();
            PrintDetails(oddNo3, "odd no in range ", 20, 30);

            Odd odd4 = new Odd(20, 31);
            int[] oddNo4 = odd4.GetOdd();
            PrintDetails(oddNo4, "odd no in range ", 20, 31);

            Odd odd5 = new Odd(21, 30);
            int[] oddNo5 = odd5.GetOdd();
            PrintDetails(oddNo5, "odd no in range ", 21, 30);

            Odd odd6 = new Odd(21, 31);
            int[] oddNo6 = odd6.GetOdd();
            PrintDetails(oddNo6, "odd no in range ", 21, 31);
        }
        public static void PrintDetails(int[] no, string description, int range1, int range2)
        {
            Console.WriteLine(description.ToUpper() + " {0} to {1} .", range1, range2);
            foreach (int i in no)
                Console.Write(" " + i);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
