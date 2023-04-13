using RectanglePropertiesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine(args.Length);
            Rectangle rectangleA = new Rectangle(100, 50, "green");
            PrintDetails(rectangleA, "Rectangle A");
            rectangleA.Color = "red";
            // rectangleA.Height = 30;

            PrintDetails(rectangleA, "Rectangle A after color change");
        }
        static void PrintDetails(Rectangle rectangle,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("width is : "+rectangle.Width);
            Console.WriteLine("Height is : " + rectangle.Height);
            Console.WriteLine("Color is : " + rectangle.Color);
            Console.WriteLine();
        }
    }
}
