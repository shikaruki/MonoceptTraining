using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactoryCoreLib.Factory
{
    internal class Tesla : IAutoMobile
    {
        public IAutoMobile Make()
        {
            return new Tesla();
        }

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
