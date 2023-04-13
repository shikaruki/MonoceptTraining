using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPolymorphismApp.Model
{
    internal class InsufficientFundsException : Exception
    {
        private Account _account;
        private double _withdrawAmt;
        public InsufficientFundsException(Account account, double withdrawAmt)
        {
            _account = account;
            _withdrawAmt = withdrawAmt;
        }
        public override string Message
        {
            get
            {
                string message = $"ICICI Bank say ";
                message += $"{_account.AccountNo} , owner : ";
                message += $"{_account.Name} ,try withdrawing ";
                message += $"{_withdrawAmt},current Balance is ";
                message += $"minimum balance required has to maintain";
                message += $" 500 . So, This transition is cancalled";
                return message;
            }
        }

    }
}
