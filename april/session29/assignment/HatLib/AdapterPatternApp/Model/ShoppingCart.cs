using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    internal class ShoppingCart
    {
        private List<Item> _items;
        public ShoppingCart() {
            _items = new List<Item>();
        }
        public void Add(Item item)
        {
            _items.Add(item);
        }
        public void Remove(Item item)
        {
            _items.Remove(item);
        }
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (Item item in _items)
            {
                totalPrice += item.ItemPrice();
            }
            return totalPrice;
        }
        public List<Item> items { get { return _items; } }
    }
}
