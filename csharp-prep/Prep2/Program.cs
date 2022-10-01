using System;

namespace solo_prep_2
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

































// using System;

// namespace solo_prep_2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("What is your grade percentage? ");
//             string answer = Console.ReadLine();
//             int percent = int.Parse(answer);

//             string letter = "";

//             if (percent >= 90)
//             {
//                 letter = "A";
//             }
//             else if (percent >= 80)
//             {
//                 letter = "B";
//             }
//             else if (percent >= 70)
//             {
//                 letter = "C";
//             }
//             else if (percent >= 60)
//             {
//                 letter = "D";
//             }
//             else
//             {
//                 letter = "F";
//             }

//             Console.WriteLine($"Your grade is: {letter}");
            
//             if (percent >= 70)
//             {
//                 Console.WriteLine("You passed!");
//             }
//             else
//             {
//                 Console.WriteLine("Better luck next time!");
//             }
//         }
//     }
// }