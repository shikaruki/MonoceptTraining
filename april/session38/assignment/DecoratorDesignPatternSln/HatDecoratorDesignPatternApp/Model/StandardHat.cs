using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorDesignPatternApp.Model
{
    internal class StandardHat:IHat
    {
        public string GetName()
        {
            return "Standard Hat";
        }

        public double GetPrice()
        {
            return 25.0;
        }

        public string GetDescription()
        {
            return "A standard, no-feather's hat.";
        }
    }
}
