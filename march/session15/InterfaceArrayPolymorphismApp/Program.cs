using InterfaceArrayPolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceArrayPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("Pulser");
            Car car = new Car("Bmw");
            Truck truck = new Truck("Ashok Lay");
            IEMoveble[] isMovebles= new IEMoveble[] { truck,bike,car };
            StartRace(isMovebles);
        }
        static void StartRace(IEMoveble[] isMoveble)
        {
            Console.WriteLine("Start Race");
            foreach(IEMoveble item in isMoveble)
            {
                item.Move();
            }
            Console.WriteLine("End Race");
        }
    }
}
