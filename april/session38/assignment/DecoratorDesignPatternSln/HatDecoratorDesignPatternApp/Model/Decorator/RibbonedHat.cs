using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorDesignPatternApp.Model.Decorator
{
    internal class RibbonedHat:HatDecorator
    {
        public RibbonedHat(IHat hat) : base(hat)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " It comes with a ribbon.";
        }
    }
}
