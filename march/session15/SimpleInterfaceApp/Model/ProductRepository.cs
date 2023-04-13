using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class ProductRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Product Repository Inserted");
        }

        public void Delete()
        {
            Console.WriteLine("Product Repository Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Product Repository Selected");
        }

        public void Update()
        {
            Console.WriteLine("Product Repository Updated");
        }
    }
}
