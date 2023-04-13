using GenericCollectionApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> dmartCart = new List<LineItem>();
            dmartCart.Add(new LineItem(101, "MIlk    ", 100, 2));
            dmartCart.Add(new LineItem(102, "dairyMilk", 50, 1));
            dmartCart.Add(new LineItem(102, "Coockies", 30, 2));
            PrintBill(dmartCart);
        }
        public static void PrintBill(List<LineItem> list)
        {
            Console.WriteLine("Item Name\tUnitPrice\tQuantity\t Price");
            foreach (LineItem item in list)
            {
                Console.WriteLine("{0}\t{1}\t * \t{2}\t\t {3}", item.Name, item.UnitPrice, item.Quantity, item.Quantity * item.UnitPrice);
                Console.WriteLine();
            }
            Console.WriteLine("Total Price : {0}", TotalBill(list));
            Console.WriteLine();
        }
        private static double TotalBill(List<LineItem> list)
        {
            double total = 0;
            foreach (object item in list)
            {
                LineItem temItem = (LineItem)item;
                if (temItem != null)
                    total += temItem.UnitPrice * temItem.Quantity;
            }
            return total;
        }
    }
}