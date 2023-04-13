using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAppv1.Model
{
    internal class DataService
    {
        private static DataService? _bucket;
        private DataService()
        {
            Console.WriteLine("Data Service Created");
        }

        internal void DoProcessing()
        {
            Console.WriteLine("Processing Data by " + this.GetHashCode());
        }
        public static DataService GetInstance()
        {
            if (_bucket == null)
                _bucket = new DataService();
            return _bucket;
        }
    }
}
