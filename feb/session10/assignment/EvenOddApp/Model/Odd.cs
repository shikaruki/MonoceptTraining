using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddApp.Model
{
    internal class Odd
    {
        private int _size;
        private int _range1;
        private int _range2;
        public Odd(int range)
        {
            if (range % 2 == 0)
                _size = (int)range / 2;
            else
                _size = (int)range / 2 + 1;
            _range1 = 1;
            _range2 = range;
        }
        public Odd(int range1, int range2)
        {
            _range1 = range1;
            _range2 = range2;
            if (range1 % 2 == 0 && range2 % 2 == 0)
                _size = (range2 - range1) / 2;
            else
                _size = (range2 - range1) / 2 + 1;
        }
        public int[] GetOdd()
        {
            int[] oddNo = new int[_size];
            int index = 0;
            for (int i = _range1; i <= _range2; i++)
                if (i % 2 == 1)
                    oddNo[index++] = i;
            return oddNo;
        }
    }
}
