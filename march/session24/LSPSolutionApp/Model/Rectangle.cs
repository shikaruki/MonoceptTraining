using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    internal class Rectangle : IPolygon
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {
            _width = width;

            _height = height;
        }
        public void SetWidth(int width) { 
            _width= width;
        }
        public void SetHeight(int height)
        {
            _height= height;
        }
        public int GetHeight
        {
            get { return _height; }
        }
        public int GetWidth
        {
            get { return _width; }
        }

        public double CalculateArea()
        {
            return _width * _height;
        }
    }
}
