using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherCoreLib.Model
{
    public class Account
    {
        private readonly int _accountNo;
        private readonly string _name;
        private double _balance;
        private const double MIN_BALANCE = 500;
        private List<IAccountNotifier> _notifications;
        public Account(int accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
            _notifications = new List<IAccountNotifier>();
        }
        public Account(int accoNo,string name):this(accoNo,name,MIN_BALANCE) { }
        
        public void AddSubscriber(IAccountNotifier notifier) { 
        _notifications.Add(notifier);
        }

        public void Deposit(double amount) {
            _balance += amount;
            CallNotification();
        }
        private void CallNotification()
        {
            foreach (IAccountNotifier notifier in _notifications)
            {
                notifier.Notify(this);
            }
        }
        public void Withdraw(double amount)
        {
            if(ValidateMinBalance(amount))
                _balance -= amount;
            else
                Console.WriteLine("Min withdraw Error");
            CallNotification();

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
