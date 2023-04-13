using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model
{
    internal class Manager : Employee
    {
        private double _ta;
        private double _da;
        private double _hra;
        public Manager(double basic, string name, int id, double ta, double da, double hra) : base(basic, name, id)
        {
            _ta = ta;
            _da = da;
            _hra = hra;
        }

        public override double CalculateAnnualSalary(double salary)
        {
            throw new NotImplementedException();
        }
    }
}
