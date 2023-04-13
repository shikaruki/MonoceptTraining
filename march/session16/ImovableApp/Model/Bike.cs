using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImovableApp.Model
{
    internal class Bike : Vehicle
    {
        
        public Bike(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Bike move "+_name);
        }
    }
}
