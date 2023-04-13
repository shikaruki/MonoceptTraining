using System;

//1.Make a notes and Learning Journal2. Ethics3. Try to help friends4. Dont give up, Effort, Stick around5. To know each other6. Have a goal and vision7. Training 4days * 4 hours8. Complete home and class assignments9. Clarify your doubts and be confident10. Be Better in Communication, Confidence, Commitment, Potential, problem solving, Passion, performance

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int wannTryAgain = 1;
            do
            {
                int randNumGenerated = randNum.Next(1, 101);
                Console.WriteLine("generated no. {0}", randNumGenerated);
                Console.WriteLine("The Random No. is Generated You need to start guessing the NO. ");
                int i = 0;
                int guessNum;
                do
                {
                    guessNum = Convert.ToInt32(Console.ReadLine());
                    i++;
                    if (guessNum < randNumGenerated)
                        Console.WriteLine("Sorry, Too Low");
                    else if (guessNum > randNumGenerated)
                        Console.WriteLine("Sorry, Too High ");
                    else
                        Console.WriteLine("you have successfully Gussed the no. in {0} attempts.", i);
                } while (guessNum != randNumGenerated);
                Console.WriteLine("Do you wish to play the game Again. press \n 1 to play again. \n 0. to quit the game.");
                wannTryAgain = Convert.ToInt32(Console.ReadLine());
            } while (wannTryAgain != 0);
        }

       
       
    }
}
