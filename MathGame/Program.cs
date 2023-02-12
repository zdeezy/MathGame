using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get name and start games
            Console.WriteLine("Welcome to the math game!\n");
            string name = GetName();

            var games = new List<string>();

            Console.WriteLine($"\nWelcome, {name}!\n");

            int score = 0;

            MainMenu();

            // Methods
            void MainMenu()
            {
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
                    Addition("Addition game!");
                }
                else if (selection.ToLower().Trim() == "s")
                {
                    Subtraction("Subraction game!");
                }
                else if (selection.ToLower().Trim() == "m")
                {
                    Multiplication("Multiplication game!");
                }
                else if (selection.ToLower().Trim() == "d")
                {
                    Division("Division game!");
                }
                else if (selection.ToLower().Trim() == "h")
                {
                    GetGameHistory();
                }
                else
                {
                    QuitGame();
                }
            }

            string GetName()
            {
                Console.WriteLine("What is your name?");
                string playerName = Console.ReadLine();
                return playerName;
            }

            void Addition(string message)
            {
                Console.Clear();
                Console.WriteLine($"{message}");

                int numCorrect = 0;
                int numIncorrect = 0;
                int rounds = 9;

                for (int i = 0; i < 10; i++)
                {
                    var random = new Random();
                    int firstNumber = random.Next(1, 9);
                    int secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} + {secondNumber}?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber + secondNumber)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect++;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try Again!");
                        numIncorrect++;
                    }

                    Console.WriteLine($"Keep Going! {rounds} rounds left!");
                    Console.WriteLine("Press enter to continue: ");
                    Console.ReadLine();

                    rounds--;

                    Console.Clear();                    
                }

                UpdateGameHistory("Addition", score);
                Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
                Console.WriteLine("Press enter to go to the main menu.");
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }

            void Subtraction(string message)
            {
                Console.Clear();
                Console.WriteLine($"{message}");

                int numCorrect = 0;
                int numIncorrect = 0;
                int rounds = 9;

                for (int i = 0; i < 10; i++)
                {
                    var random = new Random();
                    int firstNumber = random.Next(1, 9);
                    int secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} - {secondNumber}?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect++;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try Again!");
                        numIncorrect++;
                    }

                    Console.WriteLine($"Keep Going! {rounds} rounds left!");
                    Console.WriteLine("Press enter to continue: ");
                    Console.ReadLine();

                    rounds--;

                    Console.Clear();
                }

                UpdateGameHistory("Subtraction", score);
                Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
                Console.WriteLine("Press enter to go to the main menu.");
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }

            void Multiplication(string message)
            {
                Console.Clear();
                Console.WriteLine($"{message}");

                int rounds = 9;
                int numCorrect = 0;
                int numIncorrect = 0;

                for (int i = 0; i < 10; i++)
                {
                    var random = new Random();
                    int firstNumber = random.Next(1, 9);
                    int secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} * {secondNumber}?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber * secondNumber)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect++;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try Again!");
                        numIncorrect++;
                    }

                    Console.WriteLine($"Keep Going! {rounds} rounds left!");
                    Console.WriteLine("Press enter to continue: ");
                    Console.ReadLine();

                    rounds--;

                    Console.Clear();
                }

                UpdateGameHistory("Multiplication", score);
                Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
                Console.WriteLine("Press enter to go to the main menu.");
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }

            void Division(string message)
            {
                Console.Clear();
                Console.WriteLine($"{message}");

                int rounds = 9;
                int numCorrect = 0;
                int numIncorrect = 0;

                for (int i = 0; i < 10; i++)
                {
                    int[] numbers = GetNiceDivisionNumbers();
                    int firstNumber = numbers[0];
                    int secondNumber = numbers[1];

                    Console.WriteLine($"{firstNumber} / {secondNumber}?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber / secondNumber)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect += 1;
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try Again!");
                        numIncorrect += 1;
                    }

                    Console.WriteLine($"Keep Going! {rounds} rounds left!");
                    Console.WriteLine("Press enter to continue: ");

                    rounds--;

                    Console.ReadLine();

                    Console.Clear();
                }

                UpdateGameHistory("Subtraction", score);
                Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
                Console.WriteLine("Press enter to go to the main menu.");
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }

            // Get evenly divisible integers
            int[] GetNiceDivisionNumbers()
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

            void GetGameHistory()
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
                MainMenu();
            }

            void UpdateGameHistory(string gameType, int gamescore)
            {
                games.Add($"Game Type: {gameType}, score = {score}");
            }

            void QuitGame()
            {
                Console.WriteLine("Thanks for playing!");
                Thread.Sleep(2000);
                Environment.Exit(1);
            }
        }
    }
}
