using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    internal class Rectangle
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {
            _width = width;

            _height = height;
        }
        int CalculateArea()
        {
            return _width * _height;
        }
        virtual public void SetWidth(int width) { 
            _width= width;
        }
        virtual public void SetHeight(int height)
        {
            _height= height;
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
    }
}
