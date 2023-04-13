using CalcExceptionApp.Model;

namespace CalcExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator= new Calculator();
            try
            {
                Console.WriteLine(calculator.Add(-3, 5));
            }
            catch(NegativeValuesNotSupportedException ex) {
            Console.WriteLine(ex.Message);
            }
        }
    }
}