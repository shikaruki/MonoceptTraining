using System;
namespace ProveOfConceptApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student;
            EnrollOut(out student);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.pass);
            int x;
            Console.WriteLine(true == Int32.TryParse("3.5", out x) ? "Parsing successfully": "Parsing failed.");
            Console.WriteLine(true == Int32.TryParse("3ss", out x) ? "Parsing successfully" : "Parsing failed.");

            var student1 = new Student
            {
                Name = "Ravi",
                pass = false
            };
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.pass);
            EnrollIn(student1);
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.pass);

            Console.WriteLine(ParamsArray(5,4,2,1,3));
        }
        static void EnrollIn(in Student student)
        {
            student.Name = "Shikaruki";
            student.pass = true;
        }
        static void EnrollOut(out Student student)
        {
            student = new Student();
            student.Name = "Raj";
            student.pass = false;
        }
        static int ParamsArray(params int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            return sum;
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public bool pass { get; set; }
    }
}
