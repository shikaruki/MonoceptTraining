using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImmutiablityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            string userName = "Ravi";
            userName.ToUpper();
            Console.WriteLine(userName);

        }
        private static void CaseStudy2()
        {
            string userName = "Monocept";
            Console.WriteLine(userName.GetHashCode());
            userName += " Ravi ";
            Console.WriteLine(userName.GetHashCode());
            userName += " in gurgaon";
            Console.WriteLine(userName.GetHashCode());
            Console.WriteLine(userName);
        }
        private static void CaseStudy3() { 
        StringBuilder userName = new StringBuilder();
            Console.WriteLine(userName.GetHashCode());
            userName.Append("Monocept");
            Console.WriteLine(userName.GetHashCode());
            userName.Append("ravi");
            Console.WriteLine(userName.GetHashCode());
            userName.Append("is at Gurgaon");
            Console.WriteLine(userName.GetHashCode());
            Console.WriteLine(userName);

        }
    }
}
