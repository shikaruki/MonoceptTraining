using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModelApp.Model
{
    public class PrintInvoice
    {
        public void PrintConsoleInvoice(Customer customer) {
            Console.WriteLine();
            Console.WriteLine("Customer Id   : " + customer.Id);
            Console.WriteLine("Customer Name : " + customer.Name);
            Console.WriteLine("Order Details :");
            int orderCount = 1;
            foreach (var item in customer.Orders)
            {
                Console.WriteLine("Order : {0}",orderCount++);
                Console.WriteLine(item.ToString());
            }
        }
    }
}
