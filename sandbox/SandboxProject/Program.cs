using System;
using System.Collections.Generic;

namespace SandboxProject
{
    class Program
    {
        static void Main(string[] args)
        {   
            string currentPlayer = "o";
            bool gameEnd = false;

            var board = new List<string>();
                //Adding to my board
                board.Add("1");
                board.Add("2");
                board.Add("3");
                board.Add("4");
                board.Add("5");
                board.Add("6");
                board.Add("7");
                board.Add("8");
                board.Add("9");
                board.Add("10");

            DisplayBoard(board);

            //StartGame
            while (gameEnd == false)
            {
                Console.Clear();
                DisplayBoard(board);

                Console.Write("Please enter choice (1-9)");
                int choice = int.Parse(Console.ReadLine());

                    for (int i = 0; i < 9; i++)
                    {
                        if (board[i] == "x" || board[i] == "o")
                        {
                            Console.WriteLine("Choose another number.");
                            int choice = int.Parse(Console.ReadLine());
                            board[choice - 1] = currentPlayer;
                        }
                        
                        else
                        {
                            board[choice - 1] = currentPlayer;
                        }
                    }
                    
                //switch players after every move
                if (currentPlayer == "x")
                {
                    currentPlayer = "o";
                }
                else
                {
                    currentPlayer = "x";
                }

                CheckForWin(currentPlayer, board);
                    break;
            }
           
     



            // Check for win
            static string CheckForWin(string currentPlayer, List<string> board)
            {
                if (board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer)
                {
                    return $"{currentPlayer} you won.";
                }
                else if (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer)
                {
                    return $"{currentPlayer} you won.";
                }
                else if (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer)
                {
                    return $"{currentPlayer} you won.";
                }
                else if (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer)
                {
                    return $"{currentPlayer} you won.";
                }
                else if (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer)
                {
                    return $"{currentPlayer} you won.";
                }
                else
                {
                    return $"It's a tie.";
                }
            }

            
            

            static void DisplayBoard(List<string> board)

            {
                Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            }
        }
        
        static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to my Tic Tac Toe Game");
        }
    }
}
