using DIPVoilationRefactoredApp.HighLevel;
using DIPVoilationRefactoredApp.LowLevel;

namespace DIPVoilationRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(new XMLErrorLogger());
            Console.WriteLine(calc.CalculateTax(5, 2));
            Console.WriteLine(calc.CalculateTax(5, 0));
        }
    }
}