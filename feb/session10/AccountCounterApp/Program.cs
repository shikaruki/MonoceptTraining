using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCounterApp
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
            Account acc1 = new Account(100, "ravi");
            Console.WriteLine(acc1.InstanceCount);

            Account acc2 = new Account(101, "Jishu");
            Console.WriteLine(acc1.InstanceCount);

            Account acc3 = new Account(102, "Surkhi");
            Console.WriteLine(acc1.InstanceCount);

        }
        public static void CaseStudy2()
        {
            Account acc1 = new Account(100, "ravi");
            Console.WriteLine(acc1.InstanceCountWithoutStatic);

            Account acc2 = new Account(101, "Jishu");
            Console.WriteLine(acc1.InstanceCountWithoutStatic);

            Account acc3 = new Account(102, "Surkhi");
            Console.WriteLine(acc1.InstanceCountWithoutStatic);
        }
    }
}
