
using FixDepositCoreLib.Model;

namespace AxisBankFDApp.Policy
{
    public delegate double DCalculateRate();
    internal class DiwaliRatePolicy
    {
        public double CalculateRate()
        {
            return .08;
        }
    }
}
