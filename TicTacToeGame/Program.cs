using System;

namespace TicTacToeGame
{
    class Program
    {
        static char[] board = new char[10];
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tic Tac Toe");
            UC1_initialize();
            
        }

        static void UC1_initialize()
        {
            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }

    }
}
