using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDynamicArrayApp.Model
{
    internal class MonoceptDynamicArray
    {
        private int[] numbers;
        private int index;
        public MonoceptDynamicArray()
        {
            index = 0;
            numbers = new int[5];
        }
        public void Add(int number)
        {
            try
            {
                if (index == numbers.Length)
                    DoubleCapacity();
                numbers[index++] = number;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(e.Message.ToUpper());
                Console.ResetColor();
                return;
            }
        }
        private void DoubleCapacity()
        {
            int prevCapacity = numbers.Length;
            int[] temporaryArray = numbers;
            numbers = new int[2 * prevCapacity];
            for (int j = 0; j < prevCapacity; j++)
                numbers[j] = temporaryArray[j];
        }
        public int[] Get { get { return numbers; } }
    }
}
