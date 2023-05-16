using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorDesignPatternApp.Model.Decorator
{
    internal class HatDecorator:IHat
    {
        private IHat _hat;

        public HatDecorator(IHat hat)
        {
            _hat = hat;
        }

        public virtual string GetName()
        {
            return _hat.GetName();
        }

        public virtual double GetPrice()
        {
            return _hat.GetPrice();
        }

        public virtual string GetDescription()
        {
            return _hat.GetDescription();
        }
    }
}
