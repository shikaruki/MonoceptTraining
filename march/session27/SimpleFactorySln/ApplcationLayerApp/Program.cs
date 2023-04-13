using AutoFactoryCoreLib.Factory;

namespace ApplcationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            var factory1 = AutoMobileFactory.GetInstance;
            var auto = factory1.Make(AutoOption.Tesla);
            auto.Start();
            auto.Stop();
            var factory2 = AutoMobileFactory.GetInstance;
            var auto2 = factory2.Make(AutoOption.BMW);
            auto2.Start();
            auto2.Stop();
            Console.WriteLine(auto.GetType());
        }
    }
}