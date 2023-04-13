using System.Collections.Generic;
using System.Security.AccessControl;
using System;
using CustomerHashSetApp.Model;

namespace CustomerHashSetApp
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
            HashSet<string> userNames = new HashSet<string>();
            userNames.Add("Ravi");
            userNames.Add("RAj");
            userNames.Add("Subh");
            userNames.Add("ravi");
            userNames.Add("Subh");
            Console.WriteLine(userNames.Count);
            foreach (string name in userNames)
            {
                Console.WriteLine(name);
            }
        }
        private static void CaseStudy2()
        {
            HashSet<int> scores = new HashSet<int>();
            scores.Add(1);
            scores.Add(2);
            scores.Add(3);
            
            scores.Add(1);
            scores.Add(2);
            scores.Add(3);

            scores.Add(4);
            Console.WriteLine(scores.Count);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        private static void CaseStudy3()
        {
            Customer c1 = new Customer(1, "Anekant");
            Customer c2 = new Customer(1, "Anekantabc");
            Customer c3 = new Customer(2, "Ekta");
            HashSet<Customer> customers= new HashSet<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            Console.WriteLine(customers.Count);
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.GetHashCode());
            }
        }
    }
}