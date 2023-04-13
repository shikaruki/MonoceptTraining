using FixedDepositCoreLib.Model;
using HDFCBankFDApp.Model;

namespace HDFCBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit quarter1Policy = new FixedDeposit(1, "Ravi", 10000, 5, new Quarter1Policy());
            FixedDeposit quarter2Policy = new FixedDeposit(2, "Shikaruki", 10000, 5, new Quarter2Policy());
            Console.WriteLine(quarter1Policy.SimpleInterest);
            Console.WriteLine(quarter2Policy.SimpleInterest);
        }
    }
}