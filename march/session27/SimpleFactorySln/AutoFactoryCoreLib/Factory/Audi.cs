using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactoryCoreLib.Factory
{
    internal class Audi : IAutoMobile
    {
        public IAutoMobile Make()
        {
            return new Audi();
        }

        public void Start()
        {
            Console.WriteLine("Audi Starting"  );
        }

        public void Stop()
        {
            Console.WriteLine("Audi Stopping");
        }
    }
}
