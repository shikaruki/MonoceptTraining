using PublisherCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankSubscriber.Notifiers
{
    internal class EmailNotifier : IAccountNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Seding sms notification");
            Console.WriteLine("Account holder is " + account.Name);
            Console.WriteLine("Final Balance is " + account.Balance);
            Console.WriteLine();
        }
    }
}
