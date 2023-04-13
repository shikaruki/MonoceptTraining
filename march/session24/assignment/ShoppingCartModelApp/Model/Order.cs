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
        private LineItem[] _items ;
        private int index;
        public Order()
        {
            index= 0;
            _createdDate = DateTime.Now;
            _items = new LineItem[0];
        }
        public LineItem[] Items { get { return _items; } }
        public DateTime CreatedDate { get { return _createdDate; } }
        public void AddItems(LineItem item)
        {
            if (!IsAvailabe(item))
            {
                try
                {
                    if (index == Items.Length)
                        IncreaseSize();
                    Items[index] = item;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(e.Message.ToUpper());
                    Console.ResetColor();
                    return;
                }
                index++;
            }
        }
        private bool IsAvailabe(LineItem item)
        {
            foreach (LineItem line in Items)
            {
                if (line.Product == item.Product) {
                    line.Quantity += item.Quantity;
                    return true;
                        };
            }
            return false;
        }
        private void IncreaseSize()
        {
            int prevCapacity = Items.Length;
            LineItem[] temporaryArray = Items;
            _items = new LineItem[1 + prevCapacity];
            for (int j = 0; j < prevCapacity; j++)
                _items[j] = temporaryArray[j];
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
