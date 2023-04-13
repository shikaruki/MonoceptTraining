using CircleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle small;
            small = new Circle();
            small.SetBoarder("dot");
            small.SetColor("red");
            small.SetRadius(10);
            PrintDetails(small,"Details of Small Circle");
        }
        static void PrintDetails(Circle circle, string descprion)
        {
            Console.WriteLine(descprion.ToUpper());
            Console.WriteLine("Color is {0}", circle.GetColor() );
            Console.WriteLine("Radius is {0}", circle.GetRadius());
            Console.WriteLine("Boarder style is {0}", circle.GetBoarder());
            Console.WriteLine("Area is {0} ", circle.GetArea() );
            Console.WriteLine("Perimeter is {0} ", circle.GetPerimeter());

        }
    }
}
