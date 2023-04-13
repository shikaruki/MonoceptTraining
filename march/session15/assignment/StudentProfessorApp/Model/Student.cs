using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorApp.Model
{
    internal class Student : Person
    {
        private string _branch;

        public Student(int id, string address, string dateOfBirth, string name,string branch) : base(id, address, dateOfBirth, name)
        {
            _branch = branch;
        }
        public string Branch { get { return _branch; } }
        public override string Role { get { return "Student"; } }

        public override double Salary => throw new NotImplementedException();
    }
}
