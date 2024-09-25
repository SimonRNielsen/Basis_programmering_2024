using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Variabler_og_Datatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerGuess;
            string playerName;
            Console.WriteLine("Welcome user, would you like to play a game?");
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            Console.WriteLine($"Hi {playerName}!");
            Console.WriteLine("Guess a whole number between 1-100, type in your guess below");
            playerGuess = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            if (playerGuess > 100 || playerGuess < 1)
            {
                Console.WriteLine("That number was not inside the 1-100 range");
            }
            else if (playerGuess < randomNumber)
            {
                Console.WriteLine($"Wrong guess, you were off by {randomNumber - playerGuess}, the number was {randomNumber}");
            }
            else if (playerGuess > randomNumber)
            {
                Console.WriteLine($"Wrong guess, you were off by {playerGuess - randomNumber}, the number was {randomNumber}");
            }
            else
            {
                Console.WriteLine($"You guessed correct! The number was indeed {playerGuess}!");
            }
            Console.WriteLine("Thank you for playing, press any key to close the program");
            Console.ReadKey();
        }
    }
}
