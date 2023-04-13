using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUnitTestApp.Model
{

    internal class Calculator
    {

        public int CubeEvenNo(int no)
        {
            return (no % 2 == 0) ? no * no * no : -1;
        }
        public int Add(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}
