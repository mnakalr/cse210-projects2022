using System;

namespace solo_prep_2
{
    class Program
    {
        static void Main(string[] args)
        
            
        {
            string currentPlayer = "x";
            if (currentPlayer == "x")
            {
                currentPlayer = "o";
            }
            else
            {
                currentPlayer = "x";
            }

            Console.WriteLine($"player 1 is: {currentPlayer}");

            if (currentPlayer == "x")
            {
                currentPlayer = "o";
            }
            else
            {
                currentPlayer = "x";
            }

            Console.WriteLine($"player 2 is: {currentPlayer}");
        
        }
    }
}














