using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternApp.Model
{
    internal class Add : ICalculateInterface
    {
        public int Calculate(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
