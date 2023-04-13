using FactoryMethodCoreLib.Factory;
using FactoryMethodCoreLib.Factory.Product;

namespace FactoryMethodClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory1 = BMWFactory.GetInstance;
            var auto = factory1.Make();

        }
    }
}