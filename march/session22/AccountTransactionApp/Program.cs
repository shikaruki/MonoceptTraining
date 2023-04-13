using AccountTransactionApp.Model;

namespace AccountTransactionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Ravi");
            Console.WriteLine(acc1.Balance);
            acc1.Withdraw(100);
            acc1.Deposit(100);

            CaseStudy1(acc1);
            CaseStudy2(acc1);

        }
        public static void CaseStudy1(Account acc1)
        {

            foreach (var transaction in acc1.Transactions)
            {
                Console.WriteLine(transaction);
            }
            Console.WriteLine();
        }
        public static void CaseStudy2(Account acc1)
        {
            IEnumerator<Transaction> enumerator = acc1.Transactions.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine();
        }
    }
}