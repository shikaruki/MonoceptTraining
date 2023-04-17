using AdapterPatternApp.Model;
using HatLib.Model;

namespace AdapterPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new ShoppingCart();
            //c.Add(new Hat("Golden", "Golden Preminum Hat", 999));
            c.Add(new HatAdapter(new Hat("Golden", "Golden Preminum Hat", 999)));
            PrintDetails(c);
        }

        static void PrintDetails(ShoppingCart shoppingCart)
        {
            foreach(var item in shoppingCart.items)
            {
                Console.WriteLine(value: item.ItemName());
                Console.WriteLine(value: item.ItemPrice());
            }
        }
    }
}

