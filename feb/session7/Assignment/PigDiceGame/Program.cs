using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turn = 0;
            int totalScore = 0;
            int diceGenerated;
            char inputChoice = 'k';
            Random rand = new Random();
            Console.WriteLine("Let's Play PIG!\r\n\r\n* See how many turns it takes you to get to 20.\r\n* Turn ends when you hold or roll a 1.\r\n* If you roll a 1, you lose all points for the turn.\r\n* If you hold, you save all points for the turn.");
            do
            {
                turn++;
                Console.WriteLine();
                Console.WriteLine("Turn {0} :", turn);
                Console.WriteLine();
                Console.WriteLine("Welcome to the game of Pig!");
                Console.WriteLine();
                int currentScore = 0;
                do
                {
                    do
                    {
                        Console.WriteLine("Enter 'r' to roll again, 'h' to hold.");
                        string input = Console.ReadLine();
                        char.TryParse(input, out inputChoice);
                    } while ((inputChoice != 'h') && (inputChoice != 'r'));
                    if (inputChoice == 'h')
                    {
                        totalScore += currentScore;
                        break;
                    }
                    diceGenerated = rand.Next(1, 7);
                    currentScore += diceGenerated;
                    Console.WriteLine("You rolled: {0}", diceGenerated);
                    Console.WriteLine("Your turn score is {0} and your total score is {1}", currentScore, totalScore);
                    Console.WriteLine("If you hold, you will have {0} points.\r\n", totalScore + currentScore);
                } while (inputChoice != 'h' && diceGenerated != 1);
            } while (totalScore < 20);
            Console.WriteLine("You Win! You finished in {0} turns!\r\n\r\nGame over!", turn);
        }
    }
}
