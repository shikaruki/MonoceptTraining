using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUnitTestApp
{
    [TestClass]
    public class AccountTest
    {
        
        [TestMethod]
        public void ShouldCreateAccountHolder_WithInitalBalanceof500()
        {
            double exceptedBalance = 500;
            string exceptedName = "Ekta";
            int exceptedAccno = 1001;
            Account acc1 = new Account(1001,500, "Ekta");
            double actualBalace = acc1.Balance;
            Assert.AreEqual(exceptedBalance, actualBalace);
            Assert.AreEqual(exceptedName,acc1.Name);
            Assert.AreEqual(exceptedAccno, acc1.Accountno);
        }

        [TestMethod]
        public void ShouldCreateAccountHolder_WithInitailBalanceOf_1000()
        {
            double exceptedBalance = 1000;
            Account acc1 = new Account(1001,1000,"Ekta");
            double actualBalace = acc1.Balance;
            Assert.AreEqual(exceptedBalance, actualBalace);

        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldThrowExceptionIfCreateAccountHolder_WithInitialBalanceBelow500()
        {
            Account acc1 = new Account(1001,499,"Ekta");
        }
       
        [TestMethod]
        public void ItSholudDepositAmountToAccount()
        {
            double exceptedBalance = 2000;
            Account acc1 = new Account(1001, 1500, "Ekta");
            acc1.Deposite(500);
            double actualBalace = acc1.Balance;
            Assert.AreEqual(exceptedBalance,actualBalace);
        }
        [TestMethod]
        public void ItShouldWithDrawAmountIfBalanceIsSufficient()
        {
            double exceptedBalance = 800;
            Account acc1 = new Account(1001, 2000, "Ekta");
            acc1.Withdraw(1200);
            double actualBalace = acc1.Balance;
            Assert.AreEqual(exceptedBalance, actualBalace);
        }


    }
}
