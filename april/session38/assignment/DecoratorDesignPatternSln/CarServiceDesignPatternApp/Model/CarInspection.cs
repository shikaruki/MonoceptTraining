using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceDesignPatternApp.Model
{
    internal class CarInspection :  ICarService
    {
        public double GetCost()
        {
            return 250;
        }

        public string GetDetails()
        {
            return "Standard Car Inspection";
        }
    }
}
