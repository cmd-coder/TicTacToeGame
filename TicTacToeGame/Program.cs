using System;

namespace TicTacToeGame
{
    class Program
    {
        static char[] board = new char[10];
        static char choice = ' ';
        static char computerChoice='X';
        static int position = 0;
        static bool userWins = false;
        static bool userWinsGame = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tic Tac Toe");
            UC1_initialize();
            UC2_symbol();
            UC3_showBoard();
            movePosition();
            toss();
            bool result = checkWinner(choice);
            Console.WriteLine("User hass won: " + result);
        }

        static void UC1_initialize()
        {
            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }

        static void UC2_symbol()
        {
            Console.WriteLine("Enter to choose O (capital o) or to choose X (capital x)");
            choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You will play with: " + choice);
            if (choice == 'O')
                Console.WriteLine("Computer will play with: X");
            else
            {
                Console.WriteLine("Computer will play with: O");
                computerChoice = 'O';
            }

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
            board[position] = choice;
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

        static bool checkWinner(char choice)
        {
            if ((board[1] == choice && board[2] == choice && board[3] == choice)
                || (board[4] == choice && board[5] == choice && board[6] == choice)
                || (board[7] == choice && board[8] == choice && board[9] == choice)
                || (board[1] == choice && board[4] == choice && board[7] == choice)
                || (board[2] == choice && board[5] == choice && board[8] == choice)
                || (board[3] == choice && board[6] == choice && board[9] == choice)
                || (board[1] == choice && board[5] == choice && board[9] == choice)
                || (board[3] == choice && board[5] == choice && board[7] == choice))
                return true;
            return false;
        }

        static void computerTurn()
        {
            int index = whoWins(computerChoice);
            if (index != 0)
                Console.WriteLine("Computer has won the match");
            else
            {
                index = whoWins(choice);
                if(index!=0)
                {
                    board[index] = computerChoice;
                }
                else
                {
                    if (board[1] == ' ')
                        board[1] = computerChoice;
                    else if (board[3] == ' ')
                        board[3] = computerChoice;
                    else if (board[7] == ' ')
                        board[7] = computerChoice;
                    else if (board[9] == ' ')
                        board[9] = computerChoice;
                }
            }
        }

        static int whoWins(char option)
        {
            int index = 0;
            for (int i = 1; i < board.Length; i++)
            {
                if (board[i] == ' ')
                {
                    board[i] = option;
                    bool compWins = checkWinner(option);
                    if (compWins)
                    {
                        index = i;
                        board[i] = ' ';
                        break;
                    }
                    else
                    {
                        board[i] = ' ';
                        continue;
                    }
                }
            }
            return index;
        }

    }
}
