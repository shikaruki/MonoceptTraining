using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartModelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestShoppingCartModelApp.UnitTestModel
{
    [TestClass]
    public class LineItemUnitTest
    {
        [TestMethod]
        public void Should_check_The_Consturctor()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            LineItem lineItem = new LineItem(11, product, 3);
            int expetedId = 11;
            Product expectedProduct = product;
            double expectedQuantity = 3.00;

            Assert.AreEqual(expectedProduct, lineItem.Product);
            Assert.AreEqual(expectedQuantity, lineItem.Quantity);
            Assert.AreEqual(expetedId, lineItem.Id);
        }
        [TestMethod]
        public void Should_check_CalculateItemCost_Method()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            LineItem lineItem = new LineItem(11, product, 3);
            double expectedLineItemCost = 178500;
            Assert.AreEqual(expectedLineItemCost,lineItem.CalculateItemCost());
        }
        [TestMethod]
        public void Should_Check_OverRidded_ToString_Method()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            LineItem lineItem = new LineItem(11, product, 3);
            int expetedId = 11;
            string expectedLineItemDetails = $"ID -> {expetedId} , {product.ToString()} TotalItemCost : {lineItem.CalculateItemCost()}";
            Assert.AreEqual(expectedLineItemDetails,lineItem.ToString());
        }

    }
}
