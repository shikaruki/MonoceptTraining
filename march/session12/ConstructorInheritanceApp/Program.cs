using ConstructorInheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy3()
        {
            ChildV2 childA = new ChildV2(30);
            Console.WriteLine(childA.Age);
        }
        private static void CaseStudy2()
        {
            ChildV2 childA = new ChildV2();
            Console.WriteLine(childA.Age);
            ChildV2 childB = new ChildV2();
            Console.WriteLine(childB.Age);
        }
        private static void CaseStudy1()
        {
            new ChildV1();
        }
    }
}
