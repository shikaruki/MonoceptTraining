using GenricDictionaryApp.Model;

namespace GenricDictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student(10, 72, "Ravi");
            var s2 = new Student(10, 1, "Raj");
            var s3 = new Student(10, 72, "Ravi");

            var students = new Dictionary<Student, Student>();
            students.Add(s1, s1);
            students.Add(s3, s3);
            students.Add(s1, s2);

            Console.WriteLine("Value Equality Of S1 & s3 : {0}",s1.Equals(s3));
            Console.WriteLine("Hash Code Equality of S1 & s3 : {0}",s1.GetHashCode()==s3.GetHashCode());

            Console.WriteLine("Referential Equality : {0}",s1 == s3);
            Console.WriteLine(students.Count);

        }
    }
}