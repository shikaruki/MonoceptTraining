using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class CustomerRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Repository Inserted");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Repository Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Customer Repository Selected");
        }

        public void Update()
        {
            Console.WriteLine("Customer Repository Modified");
        }
    }
}
