using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorApp.Model
{
    internal  class Professor : Person
    {
        private double _costToCompany;
        private double _salary;

        public Professor(int id, string address, string dateOfBirth, string name,double costToCompany) : base(id, address, dateOfBirth, name)
        {
            _costToCompany= costToCompany;
            _salary= CalculateSalary(_costToCompany);
        }
        private double CalculateSalary(double costToCompany)
        {
            int range = (int)costToCompany / 500000;
            switch (range)
            {
                case 0:
                    return costToCompany / 12.0;
                case 1:
                    return (costToCompany * .80) / 12;
                case 2:
                    return (costToCompany * .70) / 12;
                case 3:
                    return (costToCompany * .60) / 12;
                default:
                    return (costToCompany * .50) / 12;
            }
        }
        public double CostToCompany { get { return _costToCompany; } }
        public override double Salary { get { return _salary; } }
        public override string Role { get { return "Professor"; } }
    }
}
