using CustomerLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer(1001, "Ravi");
            FileStream fs = new FileStream("customer1.dump",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,customer1);
            fs.Close();
            Console.WriteLine("Serialization Completed");
        }
    }
}
