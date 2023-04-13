using InvoiceRefactoredApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRefactoredApp.Presentation
{
    internal class InvoiceHtmlPrinter
    {
        public void PrintToHtml(Invoice invoice)
        {
            string template = $"Id : {invoice.Id} " +
                        $"<br>Description : {invoice.Description}" +
                        $"<br>Cost is : {invoice.Cost}" +
                        $"<br>tax amt is : {invoice.CalculateTax()}" +
                        $"<br>discount amt is : {invoice.CalculateDiscount()}" +
                        $"<br>Final Cost is : {invoice.FinalCost()}";

            StreamWriter sw = new StreamWriter(invoice.Id + ".html");
            sw.Write("<html>");
            sw.Write("<body>");
            sw.Write("<h2>");
            sw.Write(template);
            sw.Write("</h2>");
            sw.Write("</body>");
            sw.Write("</html>");
            sw.Close();
        }
    }
}
