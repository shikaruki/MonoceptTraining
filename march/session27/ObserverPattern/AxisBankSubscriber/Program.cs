using AxisBankSubscriber.Notifiers;
using PublisherCoreLib.Model;

namespace AxisBankSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101,"Ravi");
            acc1.AddSubscriber(new EmailNotifier());
            acc1.AddSubscriber(new SmsNotifier());
            acc1.Deposit(1000);
            acc1.Withdraw(100);
           
        }
    }
}