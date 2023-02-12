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
            var game = new GameLogic();

            // Get name and start games
            Console.WriteLine("Welcome to the math game!\n");
            string name = Menu.GetName();

            

            Console.WriteLine($"\nWelcome, {name}!\n");

            Menu.ShowMenu();

            // Methods

            

            
        }
    }
}
