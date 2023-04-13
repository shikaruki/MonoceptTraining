using AccountApp.Model;
using System;
namespace AccountPolymorphismApp.Model
{
    internal class SavingAccount : Account
    {
        private const int MIN_BALANCE = 1000;
        public SavingAccount(int accountNo, string name, double balance) : base(accountNo, name, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if (HasValidTranscution(amount))
            {
                _balance -= amount;
                return;
            }
            else
                throw new Exception("NO Sufficient Funds");
        }
        private bool HasValidTranscution(double amount)
        {
            if (_balance - amount >= MIN_BALANCE)
                return true;
            return false;
        }
    }
}

