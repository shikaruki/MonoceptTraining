using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ravi", 72, 8.5);
            Student student2 = new Student("Jishu", 45, 7.9);
            Student student3 = new Student("Surkhi", 239, 8.1);
            PrintDetails(student1, "Details of Student1");
            PrintDetails(student2, "Details of Student2");
            PrintDetails(student3, "Details of Student3");
        }
        public static void PrintDetails(Student student, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine();
            Console.WriteLine("Name : " + student.Name);
            Console.WriteLine("Roll : " + student.Roll);
            Console.WriteLine("CGPA : " + student.Cgpa);
            Console.WriteLine("Percentage : " + student.Percentage);
            Console.WriteLine();
        }
    }
}
