using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorDesignPatternApp.Model.Decorator
{
    internal class GoldenHat : HatDecorator
    {
        public GoldenHat(IHat hat) : base(hat)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 50.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " It is a golden coloured hat.";
        }
    }
}
