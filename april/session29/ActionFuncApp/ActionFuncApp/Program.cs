namespace ActionFuncApp
{
    internal class Program
    {
        delegate bool DChecker(int no);
        static void Main(string[] args)
        {
            CaseStudy1();
        }

        private static void CaseStudy1()
        {
            DChecker isEvenPtr = CheckIsEven;
            Console.WriteLine(isEvenPtr(30));

            //Predicate<int> isEvenPtr = CheckIsEven;
            
            //directly go with predicate no need to use delicate here
        }

        static bool CheckIsEven(int no)
        {
            return no %2 ==0;
        }
        
    }
}