using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get name and start games
            Console.WriteLine("Welcome to the math game!\n");
            string name = GetName();

            Console.WriteLine($"\nWelcome, {name}!");

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
                Q - Quit

                Current score = {score}");

                Console.WriteLine("----------------------------------");

                var selection = Console.ReadLine();

                if (selection.ToLower().Trim() == "a")
                {
                    Addition("Addition game selected!");
                }
                else if (selection.ToLower().Trim() == "s")
                {
                    Subtraction("Subraction game selected!");
                }
                else if (selection.ToLower().Trim() == "m")
                {
                    Multiplication("Multiplication game selected!");
                }
                else if (selection.ToLower().Trim() == "d")
                {
                    Division("Division game selected!");
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
                Console.WriteLine($"\n{message}");
                int count = 0;
                int numCorrect = 0;
                int numIncorrect = 0;
                Boolean keepPlaying = true;

                while (keepPlaying)
                {
                    count++;
                    
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

                    Console.Write("Play again? (Y/N): ");
                    var keepGoing = Console.ReadLine();

                    if (keepGoing.ToLower().Trim() == "y")
                    {
                        Console.Clear();                        
                    }
                    else
                    {
                        Console.WriteLine($"Games played: {count}");
                        Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
                        keepPlaying = false;
                        MainMenu();
                    }                    
                }                
            }

            void Subtraction(string message)
            {
                Console.WriteLine($"\n{message}");
                int count = 0;
                int numCorrect = 0;
                int numIncorrect = 0;
                Boolean keepPlaying = true;

                while (keepPlaying)
                {
                    count++;
                    
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

                    Console.Write("Play again? (Y/N): ");
                    var keepGoing = Console.ReadLine();

                    if (keepGoing.ToLower().Trim() == "y")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"Games played: {count}");
                        Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
                        keepPlaying = false;
                        MainMenu();
                    }
                }
            }

            void Multiplication(string message)
            {
                Console.WriteLine($"\n{message}");
                int count = 0;
                int numCorrect = 0;
                int numIncorrect = 0;
                Boolean keepPlaying = true;

                while (keepPlaying)
                {
                    count++;

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

                    Console.Write("Play again? (Y/N): ");
                    var keepGoing = Console.ReadLine();

                    if (keepGoing.ToLower().Trim() == "y")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"Games played: {count}");
                        Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
                        keepPlaying = false;
                        MainMenu();
                    }
                }
            }

            void Division(string message)
            {
                Console.WriteLine($"\n{message}");
                int count = 0;
                int numCorrect = 0;
                int numIncorrect = 0;
                Boolean keepPlaying = true;

                while (keepPlaying)
                {
                    count += 1;

                    var random = new Random();
                    int[] numbers = GetNiceDivisionNumbers();
                    int firstNumber = numbers[0];
                    int secondNumber = numbers[1];

                    Console.WriteLine($"{firstNumber} / {secondNumber}?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber / secondNumber)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect += 1;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try Again!");
                        numIncorrect += 1;
                    }

                    Console.Write("Play again? (Y/N): ");
                    var keepGoing = Console.ReadLine();

                    if (keepGoing.ToLower().Trim() == "y")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"Games played: {count}");
                        Console.WriteLine($"You got {numCorrect} correct and {numIncorrect} wrong!\n");
                        keepPlaying = false;
                        MainMenu();
                    }
                }
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

            void QuitGame()
            {
                Console.WriteLine("\nThanks for playing!");
                Thread.Sleep(2000);
                Environment.Exit(1);
            }
        }
    }
}
