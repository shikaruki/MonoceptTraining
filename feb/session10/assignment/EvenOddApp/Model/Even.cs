using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddApp.Model
{
    internal class Even
    {
        private int _size;
        private int _range1;
        private int _range2;
        public Even(int range)
        {
            _size = range / 2;
            _range1 = 1;
            _range2 = range;
        }
        public Even(int range1, int range2)
        {
            _range1 = range1;
            _range2 = range2;
            if (range1 % 2 == 1 && range2 % 2 == 1)
                _size = (range2 - range1) / 2;
            else
                _size = (range2 - range1) / 2 + 1;
        }
        public int[] GetEven()
        {
            int[] evenNo = new int[_size];
            int index = 0;
            for (int i = _range1; i <= _range2; i++)
                if (i % 2 == 0)
                    evenNo[index++] = i;
            return evenNo;
        }
    }
}
