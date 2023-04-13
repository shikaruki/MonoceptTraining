using System;
namespace AccountApp.Model
{
    internal class Account : Object
    {
        private string _name;
        private double _balance;
        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }
        public Account(Account account)
        {
            _name = account.Name;
            _balance = account.Balance;
        }
        public Account()
        {
            _name = "";
            _balance = 0;
        }
        public Account WhoIsReachest(Account paccount)
        {
            return this._balance > paccount._balance ? this : paccount;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
