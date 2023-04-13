using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CalcExceptionApp.Model
{
    internal class NegativeValuesNotSupportedException : Exception
    {
        Calculator calculator;
        public NegativeValuesNotSupportedException(Calculator calculator) {
            this.calculator = calculator;
        }
        public override string Message
        {
            get
            {
                string message = $"Negative NO. Exception";                
                return message;
            }
        }

    }
}
