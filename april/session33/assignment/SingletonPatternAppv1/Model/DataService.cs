using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAppv1.Model
{
    internal class DataService
    {
        private DataService() {
            Console.WriteLine("Data Service Created");
        }

        internal void DoSomething()
        {
            Console.WriteLine("Processing Data by " + this.GetHashCode());
            Console.WriteLine();
        }
        public static DataService GetInstance()
        {
            return new DataService();
        }
    }
}
