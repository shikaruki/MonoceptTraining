using AutoFactoryCoreLib.Factory;

namespace ApplcationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoMobileFactory factory = new AutoMobileFactory();
            IAutoMobile auto = factory.Make(AutoOption.Tesla);
            auto.Start();
            auto.Stop();
            Console.WriteLine(auto.GetType());
        }
    }
}