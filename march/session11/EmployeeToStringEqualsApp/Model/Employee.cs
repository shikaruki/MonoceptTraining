using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualsApp.Model
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;
        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }
        public override bool Equals(object box)
        {
            Employee second = (Employee)box;
            if(this.Id == second.Id && second.Name== this.Name)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"\nid is {_id} \nName is {_name}\nSalary is {_salary}";
        }
        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public double Salary { get { return _salary;} }

    }
}
