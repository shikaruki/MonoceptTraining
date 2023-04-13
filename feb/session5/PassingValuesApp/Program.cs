using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValuesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();

            //CaseStudy4();
            CaseStudy5();
        }
        private static void CaseStudy1()
        {
            int mark = 100;
            UpdateMarkValue(mark);
            Console.WriteLine("CaseStudy1 MarkValue is {0}", mark);
        }

        private static void CaseStudy2()
        {
            int mark = 1000;
            UpdateMarkValue1(ref mark);
            Console.WriteLine("Case study2 MarkValue is {0}", mark);
        }

        private static void CaseStudy3()
        {
            int[] score = { 10, 20, 30, 40 };
            foreach (int mark in score)
            {
                Console.WriteLine(mark);
            }
            UpdateMarkValue3(ref score);
            foreach (int mark in score)
            {
                Console.WriteLine(mark);
            }
            Console.WriteLine(score.GetHashCode());

            string input = Console.ReadLine();
            int num;
            if (int.TryParse(input, out num))
            {
                Console.WriteLine(num * num);
            }
            else
            {
                Console.WriteLine(input + "is not a number");
            }
        }

        private static void CaseStudy4()
        {
            int sum, avg, pro;
            Calculate(10, 20, 30, out sum, out avg, out pro);
            Console.WriteLine("sum = {0}\navg = {1}\npro = {2}", sum, avg, pro);

        }

        private static void CaseStudy5()
        {
            Console.WriteLine("", 10, 20, 30, 40, 50, 60, 70, 80);
            Console.WriteLine(DisplayMultiplication(first:10));
            Console.WriteLine(DisplayMultiplication(first:10,20,30,40) );
        }
        private static int DisplayMultiplication(int first,params int[] array)
        {
            int product = first;
            foreach (int i in array)
            {
                product *= i;
            }
            return product;

        }
        private static void Calculate(int input1, int input2, int input3, out int sum, out int avg, out int pro)
        {
            sum = input1 + input2 + input3;
            avg = sum / 3;
            pro = input1 * input2 * input3;
        }

        private static void UpdateMarkValue3(ref int[] score)
        {
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = 0;
            }
        }
        private static void UpdateMarkValue(int mark)
        {
            mark = 0;
        }
        private static void UpdateMarkValue1(ref int mark)
        {
            mark = 0;
        }
    }
}
