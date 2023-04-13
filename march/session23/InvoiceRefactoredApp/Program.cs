
using InvoiceRefactoredApp.Model;
using InvoiceRefactoredApp.Presentation;

namespace InvoiceRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Training Invoice ", 100, 50);
            InvoiceConsolePrinter printer = new InvoiceConsolePrinter();
            printer.PrintConsole(invoice);
            InvoiceHtmlPrinter invoiceHtmlPrinter = new InvoiceHtmlPrinter();
            invoiceHtmlPrinter.PrintToHtml(invoice);
        }
    }
}