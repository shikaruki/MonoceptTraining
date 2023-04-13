using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUnitTestApp.Model
{
    internal class Calculate
    {
        public int CubeEvenNum(int num) 
        {
            if (num % 2 == 0)
                return (num * num * num);
            else
                return -1;
           
        }
        public int AddedNum(params int[] number)
        {

            int result = 0;
            foreach(int num in number)
            {
                result += num;
            }

            return  result;
        }
    }
}
