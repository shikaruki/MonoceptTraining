using System;
namespace AccountApp.Model
{
    internal abstract class Account
    {
        private readonly int _accountNo;
        private readonly string _name;
        protected double _balance;
        public Account(int accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
        }
        public abstract void Withdraw(double amount);
        public void Deposit(double amount)
        {
            _balance += amount;
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
    }
}
