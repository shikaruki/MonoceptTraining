using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceDesignPatternApp.Model
{
    internal interface ICarService
    {
        double GetCost();
        string GetDetails();
    }
}
