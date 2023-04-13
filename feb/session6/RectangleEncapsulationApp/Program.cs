using RectangleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle   rectangleA = new Rectangle();
            rectangleA.SetWidth(101);
            rectangleA.SetHeight(-101);
            rectangleA.SetColor("abce");
            PrintDetails(rectangleA, " Details of Rectangle A");

            Rectangle rectangleB = new Rectangle();
            rectangleB.SetWidth(20);
            rectangleB.SetHeight(30);
            rectangleB.SetColor("blue");
            PrintDetails(rectangleB, " Details of Rectangle B");
        }
        static void PrintDetails(Rectangle rectangle ,string descprion)
        {
            Console.WriteLine(descprion.ToUpper());
            Console.WriteLine("width is {0}",rectangle.GetWidth());
            Console.WriteLine("height is {0}", rectangle.GetHeight());
            Console.WriteLine("color is {0}",rectangle.GetColor());
            Console.WriteLine("Area is {0} ", rectangle.CalculateArea());
            
        }
    }
}
