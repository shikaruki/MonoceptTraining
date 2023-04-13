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
            Console.WriteLine("Displaying Annonamus object Details ");
            Console.WriteLine(new Rectangle().CalculateArea());
            Console.WriteLine(new Rectangle().GetColor() );
            PrintDetails(new Rectangle(), "d");
            //PrintDetails(null, null);
            Rectangle rect=null;
            // rect = new Rectangle();
            rect.SetWidth(100);
            rect.SetHeight(100);
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine("{0}",1);
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
