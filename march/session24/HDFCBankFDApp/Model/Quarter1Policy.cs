using FixedDepositCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankFDApp.Model
{
    internal class Quarter1Policy : IRatePolicy
    {
        public double CalculateRate()
        {
            return 0.5;
        }
    }
}
