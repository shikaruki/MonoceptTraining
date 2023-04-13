using StudentProfessorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(101, "Gaya", "15-10-1997", "Ravi", "MCA");
            Student student2 = new Student(102, "Rasalpur", "12-08-1998", "Jishu", "B-tech");
            Professor professor1 = new Professor(103, "JamNagar", "23-01-1998", "Hitlar", 1300000);
            Professor professor2 = new Professor(104, "Gurgaon", "26-11-1998", "Ruby", 800000);
            PrintDetailsOfStudent(student1);

            PrintDetailsOfStudent(student2);

            PrintDetailsOfProfessor(professor1);

            PrintDetailsOfProfessor(professor2);


        }
        static void PrintDetailsOfStudent(Student person)
        {
            Console.WriteLine();
            Console.WriteLine("ID : {0}", person.Id);
            Console.WriteLine("NAme : {0}", person.Name);
            Console.WriteLine("D-O-B : {0}", person.DateOfBirth);
            Console.WriteLine("Address : {0}", person.Address);
            Console.WriteLine("Role : {0}", person.Role);
            Console.WriteLine("Branch :{0}", person.Branch);
            Console.WriteLine();
        }
        private static void PrintDetailsOfProfessor(Professor professor)
        {
            Console.WriteLine("Professor Details : ");
            Console.WriteLine("Id of Professor : " + professor.Id);
            Console.WriteLine("Address of Professor : " + professor.Address);
            Console.WriteLine("Date of Birth of Professor : " + professor.DateOfBirth);
            Console.WriteLine("Annual Salary of Professor is : " + professor.Salary);
            Console.WriteLine("Salary :" + professor.Salary);
            Console.WriteLine();
        }
    }
}
