using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactoryCoreLib.Factory
{

    public interface IAutoMobile 
    {
        public void Start();
        public void Stop();
        public IAutoMobile Make();
    }
}
