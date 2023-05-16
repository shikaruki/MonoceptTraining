using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorDesignPatternApp.Model
{
    internal interface IHat
    {
        string GetName();
        double GetPrice();
        string GetDescription();
    }
}
