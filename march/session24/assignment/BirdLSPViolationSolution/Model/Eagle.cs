using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLSPViolationSolution.Model
{
    internal class Eagle : ICanFly
    {
        public Eagle(string name)
        { Name = name; }

        public string Name { get ; set; }

        public bool CanFly()
        {
            return true;
        }
    }
}
