using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceArrayPolymorphismApp.Model
{
    internal class Truck : IEMoveble
    {
        private string _name;
        public Truck(string name ) {
        _name= name;
        }
        public void Move()
        {
            Console.WriteLine("Truck Move : {0}",_name);
        }
    }
}
