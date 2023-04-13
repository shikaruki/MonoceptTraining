using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    public interface IPolygon
    {
        public double CalculateArea();
        public void SetHeight(int height);
        public void SetWidth(int width);
        public int GetWidth
        {   get;  }
        public int GetHeight
        {   get;  }

    }
}
