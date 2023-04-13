namespace DynamicArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int index = 0;
            while (true)
            {
                numbers = CheckIndexSize(numbers, index);
                Console.Write("Enter a Number : ");
                int number;
                if (ValidateInput(Console.ReadLine(), out number))
                    numbers[index++] = number;
                else 
                    break;
            }
            PrintDetails(numbers);
        }
        private static bool ValidateInput(string input, out int number)
        {
            return Int32.TryParse(input, out number);
        }
        private static void PrintDetails(int[] numbers)
        {
            Console.WriteLine("Input Element in Array : ");
            foreach (int number in numbers)
                Console.Write(number + " ");
            Console.WriteLine();
        }
        private static int[] CheckIndexSize(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                int prevCapacity = numbers.Length;
                int[] temporaryArray = numbers;
                numbers = new int[2 * prevCapacity];
                for (int j = 0; j < prevCapacity; j++)
                    numbers[j] = temporaryArray[j];
            }
            return numbers;
        }
    }
}