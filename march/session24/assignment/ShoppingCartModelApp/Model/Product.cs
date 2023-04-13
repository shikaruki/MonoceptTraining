using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModelApp.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercentage;
        public Product(int id, string name, double price, double discountPercentage)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercentage = discountPercentage;
        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public double DiscountPercentage { get { return _discountPercentage; } set { _discountPercentage = value; } }
        public double PriceAfterDiscount()
        {
            return Price - (Price * DiscountPercentage * 0.01);
        }

        public override string ToString()
        {
            string productDetails = $"Id :{_id} , " +
                $"ProductName : {_name} , " +
                $"Price : {_price} , " +
                $"DiscountPercent : {_discountPercentage} , " +
                $"DiscountedPrice {PriceAfterDiscount()} ,";
            return productDetails;
        }
    }
}
