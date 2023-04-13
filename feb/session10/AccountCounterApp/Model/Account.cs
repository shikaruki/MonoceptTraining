using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        private readonly int _accountNo;
        private readonly string _name;
        private double _balance;
        private const double MIN_BALANCE = 500;
        private static int _instanceCount = 0;
        private int instanceCount = 0;
        public Account(int accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
            _instanceCount += 1;
            instanceCount+= 1;
        }
        public Account(int accoNo, string name) :
            this(accoNo, name, MIN_BALANCE)
        {

        }

        public void Deposit(double amount)
        {
            this._balance += amount;
        }
        public static void PrintName()
        {
            Console.WriteLine("Static method");
        }
        public void Withdraw(double amount)
        {
            if (ValidateMinBalance(amount))
                _balance -= amount;
            else
                Console.WriteLine("Min withdraw Error");
        }
        private bool ValidateMinBalance(double amount)
        {
            double balanceAfterWithdraw = _balance - amount;
            if (balanceAfterWithdraw > MIN_BALANCE)
                return true;
            return false;
        }
        public int AccountNo
        {
            get { return _accountNo; }
        }
        public double Balance
        {
            get { return _balance; }
        }
        public string Name
        {
            get { return _name; }
        }

        public int InstanceCount
        {
            get { return _instanceCount; }
        }
        public int InstanceCountWithoutStatic
        {
            get { return instanceCount; }
        }

    }
}
