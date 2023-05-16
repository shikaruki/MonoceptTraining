using HatDecoratorDesignPatternApp.Model;
using HatDecoratorDesignPatternApp.Model.Decorator;

namespace HatDecoratorDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHat hat = new StandardHat();
            PrintDetails(hat);

            hat = new PremiumHat();
            PrintDetails(hat);

            hat = new RibbonedHat(new StandardHat());
            PrintDetails(hat);

            hat = new RibbonedHat(new PremiumHat());
            PrintDetails(hat);

            hat = new GoldenHat(new StandardHat());
            PrintDetails(hat);

            hat = new GoldenHat(new RibbonedHat(new StandardHat()));
            PrintDetails(hat);

        }

        private static void PrintDetails(IHat hat)
        {
            Console.WriteLine("Name: " + hat.GetName());
            Console.WriteLine("Price: " + hat.GetPrice());
            Console.WriteLine("Description: " + hat.GetDescription());
            Console.WriteLine();
        }
    }
}