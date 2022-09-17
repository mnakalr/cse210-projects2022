using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string Firstname = Console.ReadLine();

            Console.Write("What is your last name? ");
            string Lastname = Console.ReadLine();

            Console.WriteLine($"Your name is {Lastname}, {Firstname}, {Lastname}.");

            // Write your code here
        }
    }
}
