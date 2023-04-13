using DIPRefactoredWithDelegateApp.HighLevel;
using DIPRefactoredWithDelegateApp.LowLevel;

namespace DIPRefactoredWithDelegateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deligate = new DErrorLogger(TXTErrorLogger.Log);
            var txt = new TaxCalculator(deligate);
            Console.WriteLine(txt.CalculateTax(10, 2));
            Console.WriteLine(txt.CalculateTax(10, 0));
            var xmlDeligate = new DErrorLogger(XMLErrorLogger.Log);
            var xml = new TaxCalculator(xmlDeligate);
            Console.WriteLine(xml.CalculateTax(10, 2));
            Console.WriteLine(xml.CalculateTax(10, 0));
        }
    }
}