
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
            printInvoice.PrintConsoleInvoice(ravi);
            Console.WriteLine();
            Console.WriteLine("CaseStudy");
            CaseStudy1();
        }
        public static void CaseStudy1()
        {
            Product product1 = new Product(1, "Laptop", 70000, 15);
            Product product2 = new Product(1, "Milk", 50, 10);
            LineItem lineItem1 = new LineItem(11, product1, 3);
            LineItem lineItem2 = new LineItem(12, product2, 10);
            Order order = new Order();
            order.AddItems(lineItem1);
            order.AddItems(lineItem2);
            Console.WriteLine(order.CalculateCheckOutPrice());
        }
    }
}