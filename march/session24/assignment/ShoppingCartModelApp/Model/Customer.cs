using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModelApp.Model
{
    public class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _orders = new List<Order>();
        public Customer(int id, string name, Order orders)
        {
            _id = id;
            _name = name;
            _orders.Add(orders);
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public List<Order> Orders { get { return _orders; } }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

    }
}
