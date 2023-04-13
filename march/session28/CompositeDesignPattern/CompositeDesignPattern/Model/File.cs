﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Model
{
    internal class File : IStorageItem
    {
        private string _name;
        private int _size;
        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }
        public void Display(int depth = 0)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write(" ");
            }
                Console.WriteLine("{0} - {1} MB", _name, _size);
            
        }
    }
}
