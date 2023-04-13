using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Model
{
    internal class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man Play Chess");
        }
        public void Read() { Console.WriteLine("Man Read Book"); }
    }
}
