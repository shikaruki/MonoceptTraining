using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentApp.Model
{
    internal class Student
    {
        private string _name;
        private int _roll;
        private double _cgpa;
        private readonly int _accountNo;
        private double _remaingFee;
        private readonly double _totalFee;
        private const double MIN_BALANCE = 500;
        public Student(string pName, int proll, double pCgpa,int accountNo,double balance)
        {
            _name = ValidateName(pName);
            _roll = ValidateRoll(proll);
            _cgpa = ValidateCgpa(pCgpa);
            _accountNo = accountNo;
            _remaingFee = balance;
            _totalFee = balance;
        }
        public Student(int accoNo, string name,int proll) {
            _name = ValidateName(name);
            _accountNo = accoNo;
            _roll= ValidateRoll(proll);
            _remaingFee = MIN_BALANCE;
        }
        private string ValidateName(string pName)
        {
            if (pName.Length < 5)
                return ""; return pName;
        }
        private double ValidateCgpa(double pCgpa)
        {
            if (pCgpa < 0.0f) return 0.0f;
            else if (pCgpa > 10.0f) return 10.0f;
            return pCgpa;
        }
        private int ValidateRoll(int pRoll)
        {
            if (pRoll < 0) return -1 * pRoll;
            return pRoll;
        }
        public void Deposit(double amount)
        {
            _remaingFee += amount;
        }
        public void PayFee(double amount)
        {
            if (ValidateMinBalance(amount))
                _remaingFee -= amount;
            else
                Console.WriteLine("Min withdraw Error");
        }
        private bool ValidateMinBalance(double amount)
        {
            double balanceAfterWithdraw = _remaingFee - amount;
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
            get { return _remaingFee; }
        }
        public double Percentage
        {
            get { return _cgpa * 10; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = ValidateName(value); }
        }
        public int Roll
        {
            get { return _roll; }
            set { _roll = ValidateRoll(value); }
        }
        public double Cgpa
        {
            get { return _cgpa; }
            set { _cgpa = ValidateCgpa(value); }
        }

    }
}
