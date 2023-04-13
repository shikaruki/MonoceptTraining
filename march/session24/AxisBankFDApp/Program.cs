using AxisBankFDApp.Model;
using FixedDepositCoreLib.Model;
namespace AxisBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit diwaliFixedDeposit = new FixedDeposit(1, "Ravi", 10000, 5, new DiwaliPolicy());
            FixedDeposit newYearPolicy = new FixedDeposit(2,"Shikaruki",10000,5,new NewYearPolicy());

            Console.WriteLine(diwaliFixedDeposit.SimpleInterest);
            Console.WriteLine(newYearPolicy.SimpleInterest);
        }
    }
}