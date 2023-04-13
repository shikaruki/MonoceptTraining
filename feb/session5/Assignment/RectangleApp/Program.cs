using RectangleApp.Model;
using System;
namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small,big;
            small = new Rectangle();
            big = new Rectangle();
            big.height = 15;
            big.width = 25;
            Console.WriteLine("Big Rectangle height"+ big.height);
            Console.WriteLine("Big Rectangle Width"+big.width);
            small.height = 10;
            small.width = 20;
            Console.WriteLine("Small Rectangle height"+small.height);
            Console.WriteLine("small Rectangle width "+small.width);
            Console.WriteLine(small.CalculateArea());
        }
    }
}
