using AppConfig.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            //CaseStudy5();
        }
        public static void CaseStudy5()
        {
            AppConfigInOops appVAlue = new AppConfigInOops();
            appVAlue.PrintServerAndDatabase();
            appVAlue.GetValueUsingKey("step 1");
        }
        public static void CaseStudy1()
        {
            string step1 = System.Configuration.ConfigurationManager.AppSettings["step 1"];
            string step11 = ConfigurationManager.AppSettings.Get("step 1");
            string step2 = System.Configuration.ConfigurationManager.AppSettings["step 2"];
            string step22 = ConfigurationManager.AppSettings.Get("step 2");
            string step3 = System.Configuration.ConfigurationManager.AppSettings["step 3"];
            string step33 = ConfigurationManager.AppSettings.Get("step 3");

            string step4 = System.Configuration.ConfigurationManager.AppSettings["step 4"];
            string step44 = ConfigurationManager.AppSettings.Get("step 4");

            string step5 = System.Configuration.ConfigurationManager.AppSettings["step 5"];
            string step55 = ConfigurationManager.AppSettings.Get("step 5");

            string step6 = System.Configuration.ConfigurationManager.AppSettings["step 6"];//this when there is no any key value of name step 6 then nothig get printed
            Console.WriteLine("Question 1: ");
            Console.WriteLine(step1);
            Console.WriteLine(step2);
            Console.WriteLine(step3);
            Console.WriteLine(step4);
            Console.WriteLine(step5);
            Console.WriteLine(step11);
            Console.WriteLine();
            Console.WriteLine(step6);
        }

        public static void CaseStudy2()
        {
            //Read specfic keys and value using key name
            string value1 = System.Configuration.ConfigurationManager.AppSettings["connection1"];
            string value2 = System.Configuration.ConfigurationManager.AppSettings["connection1"];
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            string[] words = value1.Split(';');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string[] words2 = word.Split('=');
                for (int j = 0; j < words2.Length; j++)
                    if (words2[j] == "server" || words2[j] == "database")
                    {
                        Console.Write(words2[j] + " : ");
                        Console.WriteLine(words2[j + 1]);
                    }
            }
        }
        public static void CaseStudy3()
        {
            // Read all the keys from the config file
            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;
            foreach (string s in sAll.AllKeys)
                Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));
            Console.ReadLine();
        }
        public static void CaseStudy4()
        {
            string str;
            // Read a particular key from the config file 
            str = ConfigurationManager.AppSettings.Get("connection1");
            Console.WriteLine("The value of connection 1: " + str);

            // Read all the keys from the config file
            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;

            foreach (string s in sAll.AllKeys)
                Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));
            Console.ReadLine();
        }
    }
}
