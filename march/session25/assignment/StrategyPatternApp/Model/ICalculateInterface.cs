﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternApp.Model
{
    internal interface ICalculateInterface
    {
        int Calculate(int value1, int value2);
    }
}
