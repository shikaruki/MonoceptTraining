﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositCoreLib.Model
{
    public class FixedDeposit
    {
        private int _accNo;
        private string _name;
        private double _principalAmount;
        private int _duration;
        private IRatePolicy _ratePolicy;
        public FixedDeposit(int accno, string name, double principalAmt, int duration, IRatePolicy ratePolicy)
        {
            _accNo = accno;
            _name = name;
            _principalAmount = principalAmt;
            _duration = duration;
            _ratePolicy = ratePolicy;
        }
        public double SimpleInterest
        {
            get
            {
                return _principalAmount * _duration * _ratePolicy.CalculateRate() ;
            }
        }
        public string Name {
            get { return _name; }
        }
    }
}
