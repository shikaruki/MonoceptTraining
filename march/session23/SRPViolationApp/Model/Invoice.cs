using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.Model
{
    internal class Invoice
    {
        private readonly int _id;
        private readonly string _description;
        private readonly double _cost;
        private readonly double _discountPercent;
        private const double _tax = .10;
        public Invoice(int id, string description, double cost, double discountPercemt)
        {
            _id = id;
            _description = description;
            _cost = cost;
            _discountPercent = discountPercemt;
        }
        public double CalculateTax()
        {
            return _cost * _tax;
        }
        public double CalculateDiscount()
        {
            return _cost * 0.01*_discountPercent;
        }
        public double FinalCost()
        {
            return _cost + CalculateTax() - CalculateDiscount();
        }
        public void PrintInvoice()
        {
            string template = $"Id : {_id} \nDescription : {_description}" +
                   $"\nCost is : {_cost}" +
                   $"\ntax amt is : {CalculateTax()}" +
                   $"\ndiscount amt is : {CalculateDiscount()}" +
                   $"\nFinal Cost is : {FinalCost()}";
            Console.WriteLine(template);
        }
    }
}
