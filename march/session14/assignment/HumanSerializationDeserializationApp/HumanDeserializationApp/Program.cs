
using HumanSerializationApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HumanDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("humans.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Object obj = binaryFormatter.Deserialize(fs);
            Human[] humans = obj as Human[];
            foreach (Human human in humans)
                PrintDetails(human);
        }
        static void PrintDetails(Human human)
        {
            Console.WriteLine("Name : {0} ", human.Name);
            Console.WriteLine("Age : {0}", human.Age);
            Console.WriteLine("Weight : {0}", human.Weight);
            Console.WriteLine("Height : {0}", human.Height);
            Console.WriteLine();
        }
    }
}
