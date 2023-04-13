namespace ExceptionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st exception divide by zero
            //Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            Console.WriteLine("Hello, World!");
            int firstValue = int.Parse(args[0]);
            int secondValue = int.Parse(args[1]);
            // int result = firstValue / secondValue;
            //Console.WriteLine("{0} / {1} = {2}",firstValue,secondValue,result);


            //2nd Exception index out of bound Unhandled exception. System.IndexOutOfRangeException:
            //Index was outside the bounds of the array.
            // int thirdValue = int.Parse(args[3]);

            //3rd exception can not persable
            //Unhandled exception. System.FormatException: Input string was not in a correct format.
            int canNotPersable = int.Parse(args[2]);
            Console.WriteLine("End of Main");
        }
    }
}