using InterfacePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();
            AtThePartyHall(man);
            AtThePartyHall(boy);
            //AtTheCinemaHall(man);
            AtTheCinemaHall(boy);

        }
        static void AtThePartyHall(IMannerable mannerable)
        {

            Console.WriteLine("At the Party");
            mannerable.Wish();
            mannerable.Depart();
            Console.WriteLine("Party Ends");
            Console.WriteLine();
        }
        static void AtTheCinemaHall(IEmotional emotional)
        {
            Console.WriteLine("At the cinema Hall");
            emotional.Cry();
            emotional.Laugh();
            Console.WriteLine("Cinema Ends");
            Console.WriteLine();
        }
    }
}
