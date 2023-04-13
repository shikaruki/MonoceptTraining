using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Boy : IEmotional ,IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Boy Good by");
        }

        public void Wish()
        {
            Console.WriteLine("Boy Hii ..");
        }

        void IEmotional.Cry()
        {
            Console.WriteLine("Boy Cry ");
        }
        void IEmotional.Laugh()
        {
            Console.WriteLine("Boy Laugh");
        }
    }
}
