using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreV3.Model
{
    [Serializable]
    internal class MovieStore
    {
        private Movie[] movieDetails;
        private int index;
        public MovieStore()
        {
            index = 0;
            movieDetails = new Movie[1];
            Load();
        }
        public void Add(Movie movie)
        {
            try
            {
                if (index == movieDetails.Length)
                    IncreaseSize();
                movieDetails[index].name = movie.name;
                movieDetails[index].year = movie.year;
                Save();
                Load();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(e.Message.ToUpper());
                Console.ResetColor();
                return;
            }
            index++;
        }
        private void IncreaseSize()
        {
            int prevCapacity = movieDetails.Length;
            Movie[] temporaryArray = movieDetails;
            movieDetails = new Movie[1 + prevCapacity];
            for (int j = 0; j < prevCapacity; j++)
                movieDetails[j] = temporaryArray[j];
        }

        private void Save()
        {
            //Serialization Part
            FileStream fileStream = new FileStream("movies.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, movieDetails);
            fileStream.Close();
            //Console.WriteLine("Serialization Completed");
        }

        private void Load()
        {
            //Deserilization
            FileStream fs = new FileStream("movies.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(fs);
            Movie[] c = obj as Movie[];
            movieDetails = c;
            index = movieDetails.Length;
            fs.Close();
            //Console.WriteLine("Deserilazation Completed");
        }
        public Movie[] Display { get { return movieDetails; } }
        public int Size { get { return movieDetails.Length; } }
    }
}
