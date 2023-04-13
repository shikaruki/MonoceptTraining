using FactoryMethodCoreLib.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public interface IAutoMobileFactory 
    {
        
        public IAutoMobile Make();
        public static IAutoMobile GetInstance
        {
            get;
        }
        
    }
}
