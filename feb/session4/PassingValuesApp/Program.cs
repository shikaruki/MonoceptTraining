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
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            int mark = 100;
            UpdateMarkValue(mark);
            Console.WriteLine("CaseStudy1 MarkValue is {0}",mark);
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
            foreach(int mark in score)
            {
                Console.WriteLine(mark);
            }
            Console.WriteLine(score.GetHashCode());
        }
        private static void UpdateMarkValue3(ref int[] score)
        {
            for(int i = 0 ; i < score.Length;i++) 
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
