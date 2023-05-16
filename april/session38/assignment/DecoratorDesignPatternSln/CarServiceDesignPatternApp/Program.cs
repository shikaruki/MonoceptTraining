using CarServiceDesignPatternApp.Model.Decorator;
using CarServiceDesignPatternApp.Model;

namespace CarServiceDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService service = new OilChange(new TyreRotation(new CarInspection()));
            Console.WriteLine("Total Cost: " + service.GetCost());
            Console.WriteLine("Service Provided are: " + service.GetDetails());
        }
    }
}