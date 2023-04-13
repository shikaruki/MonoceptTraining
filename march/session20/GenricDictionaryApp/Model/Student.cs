using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricDictionaryApp.Model
{
    internal class Student
    {
        private int _roll;
        private string _name;
        private int _standard;
        public Student(int standarad,int roll,string name ) { 
            _roll = roll;
            _name = name;
            _standard = standarad;
        }
        
        public int Roll { get { return _roll; }
            set { _roll = value; } }
        public string Name { get { return _name;}
            set { _name = value; }
        
        }
        public int Standard { get { return _standard;} set { if (value > 0 && value<=12)_standard = value; } }
        public override int GetHashCode()
        {
            return (this.Standard +""+this.Roll).GetHashCode();
        }
        
        public override bool Equals(object? second)
        {
            if (second == null)
                return false;
            Student other = (Student)second;
            return this.Standard == other.Standard;

        }
    }
}
