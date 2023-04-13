using HumanSerializationApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HumanSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human Method Uses
            Human human1 = new Human("Ravi", 26, 64, 5.10f);
            Human human2 = new Human("Jishu", 24, 74, 5.11f);
            Human human3 = new Human("Hitlar", 25, 84, 5.10f);
            Human human4 = new Human("Kolambas", 22, 64, 5.8f);
            human1.Workout();
            human1.Eat();
            human2.Workout();
            human2.Eat();
            human3.Workout();
            human3.Eat();
            human4.Workout();
            human4.Eat();
            human4.Workout();
            //Human[] humans = new Human[] { human1, human2, human3, human4 };

            //foreach (Human human in humans)
            //    PrintDetails(human);

            //Serialization Part
            Human[] humans = new Human[] { human1, human2, human3, human4 };
            FileStream fileStream = new FileStream("humans.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, humans);
            fileStream.Close();
            Console.WriteLine("Serialization Completed");
        }
        static void PrintDetails(Human human)
        {
            Console.WriteLine(human.Name);
            Console.WriteLine(human.Weight);
            Console.WriteLine(human.Height);
            Console.WriteLine();
        }
    }
}
