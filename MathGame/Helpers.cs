using MathGame.Models;
using System;
using System.Collections.Generic;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new();

        internal static int[] GetNiceDivisionNumbers()
        {
            int[] numbers = new int[2];
            var random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            numbers[0] = firstNumber;
            numbers[1] = secondNumber;

            return numbers;
        }

        internal static void GetGameHistory()
        {
            Console.WriteLine("Games Played");
            Console.WriteLine("------------");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: Score = {game.Score}");
            }

            Console.WriteLine("Press enter to go back to the main menu.");
            Console.ReadLine();
            Console.Clear();
            Menu.ShowMenu();
        }

        internal static void UpdateGameHistory(GameType gameType, int gamescore)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gamescore,
                Type = gameType,
            });
        }
    }
}
