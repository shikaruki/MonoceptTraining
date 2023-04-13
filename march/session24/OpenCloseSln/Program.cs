using OpenCloseSln.Model;

namespace OpenCloseSln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Ravi", 100000, 10, FestivalTypes.NORMAL);
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}