using StrategyPatternApp.Model;

namespace StrategyPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation multiplyOperation = new MathOperation(new Multiply());
            Console.WriteLine("Multiply: " + multiplyOperation.Calculate(7, 1).ToString());

            MathOperation AddOperation = new MathOperation(new Add());
            Console.WriteLine("Add: " + AddOperation.Calculate(7, 1).ToString());

        }
    }
}