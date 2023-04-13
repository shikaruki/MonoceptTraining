using MovieStoreApp.Model;

namespace MovieStoreApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MonoceptDynamicArray movies = new MonoceptDynamicArray();
            bool iteration = true;
            do
            {
                PrintMessage( movies);
                string inputChoice = Console.ReadLine();
                switch(inputChoice)
                {
                    case "1":
                        Console.Write("Name : ");
                        string name = Console.ReadLine();
                        Console.Write("Year : ");
                        int year = Int32.Parse(Console.ReadLine());
                        movies.Add(name,year);
                        Console.WriteLine("Movie Added ");
                        break;
                    case "2":
                        DisplayingMessage( movies);
                        break;
                    case "3":
                        iteration= false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Valid Choice .");
                        break;
                }
            } while (iteration);
        }
        static void PrintMessage(MonoceptDynamicArray movies)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to movie Store App.");
            Console.WriteLine("Available Movies : {0}", movies.Size);
            Console.WriteLine();
            Console.WriteLine("1. Add ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Exit ");
            Console.Write("Enter Choice : ");
        }
        static void DisplayingMessage( MonoceptDynamicArray movies)
        {
            int index = 1;
            Console.WriteLine();
            Console.WriteLine("Displaying Movies : ");
            var items = movies.Display;
            foreach (var item in items)
            {
                Console.WriteLine(index++);
                Console.WriteLine("Name : {0}",item.name);
                Console.WriteLine("Year : {0}",item.year);
            }
        }
    }
}