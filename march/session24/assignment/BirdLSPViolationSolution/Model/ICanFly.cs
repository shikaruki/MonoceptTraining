using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLSPViolationSolution.Model
{
    internal interface ICanFly
    {
        public string Name { get; set; }
        bool CanFly();
    }
}
