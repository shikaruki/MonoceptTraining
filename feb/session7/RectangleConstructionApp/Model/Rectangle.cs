using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructionApp.Model
{
    internal class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private string _color;

        public Rectangle(int width, int height, string color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = ValidateColor(color);
        }
        private int ValidateSide(int side)
        {
            if (side > 100)
                return 100;
            else if (side < 0) return 1;
            return side;
        }
        private string ValidateColor(string color)
        {
            string pcolor = color.ToLower();
            if (pcolor == "red" || pcolor == "green" || pcolor == "yellow")
                return color;
            return "red";
        }
        public int CalculateArea()
        {
            return _width * _height;
        }

        public string GetColor() { return _color; }
        public int GetWidth() { return _width; }
        public int GetHeight() { return _height; }
        public void SetColor(string pcolor)
        {
            _color = ValidateColor(pcolor);
        }
    }
}
