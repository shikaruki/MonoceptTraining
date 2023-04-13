using FixedDepositCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankFDApp.Model
{
    internal class NewYearPolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            return 0.08;
        }
    }
}
