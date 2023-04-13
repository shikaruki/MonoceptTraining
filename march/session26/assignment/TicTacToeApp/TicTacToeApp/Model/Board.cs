using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeApp.Model
{
    internal class Board
    {
        private static char[,] board = new char[3, 3]; // 3x3 board
        private static char player1 = 'X';
        private static char player2 = 'O';
        private static char currentPlayer = player1;
        private static int row, col;
        static void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = '-';
                }
            }
        }
        static void TakeUserInput()
        {
            Console.WriteLine($"Player {currentPlayer}, choose your position (row, column):");
            string[] input = Console.ReadLine().Split(',');
            row = int.Parse(input[0]) - 1;
            col = int.Parse(input[1]) - 1;
        }
        public static void StartGame()
        {
            InitializeBoard();
            while (true)
            {
                DisplayBoard();
                TakeUserInput();
                if (IsValidMove(row, col))
                {
                    MakeMove(row, col);
                    if (HasWon())
                    {
                        Console.WriteLine($"Player {currentPlayer} wins!");
                        break;
                    }
                    else if (IsBoardFull())
                    {
                        Console.WriteLine("It's a tie!");
                        break;
                    }
                    SwitchPlayer();
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
        }
        static void DisplayBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                    Console.Write($"{board[row, col]} ");
                Console.WriteLine();
            }
        }

        static bool IsValidMove(int row, int col)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2)
                return false;

            return board[row, col] == '-';
        }

        static void MakeMove(int row, int col)
        {
            board[row, col] = currentPlayer;
        }

        static bool HasWon()
        {
            // Check rows
            for (int row = 0; row < 3; row++)
                if (board[row, 0] == currentPlayer && board[row, 1] == currentPlayer && board[row, 2] == currentPlayer)
                    return true;

            // Check columns
            for (int col = 0; col < 3; col++)
                if (board[0, col] == currentPlayer && board[1, col] == currentPlayer && board[2, col] == currentPlayer)
                    return true;

            // Check diagonals
            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                return true;

            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                return true;

            return false;
        }

        static bool IsBoardFull()
        {
            for (int row = 0; row < 3; row++)
                for (int col = 0; col < 3; col++)
                    if (board[row, col] == '-')
                        return false;
            return true;
        }

        static void SwitchPlayer()
        {
            if (currentPlayer == player1)
                currentPlayer = player2;
            else
                currentPlayer = player1;
        }
    }
}

