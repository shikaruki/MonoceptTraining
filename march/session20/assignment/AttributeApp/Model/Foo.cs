using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeApp.Model
{
    internal class Foo
    {
        private void M1() { }
        [NeedToRefactorThis]
        private void M2() { }
        [NeedToRefactorThis]
        private void M3() { }
        private void M4() { }
    }
    
}
