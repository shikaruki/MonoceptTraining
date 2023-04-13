using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactoryCoreLib.Factory
{
    internal class BMW : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("BMW Starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW Stopping"  );
        }
    }
}
