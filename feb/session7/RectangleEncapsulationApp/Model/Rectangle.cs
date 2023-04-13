using System;
namespace RectangleEncapsulationApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;
        public int CalculateArea()
        {
            return _width * _height;
        }
        public void SetWidth(int pwidth)
        {
            //if (pwidth < 0) _width = 1;
            //else if (pwidth > 100)
            //    _width = 100;
            //else
            //    _width=pwidth;
            _width= CheckHeightOrWidht(pwidth);
        }
        public void SetHeight(int pheight)
        {
            _height= CheckHeightOrWidht(pheight);
        }
        public void SetColor(string color) {
            string pcolor = color.ToLower();
            if(pcolor == "red" || pcolor =="blue" || pcolor == "green")
                _color = color;
            else
                _color = "red";
        }
        public int GetWidth()
        { return _width; }
        public int GetHeight() { return _height;}
        public string GetColor()
        { return _color; }

        private int CheckHeightOrWidht(int input)
        {
            if (input < 0) return  1;
            else if (input > 100)
                return 100;            
                return input;
        }
    }
}
