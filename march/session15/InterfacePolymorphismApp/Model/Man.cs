using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Man : IMannerable
    {
        void IMannerable.Wish()
        {
            Console.WriteLine("Man Hii ..");
        }
        void IMannerable.Depart()
        {
            Console.WriteLine("Man Good by");
        }
    }
}
