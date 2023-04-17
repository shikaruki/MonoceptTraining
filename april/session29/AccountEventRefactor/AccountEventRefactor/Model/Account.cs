using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventRefactor.Model
{
    //delegate void DBalanceChange(Account account);

    internal class Account
    {
        private readonly int _accountNo;
        private readonly string _name;
        private double _balance;
        private const double MIN_BALANCE = 500;
        public event Action<Account>? OnBalanceChange =null;
        public Account(int accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
        }
        public Account(int accoNo, string name)
        {
            _accountNo = accoNo;
            _name = name;
            _balance = MIN_BALANCE;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            if (OnBalanceChange != null)
            {
                OnBalanceChange(this);
            }
        }
        public void Withdraw(double amount)
        {
            if (ValidateMinBalance(amount))
            {
                _balance -= amount;
                if (OnBalanceChange != null)
                {
                    OnBalanceChange(this);
                }
            }
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

    }
}
