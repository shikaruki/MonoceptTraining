using FactoryMethodCoreLib.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public class AudiFActory : IAutoMobileFactory
    {

        private static IAutoMobile _instance;
        
        public static IAutoMobile GetInstance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Audi();
                }
                return _instance;
            }
        }

        public IAutoMobile Make()
        {
            return new Audi();
        }
        
    }
}
