using FactoryMethodCoreLib.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public class BMWFactory : IAutoMobileFactory
    {
        private static IAutoMobile _instance;

        public BMWFactory() { }
        public static IAutoMobile GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BMW();
                }
                return _instance;
            }
        }

        public  IAutoMobile Make()
        {
            return new BMW();
        }
    }
}
