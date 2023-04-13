using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionaryApp.Model
{
    internal class Student
    {
        private int _roll;
        private string _name;
        private int _standard;
        public Student(int roll, string name,int standard)
        {
            _roll = roll;
            _name = name;
            _standard = standard;
        }

    }
}
