using CircleWithProperties.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            Circle circleA = new Circle(45,"dot","green");
            PrintDetails(circleA, "Cicle A");
            circleA.Color = "red";
            circleA.BorderStyle = "line";

            PrintDetails(circleA, "Circle A after color and border style change");
        }
        static void PrintDetails(Circle circle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Radius is : " + circle.Radius);
            Console.WriteLine("BorderStyle is : " + circle.BorderStyle);
            Console.WriteLine("Color is : " + circle.Color);
            Console.WriteLine();
        }
    }
}
