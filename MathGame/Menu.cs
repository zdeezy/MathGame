using System;

namespace MathGame
{
    internal class Menu
    {
        internal static void ShowMenu()
        {
            var game = new GameLogic();

            Console.WriteLine($@"What game would you like to play?
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                H - Game History
                Q - Quit");
            Console.WriteLine("----------------------------------");

            var selection = Console.ReadLine();

            Console.Clear();

            if (selection.ToLower().Trim() == "a")
            {
                game.Addition("Addition game!");
            }
            else if (selection.ToLower().Trim() == "s")
            {
                game.Subtraction("Subraction game!");
            }
            else if (selection.ToLower().Trim() == "m")
            {
                game.Multiplication("Multiplication game!");
            }
            else if (selection.ToLower().Trim() == "d")
            {
                game.Division("Division game!");
            }
            else if (selection.ToLower().Trim() == "h")
            {
                Helpers.GetGameHistory();
            }
            else
            {
                game.QuitGame();
            }
        }

        internal static string GetName()
        {
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            return playerName;
        }
    }
}
