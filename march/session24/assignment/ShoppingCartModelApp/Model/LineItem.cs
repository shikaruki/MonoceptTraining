using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModelApp.Model
{
    public class LineItem
    {
        private int _id;
        protected Product _product;
        protected int _quantity;
        public LineItem(int id, Product product, int quantity)
        {
            _id = id;
            _product = product;
            _quantity = quantity;
        }
        public int Id { get { return _id; } }
        public Product Product { get { return _product; } }
        public int Quantity { get { return _quantity; } set{ _quantity = value; } }
        public double CalculateItemCost()
        {
            return (Product.PriceAfterDiscount() * Quantity);
        }
        public override string ToString()
        {
            string lineItemDetails = $"ID -> {this.Id} Quantity :{this.Quantity} , {_product} TotalItemCost : {CalculateItemCost()}";
            return lineItemDetails;
        }
    }
}
