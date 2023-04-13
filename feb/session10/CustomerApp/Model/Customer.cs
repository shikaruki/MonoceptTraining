using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private int _orderCount =1;
        private static int _nextId;
        static Customer()
        {
            _nextId = 1000;
        }
        public Customer(string pname,int porderCount) { 
            _name = pname;
            _nextId += 1;
            _id = _nextId;
            _orderCount = porderCount;
        }
        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public int OrderId
        {
            get { return _orderCount; }
        }
    }
}
