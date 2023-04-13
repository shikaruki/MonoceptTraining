using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Model
{
    internal class Boy : Man
    {
        public void Eat()
        {
            Console.WriteLine("Boy Eat");
        }
        public override void Play()
        {
            Console.WriteLine("boy play cricket");
        }
    }
}
