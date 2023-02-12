using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {
        static List<string> games = new List<string>();

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

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("Press enter to go back to the main menu.");
            Console.ReadLine();
            Console.Clear();
            Menu.ShowMenu();
        }

        internal static void UpdateGameHistory(string gameType, int gamescore)
        {
            games.Add($"{DateTime.Now} - Date, Game Type: {gameType}, score = {gamescore}");
        }
    }
}
