using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartModelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitTestShoppingCartModelApp.UnitTestModel
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void Should_check_The_Consturctor()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            int expetedId = 1;
            double expectedPrice = 70000;
            double expectedDiscountPercent = 15.00;
            string expectedName = "Laptop";

            Assert.AreEqual(expectedPrice, product.Price);
            Assert.AreEqual(expectedName, product.Name);
            Assert.AreEqual(expetedId, product.Id);
            Assert.AreEqual(expectedDiscountPercent, product.DiscountPercentage);
        }
        [TestMethod]
        public void Should_check_PriceAfterDiscount_Method()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            double expectedPriceAfterDiscount = 59500;

            Assert.AreEqual(expectedPriceAfterDiscount, product.PriceAfterDiscount());
        }
        [TestMethod]
        public void Should_Check_OverRidded_ToString_Method()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            int expetedId = 1;
            double expectedPrice = 70000;
            double expectedDiscountPercent = 15.00;
            string expectedName = "Laptop";
            string expectedProductDetails = $"Id :{expetedId} , " +
                $"ProductName : {expectedName} , " +
                $"Price : {expectedPrice} , " +
                $"DiscountPercent : {expectedDiscountPercent} , " +
                $"DiscountedPrice {product.PriceAfterDiscount()} ,";
            Assert.AreEqual(expectedProductDetails,product.ToString());
        }
        [TestMethod]
        public void Should_Check_Updated_Property_ID_SET()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            product.Id = 3;
            int expetedId = 3;
            Assert.AreEqual(expetedId, product.Id);
        }
        [TestMethod]
        public void Should_Check_Updated_Property_Name_SET()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            product.Name = "MILK";
            string expetedName = "MILK";
            Assert.AreEqual(expetedName, product.Name);
        }
        [TestMethod]
        public void Should_Check_Updated_Property_Price_SET()
        {
            Product product = new Product(1, "Laptop", 70000, 15);
            product.Price = 50000;
            double expetedPrice = 50000;
            Assert.AreEqual(expetedPrice, product.Price);
        }
    }
}
