using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceArrayPolymorphismApp.Model
{
    internal class Bike : IEMoveble
    {
        private string _name;
        public Bike(string name)
        {
            _name = name;
        }
        public void Move()
        {
            Console.WriteLine("Bike Move : {0}",_name);
        }
    }
}
