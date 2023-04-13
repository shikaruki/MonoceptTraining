using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal class CurrentAccount : Account
    {
        private const int OVER_DRATFT_LIMIT = -5000;
        public CurrentAccount(int accountNo, string name, double balance) : base(accountNo, name, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if (HasValidTranscution(amount))
            { _balance -= amount;
                return;
            }
            throw new Exception("Over Draft Limit Exceeds");
        }
        private bool HasValidTranscution(double amount) {
            if (_balance - amount >= OVER_DRATFT_LIMIT)
                return true;
            return false;            
        }
    }
}
