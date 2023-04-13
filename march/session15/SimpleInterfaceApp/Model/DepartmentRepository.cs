using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class DepartmentRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Department Repository Inserted");
        }

        public void Delete()
        {
            Console.WriteLine("Department Repository Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Department Repository Selected");
        }

        public void Update()
        {
            Console.WriteLine("Department Repository Updated");
        }
    }
}
