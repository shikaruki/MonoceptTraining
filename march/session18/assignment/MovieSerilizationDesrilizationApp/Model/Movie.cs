using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSerilizationDesrilizationApp.Model
{
    [Serializable]
    internal struct Movie
    {
        public int year;
        public string name;
    }
}
