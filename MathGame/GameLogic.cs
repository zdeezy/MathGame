using System;
using System.Threading;

namespace MathGame
{
    internal class GameLogic
    {
        private int score = 0;

        internal void Addition(string message)
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

                Console.WriteLine($"Keep Going! {rounds} tries left!");
                Console.WriteLine("Press enter to continue: ");
                Console.ReadLine();

                rounds--;

                Console.Clear();
            }

            Helpers.UpdateGameHistory("Addition", score);
            Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
            Console.WriteLine("Press enter to go to the main menu.");
            Console.ReadLine();
            Console.Clear();
            Menu.ShowMenu();
        }

        internal void Subtraction(string message)
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

                Console.WriteLine($"Keep Going! {rounds} tries left!");
                Console.WriteLine("Press enter to continue: ");
                Console.ReadLine();

                rounds--;

                Console.Clear();
            }

            Helpers.UpdateGameHistory("Subtraction", score);
            Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
            Console.WriteLine("Press enter to go to the main menu.");
            Console.ReadLine();
            Console.Clear();
            Menu.ShowMenu();
        }

        internal void Multiplication(string message)
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

                Console.WriteLine($"Keep Going! {rounds} tries left!");
                Console.WriteLine("Press enter to continue: ");
                Console.ReadLine();

                rounds--;

                Console.Clear();
            }

            Helpers.UpdateGameHistory("Multiplication", score);
            Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
            Console.WriteLine("Press enter to go to the main menu.");
            Console.ReadLine();
            Console.Clear();
            Menu.ShowMenu();
        }

        internal void Division(string message)
        {
            Console.Clear();
            Console.WriteLine($"{message}");

            int rounds = 9;
            int numCorrect = 0;
            int numIncorrect = 0;

            for (int i = 0; i < 10; i++)
            {
                int[] numbers = Helpers.GetNiceDivisionNumbers();
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

                Console.WriteLine($"Keep Going! {rounds} tries left!");
                Console.WriteLine("Press enter to continue: ");

                rounds--;

                Console.ReadLine();

                Console.Clear();
            }

            Helpers.UpdateGameHistory("Subtraction", score);
            Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
            Console.WriteLine("Press enter to go to the main menu.");
            Console.ReadLine();
            Console.Clear();
            Menu.ShowMenu();
        }

        internal void QuitGame()
        {
            Console.WriteLine("Thanks for playing!");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
