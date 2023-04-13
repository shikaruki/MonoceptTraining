

using System;

namespace CommandLineArgsApp
{
    internal class Program
    {
        static void Main(string[] argsOfNames)
        {
            //ildasm for checking the 
            Console.WriteLine("inside the main");
            for(int i = 0; i < argsOfNames.Length; i++)
            {
                Console.WriteLine("dk" + argsOfNames[i]);
            }
            Console.WriteLine("end of the main");
        }
    }
}
