using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    internal class Player:Object
    {
        private readonly int id;
        private readonly string name;
        private readonly int age;
        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine("Inside 3 param constructor");
        }
        public Player(int id, string name)
        {
            id = id;
            this.name = name;
            this.age = 18;
            Console.WriteLine("inside 2 param constructor");
        }
        public Player WhoIsElder(Player secondPlayer)
        {
            return this.age > secondPlayer.age?this:secondPlayer;
        }
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
    }
}
