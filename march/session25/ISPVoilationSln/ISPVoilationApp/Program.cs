﻿using ISPVoilationApp.Model;

namespace ISPVoilationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bot = new Robot();
            var manager = new Manager();
            AtTheWorkStation(manager);
            AtTheWorkStation(bot);
            AtTheCafeteria(manager);
            AtTheCafeteria(bot);
        }

        private static void AtTheCafeteria(IWorker worker)
        {
            Console.WriteLine("At the Cafeteria");
            worker.StartEat();
            worker.StopEat();
            Console.WriteLine();
        }

        private static void AtTheWorkStation(IWorker worker)
        {
            Console.WriteLine("At the Work Station");
            worker.StartWork();
            worker.StopWork();
            Console.WriteLine();
        }
    }
}