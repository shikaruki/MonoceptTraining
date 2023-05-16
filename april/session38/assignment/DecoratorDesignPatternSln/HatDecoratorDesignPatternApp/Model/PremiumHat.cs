using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorDesignPatternApp.Model
{
    internal class PremiumHat:IHat
    {
        public string GetName()
        {
            return "Premium Hat";
        }

        public double GetPrice()
        {
            return 50.0;
        }

        public string GetDescription()
        {
            return "A Premuim, with feathers hat.";
        }
    }
}
