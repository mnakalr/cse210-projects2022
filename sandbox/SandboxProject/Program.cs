﻿using System;
using System.Collections.Generic;

namespace SandboxProject
{
    class Program
    {
        static void Main(string[] args)
        {   
            string currentPlayer = "o";

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

            while (true)
            {
                Console.Clear();
                DisplayBoard(board);

                Console.Write("Please enter choice (1-9)");
                int choice = int.Parse(Console.ReadLine());

                board[choice - 1] = currentPlayer;

                ChangeTurn(currentPlayer);

                CheckForWin(currentPlayer, board);
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



            static string ChangeTurn(string currentPlayer)
            {
                if (currentPlayer == "x")
                {
                    return "o";
                }
                    else
                {
                    return "x";
                }
            }

            static void DisplayBoard(List<string> board)

            {

                Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
                Console.WriteLine("-+-+-");
            }
        }

        
        
        static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to my Tic Tac Toe Game");
        }
    }
}
