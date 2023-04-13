using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceArrayPolymorphismApp.Model
{
    internal class Car : IEMoveble
    {
        private string _name;
        public Car(string name)
        {
            _name = name;
        }
        public void Move()
        {
            Console.WriteLine("Car move : {0}",_name);
        }
    }
}
