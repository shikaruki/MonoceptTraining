using InvoiceRefactoredApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRefactoredApp.Presentation
{
    internal class InvoiceConsolePrinter
    {
        public void PrintConsole(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string template = $"Id : {invoice.Id} \nDescription : {invoice.Description}" +
                   $"\nCost is : {invoice.Cost}" +
                   $"\ntax amt is : {invoice.CalculateTax()}" +
                   $"\ndiscount amt is : {invoice.CalculateDiscount()}" +
                   $"\nFinal Cost is : {invoice.FinalCost()}";
            Console.WriteLine(template);
            Console.ResetColor();
        }
    }
}
