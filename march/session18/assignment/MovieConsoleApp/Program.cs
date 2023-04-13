using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MovieBuisnessLayerLib.Model;

namespace MovieConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore movies = new MovieStore();
            bool iteration = true;
            do
            {
                PrintMessage(movies);
                string inputChoice = Console.ReadLine();
                switch (inputChoice)
                {
                    case "1":
                        Console.Write("Name : ");
                        string name = Console.ReadLine();
                        Console.Write("Year : ");
                        int year = Int32.Parse(Console.ReadLine());
                        movies.Add(name, year);
                        Console.WriteLine("Movie Added ");
                        break;
                    case "2":
                        DisplayingMessage(movies.Display);
                        break;
                    case "3":
                        iteration = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Valid Choice .");
                        break;
                }
            } while (iteration);
        }
       
        
        static void PrintMessage(MovieStore movies)
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
        static void DisplayingMessage(Movie[] movies)
        {
            int index = 1;
            Console.WriteLine();
            Console.WriteLine("Displaying Movies : ");
            var items = movies;
            foreach (var item in items)
            {
                Console.WriteLine(index++);
                Console.WriteLine("Name : {0}", item.name);
                Console.WriteLine("Year : {0}", item.year);
            }
        }
    }
}