using SimpleInterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new CustomerRepository());
            DoDbOperations(new DepartmentRepository());
            DoDbOperations(new ProductRepository());
        }
        static void DoDbOperations(ICrudable cruadable)
        {
            Console.WriteLine("Doing Db Operations");
            cruadable.Create();
            cruadable.Update();
            cruadable.Delete();
            cruadable.Read();
            Console.WriteLine();
        }
    }
}
