using PlayerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Player playerA = new Player(7, "Dhoni");
            //Player PlayerB = new Player(11, "Ravi", 26);
            //PrintDetails(playerA, "Dhoni details");
            //PrintDetails(PlayerB, "PlayerB Details");
            //Player elder = playerA.WhoIsElder(PlayerB);
            //PrintDetails(elder, "Elder player Details");
            //Console.WriteLine(elder.Name);
            //Console.WriteLine();
            //Console.WriteLine("playerA hash code "+playerA.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine("PlayerB hash code "+PlayerB.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine("elder hash code "+elder.GetHashCode());
            Player ravi = new Player(1,"ravi",26);
            Player[] manyPlayers = new Player[5];
            manyPlayers[0] = new Player(2, "Player1", 20);
            manyPlayers[1] = ravi;
            manyPlayers[2] = ravi;
            manyPlayers[3] = ravi;
            manyPlayers[4] = ravi;
            
            foreach(Player player in manyPlayers)
            {
                PrintDetails(player, "");
            }
        }
        public static void PrintDetails(Player player,string description)
        {
            Console.WriteLine();
            Console.WriteLine(description);
            Console.WriteLine("Name : "+player.Name);
            Console.WriteLine("ID : " + player.Id);
            Console.WriteLine("Age : " + player.Age);
            Console.WriteLine("Hash Code "+player.GetHashCode());
            Console.WriteLine();
        }
    }
}
