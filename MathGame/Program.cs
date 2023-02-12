using System;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get name and start games
            Console.WriteLine("Welcome to the math game!\n");
            string name = Menu.GetName();

            Console.WriteLine($"Welcome, {name}!\n");

            Menu.ShowMenu();  
        }
    }
}
