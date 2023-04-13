using AccountUnitTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUnitTestApp
{

    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void ShouldAnEvenNum()
        {
            int expectedResult = 8;
            Calculate calculate = new Calculate();
            int actualResult = calculate.CubeEvenNum(2);
            Assert.IsTrue(expectedResult== actualResult);
        }
        [TestMethod]
         public void CubingOddNumberSouldResultInNegativeNumber()
        {
            int expectedResult = -1;
            Calculate calculate = new Calculate();
            int actualResult = calculate.CubeEvenNum(3);
            Assert.IsTrue(expectedResult== actualResult);
        }

        [TestMethod]
        public void AddShouldTakeAnyNumberOfParameterAndProduceResult()
        {
            int excpetedResult = 150;
            Calculate calculate = new Calculate();
            int actualResult = calculate.AddedNum(10, 20, 30, 40, 50);
            Assert.IsTrue(excpetedResult== actualResult);
        }

        [TestMethod]
        public void AddShouldTakeSingleValueAndReturnSameValue()
        {
            int excpetedResult = 10;
            Calculate calculate = new Calculate();
            int actualResult = calculate.AddedNum(10);
            Assert.IsTrue(excpetedResult== actualResult);

        }
        [TestMethod]
        public void AddShouldTakeNegativeValueAndReturnNegativeValue()
        {
            int excpetedResult = -20;
            Calculate calculate = new Calculate();
            int actualResult = calculate.AddedNum(-10, -10);
            Assert.IsTrue(excpetedResult == actualResult);

        }
    }
}
