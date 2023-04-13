
using EmployeeToStringEqualsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeA = new Employee(1, "Ravi", 120920);
            var employeeB = new Employee(1, "Ravi", 12092);
            //Console.WriteLine(employeeA);
            //Console.WriteLine(employeeA.ToString());
            //Console.WriteLine(employeeA.GetType());

            //referance equality
            Console.WriteLine("Referance equality A & B :{0}",employeeA == employeeB);
            var employeeC = employeeB;
            Console.WriteLine("Reference equality C & B :{0}",employeeC== employeeB);
            //value based equality 
            Console.WriteLine("value equality A & B {0}",employeeA.Equals(employeeB));


        }
    }
}
