using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorApp.Model
{
    public abstract class Person
    {
        private readonly int _id;
        private string _address;
        private string _name;
        private string _dateOfBirth;
        
        
        public Person(int id, string address, string dateOfBirth,string name)
        {
            _id = id;
            _address = address;
            _dateOfBirth = dateOfBirth;
            _name = name;
        }
        public int Id { get { return _id; } }
        public string Address { get { return _address; }set { _address = value; } }
        public string Name { get { return _name; } }
        public string DateOfBirth { get { return _dateOfBirth; } }
        public abstract string Role { get; }
        public abstract double Salary { get; }

    }
}
