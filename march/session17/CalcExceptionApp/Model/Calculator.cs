using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExceptionApp.Model
{
    internal class Calculator
    {
        public Calculator() { }
        public int Add(int firstNo,int secondNo)
        {
                if(firstNo < 0|| secondNo < 0)
                    throw new NegativeValuesNotSupportedException(this);
                return firstNo + secondNo;
        }
    }
}
