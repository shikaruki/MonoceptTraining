using TicTacToeLib.Model;

namespace TicTacToeConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");

            // Create the game board and result analyzer
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);

            // Create the players
            Player player1 = new Player { Name = "Player 1", Mark = MarkType.X };
            Player player2 = new Player { Name = "Player 2", Mark = MarkType.O };

            // Set up the game
            Game game = new Game(board, analyzer, new Player[] { player1, player2 });

            // Play the game
            while (game.Status == ResultType.NoResult)
            {
                Console.Clear();
                Console.WriteLine("Current Board:");
                DisplayBoard(board);

                // Get the current player's move
                Console.WriteLine($"{game.CurrentPlayer.Name}'s turn.");
                int cellPosition = GetCellPosition();

                try
                {
                    game.Play(cellPosition);
                }
                catch (CellAlreadyMarkedException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            // Display the result
            Console.Clear();
            Console.WriteLine("Final Board:");
            DisplayBoard(board);

            if (game.Status == ResultType.Win)
            {
                Console.WriteLine($"{game.CurrentPlayer.Name} has won the game!");
            }
            else if (game.Status == ResultType.Draw)
            {
                Console.WriteLine("The game ended in a draw.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static int GetCellPosition()
        {
            while (true)
            {
                Console.Write("Enter a cell position (0-8): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int cellPosition))
                {
                    if (cellPosition >= 0 && cellPosition < 9)
                    {
                        return cellPosition;
                    }
                }

                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        static void DisplayBoard(Board board)
        {
            for (int i = 0; i < 9; i += 3)
            {
                Console.WriteLine($"{board.Cells[i].Mark} | {board.Cells[i + 1].Mark} | {board.Cells[i + 2].Mark}");
            }
        }
    }
}
