using System;
namespace AccountTransactionApp.Model
{
    internal  class Account
    {
        private readonly int _accountNo;
        private readonly string _name;
        protected double _balance=0;
        private const double MIN_BALANCE = 500;
        private readonly List<Transaction> _transactions;
        public Account(int accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _transactions = new List<Transaction>();
            Deposit(balance);
        }
        public Account(int accno, string name) : this(accno, name, MIN_BALANCE)
        {
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            _transactions.Add(new Transaction { Type = 'D', Amount = _balance, Time = DateTime.Now });
        }
        public void Withdraw(double amount)
        {
            _balance -= amount;
            _transactions.Add(new Transaction { Type = 'W', Amount = amount, Time = DateTime.Now });
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

        public IEnumerable<Transaction> Transactions { get { return _transactions; } }
    }
}
