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
    public class OrderUnitTest
    {
        //[TestMethod]
        //public void Should_check_The_Consturctor_Assigning_currentDate()
        //{
        //    Order order = new Order();
        //    DateTime expectedCreatedDate = DateTime.Now;

        //    Assert.AreEqual(expectedCreatedDate,order.CreatedDate);
        //}
        [TestMethod]
        public void Should_check_CalculateCheckOutPrice_Method()
        {
            Product product1 = new Product(1, "Laptop", 70000, 15);
            Product product2 = new Product(1, "Milk", 50, 10);
            LineItem lineItem1 = new LineItem(11, product1, 3);
            LineItem lineItem2 = new LineItem(12, product2, 10);
            Order order = new Order();
            order.AddItems(lineItem1);
            order.AddItems(lineItem2);
            double expectedCheckOutPrice = 178950;

            Assert.AreEqual(expectedCheckOutPrice, order.CalculateCheckOutPrice());
        }
        [TestMethod]
        public void Should_check_AddItem_Method()
        {
            Product product1 = new Product(1, "Laptop", 70000, 15);
            Product product2 = new Product(1, "Milk", 50, 10);
            LineItem lineItem1 = new LineItem(11, product1, 3);
            LineItem lineItem2 = new LineItem(12, product2, 10);
            Order order = new Order();
            order.AddItems(lineItem1);
            order.AddItems(lineItem2);
            int expectedOrderItemCount = 2;

            Assert.AreEqual(expectedOrderItemCount, order.Items.Count);
        }
        [TestMethod]
        public void Should_Check_OverRidded_ToString_Method()
        {
            Product product1 = new Product(1, "Laptop", 70000, 15);
            Product product2 = new Product(1, "Milk", 50, 10);
            LineItem lineItem1 = new LineItem(11, product1, 3);
            LineItem lineItem2 = new LineItem(12, product2, 10);
            Order order = new Order();
            order.AddItems(lineItem1);
            order.AddItems(lineItem2);

            string expectedOrderDetails = $"OrderTime : {order.CreatedDate} \n";
            double totalPrice = 0;
            foreach (LineItem lineItem in order.Items)
            {
                totalPrice += lineItem.CalculateItemCost();
                expectedOrderDetails += lineItem.ToString();
                expectedOrderDetails += "\n";
            }
            expectedOrderDetails += $"\nTotal Billing Amount : {totalPrice}";

            Assert.AreEqual(expectedOrderDetails, order.ToString());
        }

    }
}
