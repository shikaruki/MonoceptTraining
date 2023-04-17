using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatLib.Model
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        private const double GST = .08;
        public Hat(string shortName, string longName, double basePrice)
        {
            _shortName = shortName;
            _longName = longName;
            _basePrice = basePrice;
        }
        public double GetPrice { get { return _basePrice + _basePrice * GST; } }
        public string ShortName { get { return _shortName;} }
        public string LongName { get { return _longName;} }
    }
}
