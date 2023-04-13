using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseSln.Model
{
    internal class FixedDeposit
    {
        private int _accNo;
        private string _name;
        private double _principalAmount;
        private int _duration;
        private FestivalTypes _festivalTypes;
        public FixedDeposit(int accno, string name, double principalAmt, int duration, FestivalTypes festivalTypes)
        {
            _accNo = accno;
            _name = name;
            _principalAmount = principalAmt;
            _duration = duration;
            _festivalTypes = festivalTypes;
        }
        public double CalculateRate()
        {
            if (_festivalTypes == FestivalTypes.DIWALI)
                return  .09;
            else if (_festivalTypes == FestivalTypes.NEW_YEAR)
                return  .08;
            return  .07;
        }
        public double SimpleInterest
        {
            get
            {
                return _principalAmount * CalculateRate() * _duration ;
            }
        }
        public string Name {
            get { return _name; }
        }
    }
}
