using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleWithProperties.Model
{
    internal class Circle
    {
        private readonly int _radius;
        private string _borderStyle;
        private string _color;
        public Circle(int radius, string borderStyle, string color)
        {
            _radius = ValidateRadius(radius);
            _borderStyle = ValidateBorder(borderStyle);
            _color = ValidateColor(color);
        }
        private string ValidateBorder(string borderStyle)
        {
            string temBoarder = borderStyle.ToLower();
            if (temBoarder == "line" || temBoarder == "dot" || temBoarder == "circle")
            {
                return borderStyle;
            }
            return "dot";
        }
        private int ValidateRadius(int side)
        {
            if (side > 100)
                return 100;
            else if (side < 5) return 5;
            return side;
        }
        private string ValidateColor(string color)
        {
            string pcolor = color.ToLower();
            if (pcolor == "red" || pcolor == "green" || pcolor == "yellow")
                return color;
            return "red";
        }
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
        public int Radius
        {
            get { return _radius; }
        }
        public string BorderStyle
        {
            get { return _borderStyle; }
            set { _borderStyle = ValidateBorder(value); }
        }
        public string Color
        {
            get { return _color; }
            set { _color = ValidateColor(value); }
        }
    }
}
