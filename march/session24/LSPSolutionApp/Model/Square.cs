using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{

    internal class Square : IPolygon
    {
        protected int _height;
        protected int _width;

        public Square(int side)
        {
            _height = side;
            _width = side;
        }
        public int GetHeight
        {
            get { return _height; }
        }
        public int GetWidth
        {
            get { return _width; }
        }
        public void SetWidth(int width)
        {
            _width = width;
        }
        public void SetHeight(int height)
        {
            _height = height;
        }
        public double CalculateArea()
        {
            return _height * _width;
        }
    }
}
