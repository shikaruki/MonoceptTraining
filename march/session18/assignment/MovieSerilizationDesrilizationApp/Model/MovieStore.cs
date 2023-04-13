﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSerilizationDesrilizationApp.Model
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
        }
        public void Add(string name,int year)
        {
            try
            {
                if (index == movieDetails.Length)
                    IncreaseSize();
                movieDetails[index].name = name;
                movieDetails[index].year = year;
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
            movieDetails = new Movie[1+ prevCapacity];
            for (int j = 0; j < prevCapacity; j++)
                movieDetails[j] = temporaryArray[j];
        }
        public Movie[] Display { get { return movieDetails; } }
        public int Size { get { return movieDetails.Length; } }
    }
}
