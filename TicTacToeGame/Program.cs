using System;

namespace TicTacToeGame
{
    class Program
    {
        static char[] board = new char[10];
        static string choice = "";
        static int position = 0;
        static bool userWins = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tic Tac Toe");
            UC1_initialize();
            UC2_symbol();
            UC3_showBoard();
            movePosition();
            toss();
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

        static void movePosition()
        {
            while(true)
            {
                Console.WriteLine("Enter a position from 1 to 9 where you want to move");
                position = Convert.ToInt32(Console.ReadLine());
                if (board[position] == ' ')
                    break;
                else
                    Console.WriteLine("The entered position is already occupied");
            }
            board[position] = Convert.ToChar(choice);
            UC3_showBoard();
        }

        static void toss()
        {
            Random ran = new Random();
            int heads = ran.Next(0, 2);
            if (heads == 0)
                userWins = true;
            if (userWins == true)
                Console.WriteLine("User has won the toss");
            else
                Console.WriteLine("Computer has won the toss");
        }

    }
}
