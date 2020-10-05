using System;

namespace TicTacToeGame
{
    class Program
    {
        static char[] board = new char[10];
        static string choice = "";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tic Tac Toe");
            UC1_initialize();
            UC2_symbol();
            UC3_showBoard();
        }

        static void UC1_initialize()
        {
            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }

        static void UC2_symbol()
        {
            Console.WriteLine("Enter to choose O (capital o) or to choose X (capital x)");
            choice = Console.ReadLine();
            Console.WriteLine("You will play with: " + choice);
            if (choice == "O")
                Console.WriteLine("Computer will play with: X");
            else
                Console.WriteLine("Computer will play with: O");

        }

        static void UC3_showBoard()
        {
            int size = (int)Math.Sqrt(board.Length);
            for (int i = 1; i < board.Length; i++)
            {
                Console.Write(board[i] + "|");
                if (i % size == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("--------------------");
                }
            }
        }

    }
}
