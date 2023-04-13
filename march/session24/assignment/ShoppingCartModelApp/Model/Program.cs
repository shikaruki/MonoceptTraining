
using ShoppingCartModelApp.Model;

namespace ShoppingCartModelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Product(1, "HP", 72000, 15);
            Product milk = new Product(2, "Sudha Milk", 40, 5);
            Product mobile = new Product(3, "Samsung Galaxy", 20000, 4);

            LineItem lineItem1 = new LineItem(1, laptop, 5);
            LineItem lineItem2 = new LineItem(2, milk, 2);
            LineItem lineItem3 = new LineItem(3, mobile, 5);

            Order order1 = new Order();
            order1.AddItems(lineItem1);
            order1.AddItems(lineItem2);
            order1.AddItems(lineItem3);

            Customer ravi = new Customer(1, "ravi", order1);
            PrintInvoice printInvoice = new PrintInvoice();
            printInvoice.PrintConsoleInvoice(ravi);//
            Console.WriteLine();
            Console.WriteLine("CaseStudy");
            LineItem lineItem4 = new LineItem(3, mobile, 10);
            order1.AddItems(lineItem4);
            ravi.Orders.Add(order1);
            Console.ForegroundColor= ConsoleColor.Green;
            printInvoice.PrintConsoleInvoice(ravi);
        }
    }
}