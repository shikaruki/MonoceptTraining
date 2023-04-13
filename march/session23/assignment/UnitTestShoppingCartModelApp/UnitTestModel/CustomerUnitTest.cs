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
    public class CustomerUnitTest
    {
        [TestMethod]
        public void Should_check_The_Consturctor()
        {
            Product product1 = new Product(1, "Laptop", 70000, 15);
            Product product2 = new Product(1, "Milk", 50, 10);
            LineItem lineItem1 = new LineItem(11, product1, 3);
            LineItem lineItem2 = new LineItem(12, product2, 10);
            Order order = new Order();
            order.AddItems(lineItem1);
            order.AddItems(lineItem2);
            Customer customer = new Customer(111, "Ravi", order);
            int expectedCustomerId = 111;
            string expectedCustomerName = "Ravi";
            int expectedCustomerOrderCount =1;

            Assert.AreEqual(expectedCustomerName, customer.Name);
            Assert.AreEqual(expectedCustomerId, customer.Id);
            Assert.AreEqual(expectedCustomerOrderCount, customer.Orders.Count);
        }
        [TestMethod]
        public void Should_check_AddOrder_Method()
        {
            Product product1 = new Product(1, "Laptop", 70000, 15);
            Product product2 = new Product(1, "Milk", 50, 10);
            LineItem lineItem1 = new LineItem(11, product1, 3);
            LineItem lineItem2 = new LineItem(12, product2, 10);
            Order order1 = new Order();
            order1.AddItems(lineItem1);
            order1.AddItems(lineItem2);
            Customer customer = new Customer(111, "Ravi", order1);
            Order order2 = new Order();
            order2.AddItems(lineItem1);
            order2.AddItems(lineItem2);
            customer.AddOrder(order2);
            int expectedOrderCount = 2;

            Assert.AreEqual(expectedOrderCount, customer.Orders.Count);
        }
    }
}
