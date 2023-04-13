using EmployeePolymorphism.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager(101, "vishak", 20000);
            var devloper = new Devloper(102, "ravi", 15000);

            PrintSalarySlipToConsole(manager);
            PrintSalarySlipToConsole(devloper);

            PrintSalarySlipToHTMLFile(manager);
            PrintSalarySlipToHTMLFile(devloper);
        }

        static void PrintSalarySlipToConsole(Employee employee)
        {
            Console.WriteLine("Employee ID : {0}", employee.Id);
            Console.WriteLine("Employee Name : {0}", employee.Name);
            Console.WriteLine("Employee basic : {0}", employee.BasicSalary);
            Console.WriteLine("Employee ctc : {0}", employee.AnnualCostToCompany);
            Console.WriteLine("Employee Role : {0}", employee.Role);
            Console.WriteLine("Employee Salary BreakUp is : {0}", employee.SalaryBreakUp);

            /*if (employee is Manager)
                Console.WriteLine("Employee Role : Manager");
            else if(employee is Devloper)
                Console.WriteLine("Employee Role : Devloper);*/

            Console.WriteLine();
        }

        static void PrintSalarySlipToHTMLFile(Employee employee)
        {
            StreamWriter sw = new StreamWriter(employee.Name + ".html");
            sw.WriteLine("<body>");
            sw.WriteLine("<H1>");

            sw.WriteLine("Employee ID : {0}<br>", employee.Id);
            sw.WriteLine("Employee Name : {0}<br>", employee.Name);
            sw.WriteLine("Employee basic : {0}<br>", employee.BasicSalary);
            sw.WriteLine("Employee ctc : {0}<br>", employee.AnnualCostToCompany);
            sw.WriteLine("Employee Role : {0}<br>", employee.Role);
            sw.WriteLine("Employee Salary BreakUp is : {0}<br>", employee.SalaryBreakUp);

            sw.WriteLine("</H1>");
            sw.WriteLine("</body>");
            sw.Close();

            Console.WriteLine("Written to File");


        }
    }
}
