using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model
{
    internal abstract class Employee
    {
        protected double _basic;
        protected string _name;
        protected int _id;
        public Employee(double basic, string name, int id)
        {
            _basic = basic;
            _name = name;
            _id = id;
        }
        public string Name
        {
            get { return _name; }
        }
        public int Id
        {
            get { return _id; }
        }
        public double Basic
        {
            get { return _basic; }
        }
        public abstract double CalculateAnnualSalary(double salary);
    }
}
