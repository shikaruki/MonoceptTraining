using StudentLinkApp.Model;

namespace StudentLinkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ravi = new Student { Name = "Ravi" };
            Student ekta = new Student { Name = "Ekta" };
            Student shub = new Student { Name = "Shub" };
            Student manjunath = new Student { Name = "Manjunath" };
            manjunath.Buddy = ekta;
            ekta.Buddy = ravi;
            shub.Buddy = ekta;
            PrintDetails(manjunath);
            Console.WriteLine();
            PrintRecursive(manjunath);
        }

        private static void PrintRecursive(Student student)
        {
            if(student == null) {
                return;
            }
            else if(student != null)
            {
                Console.WriteLine(student.Name);
                PrintRecursive(student.Buddy);
            }
        }

        private static void PrintDetails(Student student)
        {
            while(student!=null)
            {
                Console.WriteLine(student.Name);
                student=student.Buddy;
            }
        }
    }
}