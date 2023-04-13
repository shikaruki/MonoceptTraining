
using System;


namespace AccountApp.Model
{
    public class Account
    {
        private readonly int _accountno;
        private double _balance;
        private readonly string _name;
        private const double MIN_Balanace = 500;
        public Account(int accountno, double balance, string name)
        {
            if (balance < MIN_Balanace)
                throw new Exception("cannot create account with less than minimum balance");
            _accountno = accountno;
            _balance = balance;
            _name = name;
        }
        public Account(int accountno, string name)
        {
            _accountno = accountno;
            _name = name;
            _balance = MIN_Balanace;
        }
        private bool SufficientFund(double withdrawamount)
        {
           
             double amountAfterWithDraw = _balance - withdrawamount;
             return amountAfterWithDraw > _balance;
        }
        public void Deposite(double amount)
        {
          
            _balance += amount;
        }
        public void Withdraw(double amount)
        {
            //double amountAfterWithDraw = _balance - amount;
            if (SufficientFund(amount) )
            {
                _balance-= amount;
            }
            else
            {
                //Console.WriteLine("NO fund");
                throw new Exception("No fund");
            }
        }
        public double Balance
        {
            get { 
                return _balance;
            }
        }
        public double Accountno
        {
            get { 
                return _accountno; 
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
