using GenericDynamicArrayApp.Model;
using System;

namespace GenericDynamicArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonoceptDynamicArray monoceptDynamicArray = new MonoceptDynamicArray();
            while (true)
            {
                Console.Write("Enter a Number : ");
                int number;
                if (ValidateInput(Console.ReadLine(), out number))
                    monoceptDynamicArray.Add(number);
                else
                    break;
            }
            PrintDetails(monoceptDynamicArray);
        }
        private static void PrintDetails(MonoceptDynamicArray numbers)
        {
            Console.WriteLine("Array  Element Will be : ");
            foreach (int number in numbers.Get)
                Console.Write(number + " ");
        }

        private static bool ValidateInput(string input, out int number)
        {
            return Int32.TryParse(input, out number);
        }
    }
}