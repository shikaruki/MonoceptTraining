using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class Devloper : Employee
    {
        private double _performanceAllowance;
        public Devloper(int id, string name, double basicSalary) :
            base(id, name, basicSalary)
        {
            _performanceAllowance = basicSalary * .50;
        }
        public double PerformanceAllowance
        {
            get { return _performanceAllowance; }
        }

        public override double AnnualCostToCompany
        {
            get { return (BasicSalary + _performanceAllowance) * 12; }
        }

        public override string Role
        {
            get
            {
                return "Devloper";
            }
        }

        public override string SalaryBreakUp
        {
            get
            {
                return "Performance Allowance : " + _performanceAllowance;
            }
        }
    }
}
