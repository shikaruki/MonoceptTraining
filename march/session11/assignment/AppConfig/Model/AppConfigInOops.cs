using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfig.Model
{
    internal class AppConfigInOops
    {
        private NameValueCollection sAll;
        public AppConfigInOops()
        {
            sAll = ConfigurationManager.AppSettings;
        }
        public void PrintDetails()
        {
            foreach (string s in sAll.AllKeys)
                Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));
            Console.ReadLine();
        }
        public void PrintServerAndDatabase()
        {
            sAll = ConfigurationManager.AppSettings;
            foreach (string item in sAll)
            {
                string value = ConfigurationManager.AppSettings.Get(item);
                string[] words = value.Split(';');
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    string[] words2 = word.Split('=');
                    for (int j = 0; j < words2.Length; j++)
                        if (words2[j] == "server" || words2[j] == "database")
                        {
                            Console.Write(words2[j] + " : ");
                            Console.WriteLine(words2[j + 1]);
                            Console.WriteLine();
                        }
                }
            }
        }
        public string GetValueUsingKey(string key)
        { return sAll[key]; }

    }
}
