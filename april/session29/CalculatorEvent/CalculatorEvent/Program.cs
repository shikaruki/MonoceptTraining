using CalculatorEvent.Model;

namespace CalculatorEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator= new Calculator();
            calculator.OnOperationPerformed += AdditionCompleted;
            calculator.Add(2, 5);
            calculator.OnOperationPerformed += SubstractionCompleted;
            calculator.Substract(5, 3);
            

        }

        static void AdditionCompleted(int a,int b,string result)
        {
            Console.WriteLine("Addition Completed" +result);
        }
        static void SubstractionCompleted(int a, int b,string result)
        {
            Console.WriteLine("Substraction Completed" +result);
        }
    }
}