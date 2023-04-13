using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUnitTestApp.Model
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldCube_2_AndResult_8()
        {
            int expectedResult = 8;
            Calculator calculator = new Calculator();
            int actualResult = calculator.CubeEvenNo(2);
            
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldCubeOddNo_AndResult_Negative() {
            int expectedResult = -1;
            Calculator calculator = new Calculator();
            int actualResult = calculator.CubeEvenNo(3);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldCube_0_AndResult_0()
        {
            int expectedResult = 0;
            Calculator calculator = new Calculator();
            int actualResult = calculator.CubeEvenNo(0);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_Should_Take_Infinite_Parameter_And_Produce_Result()
        {
            int expectedResult = 150;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(10, 20, 30, 40, 50);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_Should_Take_One_Parameter_And_Produce_SameValue()
        {
            int expectedResult = 150;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(150);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_Should_Take_Two_NegativeVAlue_And_Produce_Result()
        {
            int expectedResult = -20;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(-10,-10);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_Should_Take_NegativeVAlue_And_Produce_Result()
        {
            int expectedResult = 0;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(10, -10);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
