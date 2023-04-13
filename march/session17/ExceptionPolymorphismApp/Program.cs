

using ExceptionPolymorphismApp.Model;

namespace ExceptionPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }


        private static void CaseStudy1()
        {
            Account account = new Account(121, "RAvi", 8000);
            try
            {
                account.Withdraw(7800);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}