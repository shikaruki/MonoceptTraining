using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory.Product
{
    internal class Audi : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Audi Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi Stopping");
        }
    }
}
