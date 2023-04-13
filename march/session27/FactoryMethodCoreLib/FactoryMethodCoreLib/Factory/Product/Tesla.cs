using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory.Product
{
    internal class Tesla : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla Stopping");
        }
    }
}
