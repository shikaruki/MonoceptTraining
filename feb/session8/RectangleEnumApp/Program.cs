using RectangleEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle(10, 10, ColorOption.GREEN);
            Rectangle rectangleB = new Rectangle(12, 12, ColorOption.BLUE, BorderOption.SINGLE);
            PrintDetails(rectangleA);
            PrintDetails(rectangleB);
        }
        static void PrintDetails(Rectangle rectangle)
        {
            Console.WriteLine( );
            Console.WriteLine("Width : "+rectangle.Width);
            Console.WriteLine("height : "+rectangle.Height);
            Console.WriteLine("color : " + rectangle.Color);
            Console.WriteLine("Border : " + rectangle.Border);
        }
    }
}
