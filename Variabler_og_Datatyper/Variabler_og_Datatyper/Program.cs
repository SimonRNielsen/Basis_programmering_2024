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
            Restart:
            Console.WriteLine("Guess a number between 1-100, type in your guess below");
            playerGuess = Convert.ToByte(Console.ReadLine());
            Random random = new Random();
            int randomNumber = random.Next(1, 101);            
            switch (playerGuess)
            {
                case randomNumber == playerGuess:

                    break;
                case randomNumber < playerGuess:

                    break;
                case randomNumber > playerGuess:

                    break;
                case playerGuess > 100:

                    break;
            }
            goto Restart;
        }
    }
}
