using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class Manager : Employee
    {
        private double _houseRentAllowance;
        private double _travellingAllowance;
        public Manager(int id, string name, double basicSalary) :
            base(id, name, basicSalary)
        {
            _houseRentAllowance = basicSalary * .60;
            _travellingAllowance = basicSalary * .50;
        }
        public double HouseRentAllowance
        {
            get { return _houseRentAllowance; }
        }
        public double TravellingAllowance
        {
            get { return _travellingAllowance; }
        }
        public override double AnnualCostToCompany
        {
            get { return (BasicSalary + _houseRentAllowance + _travellingAllowance) * 12; }
        }
        public override string Role
        {
            get
            {
                return "Manager";
            }
        }

        public override string SalaryBreakUp
        {
            get
            {
                string FormattedSalaryBrakUp = "";
                FormattedSalaryBrakUp += "HouseRent Allowance : " + _houseRentAllowance;
                FormattedSalaryBrakUp += ",Trevelling Allowance : " + _travellingAllowance;
                return FormattedSalaryBrakUp;
            }
        }

    }
}
