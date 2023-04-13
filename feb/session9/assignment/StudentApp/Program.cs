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
            Student student1 = new Student("Ravi", 72, 8.5,101,10000);
            Student student2 = new Student("Jishu", 45, 7.9,102,10001);
            Student student3 = new Student("Surkhi", 239, 8.1,102,10002);
            PrintDetails(student1, "Details of Student1");
            PrintDetails(student2, "Details of Student2");
            PrintDetails(student3, "Details of Student3");
            student1.PayFee(9909);
            student2.PayFee(1202);
            student3.PayFee(10000);
            PrintDetails(student1, "Details after Paying some money");
            PrintDetails(student2, "Details after Paying some money");
            PrintDetails(student3, "Details after Paying some money");
        }
        public static void PrintDetails(Student student, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine();
            Console.WriteLine("Name : " + student.Name);
            Console.WriteLine("Roll : " + student.Roll);
            Console.WriteLine("CGPA : " + student.Cgpa);
            Console.WriteLine("Percentage : " + student.Percentage);
            Console.WriteLine("Total Fee : "+student.TotalFee);
            Console.WriteLine("Remaing Fee : "+student.RemaingFee);
            Console.WriteLine();
        }
    }
}
