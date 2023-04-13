namespace SimpleDelegatesApp
{
    internal class Program
    {
        delegate void DPrintMessage(string name);
        static void Main(string[] args)
        {
           // CaseStudy1();
            CaseStudy2();

            //DPrintMessage x;
            //x = PrintHello;
            //x = delegate (string name) { };
            //CaseStudy3();

        }

        private static void CaseStudy3()
        {
            DPrintMessage fptr = (n) => Console.WriteLine("Lambda {0}", n);
            fptr("Ravi");
        }

        private static void CaseStudy2()
        {
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);
            PrintWizard(delegate (string name)
            {
                Console.WriteLine("Anonymous Function 1 Delegates :{0}", name);
            });
            PrintWizard( (name)=>
            {
                Console.WriteLine("Inside Lambda Function 1 :{0}", name);
            });
        }

        private static void CaseStudy1()
        {
            DPrintMessage obj = PrintHello;

            obj += PrintGoodBye;
            obj += PrintHello;
            obj += PrintHello;
            //obj += Foo;
            obj("Ekta");
            obj("Ravi");
        }

        static void PrintWizard(DPrintMessage fptr)//fptr expecting function
        {
            Console.WriteLine("Doing printing operations ...");
            Console.WriteLine("Some operation completed");
            Console.WriteLine();
            fptr("Champ");
        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello {0}", name);

        }
        static void PrintGoodBye(string name)
        {
            Console.WriteLine("Goodbye {0}", name);
        }
        static void Foo()
        {
            Console.WriteLine("inside Foo");
        }
    }
}