using CarFacedApp.Model;

namespace CarFacedApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}