﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model
{
    internal class QualityAnalyst : Employee
    {
        public QualityAnalyst(double basic, string name, int id) : base(basic, name, id)
        {
        }

        public override double CalculateAnnualSalary(double salary)
        {
            throw new NotImplementedException();
        }
    }
}
