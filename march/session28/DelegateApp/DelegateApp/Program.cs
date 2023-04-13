namespace DelegateApp
{
    internal class Program
    {
        public delegate void DMathOperations(int a, int b);
        

        // method "sum"
        public static void Sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract"
        public static void Subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }
        //method multiply
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("(100 * 60) = {0}", a * b);
        }
        //method divide
        public static void Divide(int a, int b)
        {
            Console.WriteLine("(100 / 60) = {0}", a / b);
        }
        static void Main(string[] args)
        {
            DMathOperations obj;
            obj = Multiplication;
            obj += Sum;
            obj += Subtract;
            obj += Divide;
            obj(5, 4);
            
        }
    }
}