using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp.Model
{
    internal class Circle
    {
        private float _radius;
        private string _color;
        private string _border_Style;
        public void SetRadius(float pradius)
        {
            if (pradius < 10)
            {
                _radius = 10;
            }
            else if (pradius > 50)
                _radius = 50;
            else
                _radius = pradius;
        }
        public float GetRadius()
        {
            return _radius;
        }
        public void SetColor(string color)
        {
            string pcolor = color.ToLower();
            if (pcolor == "red" || pcolor == "blue" || pcolor == "yellow")
                _color = color;
            else
                _color = "blue";
        }
        public  string GetColor()
        {
            return _color;
        }
        public void SetBoarder(string boarder)
        {
            string temBoarder = boarder.ToLower();
            if (temBoarder == "line" || temBoarder == "dot" || temBoarder == "circle")
            {
                _border_Style = boarder;
            }
            else
                _border_Style = "dot";
        }
        public string GetBoarder()
        {
                return _border_Style;
        }
        public double GetPerimeter()
        {
            return 2.0 * 3.14 * _radius ;
        }
        public float GetArea()
        {
            return (float)3.14 * _radius * _radius;
        }
    }
}
