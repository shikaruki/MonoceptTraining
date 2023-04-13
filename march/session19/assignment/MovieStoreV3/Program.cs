using MovieStoreV3.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

namespace MovieStoreV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore movies = new MovieStore();
            //movies.MovieDeseriliazation();
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
                        Movie movie;
                        movie.name = name;
                        movie.year=year;
                        movies.Add(movie);
                        Console.WriteLine("Movie Added ");
                        break;
                    case "2":
                        DisplayingMessage(movies.Display);
                        break;
                    case "3":
                        iteration = false;
                        //movies.MovieSerilization();
                        break;
                    default:
                        Console.WriteLine("Please Enter A Valid Choice .");
                        break;
                }
            } while (iteration);

            //CaseStudy1Serliazation(movies);
            //CaseStudy2Deseriliazation(movies);
        }
        static void CaseStudy1Serliazation(MovieStore movies)
        {
            //Serialization Part
            FileStream fileStream = new FileStream("movies.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, movies.Display);

            fileStream.Close();
            Console.WriteLine("Serialization Completed");
        }
        static void CaseStudy2Deseriliazation(MovieStore movies)
        {
            FileStream fs = new FileStream("movies.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(fs);
            Movie[] c = obj as Movie[];
            DisplayingMessage(c);
            fs.Close();
            Console.WriteLine("Deserilazation Completed");
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
            if(movies.Length == 0)
            {
                Console.WriteLine("No Movie Available");
                return;
            }
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