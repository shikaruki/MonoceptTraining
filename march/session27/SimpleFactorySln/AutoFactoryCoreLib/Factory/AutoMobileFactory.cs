using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactoryCoreLib.Factory
{
   
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _instance;
        private AutoMobileFactory() { }
        public IAutoMobile Make(AutoOption auto)
        {
            if (auto == AutoOption.BMW)
            {
                return new BMW();
            }
            else if (auto == AutoOption.Tesla)
            {
                return new Tesla();
            }
            return new Audi();
        }

        public static AutoMobileFactory GetInstance
        {
            get { if(_instance == null)_instance= new AutoMobileFactory();
                return _instance;
            }
        }
    }
}
