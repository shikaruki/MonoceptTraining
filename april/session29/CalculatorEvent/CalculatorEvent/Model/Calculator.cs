using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEvent.Model
{
    delegate void OperationPerformed(int a, int b,string result);
    internal class Calculator
    {
        public event OperationPerformed? OnOperationPerformed;
        public void Add(int a, int b)
        {
            string result = $"Addition {a} + {b} : {a + b}";
            if(OnOperationPerformed != null)
            {
                OnOperationPerformed(a,b,result);
            }
            
        }
        public void Substract(int a, int b)
        {
            string result = $"Substraction {a} - {b}: {a - b}";
            if (OnOperationPerformed != null)
            {
                OnOperationPerformed(a, b,result);
            }
        }

    }
}
