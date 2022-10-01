using System;
using System.Collections.Generic;

namespace Playgrounds
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentPlayer = "x";
            string player1 = ChangePlayers(currentPlayer);
            Console.WriteLine($"player 1 is: {player1}");
            string player2 = ChangePlayers(currentPlayer);
            Console.WriteLine($"player 2 is: {player2}");
        
        }

        static string ChangePlayers(string currentPlayer)
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
    }
}













