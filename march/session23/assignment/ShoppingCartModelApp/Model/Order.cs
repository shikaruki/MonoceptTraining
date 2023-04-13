using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModelApp.Model
{
    public class Order
    {
        private readonly DateTime _createdDate;
        private List<LineItem> _items ;
        public Order()
        {
            _createdDate = DateTime.Now;
            _items = new List<LineItem>();
        }
        public List<LineItem> Items { get { return _items; } }
        public DateTime CreatedDate { get { return _createdDate; } }
        public void AddItems(LineItem item)
        {
            _items.Add(item);
        }
        public double CalculateCheckOutPrice()
        {
            double totalPrice = 0;
            foreach (LineItem lineItem in _items)
            {
                totalPrice += lineItem.CalculateItemCost();
            }
            return totalPrice;
        }
        public override string ToString()
        {
            string orderDetails = $"OrderTime : {_createdDate} \n";
            double totalPrice = 0;
            foreach (LineItem lineItem in _items)
            {
                totalPrice += lineItem.CalculateItemCost();
                orderDetails += lineItem.ToString();
                orderDetails += "\n";
            }
            orderDetails += $"\nTotal Billing Amount : {totalPrice}";
            return orderDetails;
        }
    }
}
