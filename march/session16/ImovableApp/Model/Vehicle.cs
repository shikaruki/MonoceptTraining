using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImovableApp.Model
{
    abstract class Vehicle : Imovable
    {
        public string _name;
        public Vehicle(string name)
        {
            _name = name;
        }
        public string Name { get { return _name; } }
        public abstract void Move();
        
    }
}
