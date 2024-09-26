using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram
{
    internal class Program
    {
        /*enum Hiddenword_hider : int
        {
            _ = 0,
            _ = 1,
            _ = 2,
            _ = 3,
            _ = 4,
            _ = 5,
            _ = 6,
            _ = 7
        }*/
        static void Main(string[] args)
        {
            string[] wordLibrary = new string[25]
            {
                "Campfire",
                "Platform",
                "Wildcard",
                "Snapshot",
                "Truncate",
                "Hospital",
                "Keyboard",
                "Blowfish",
                "Calendar",
                "Backpack",
                "Drumbeat",
                "Mandolin",
                "Sidewalk",
                "Forehand",
                "Grimaces",
                "Handpick",
                "Strategy",
                "Coauthor",
                "Gracious",
                "Merchant",
                "Operator",
                "Fidelity",
                "Spelling",
                "Baldness",
                "Wildlife"
            };
            Random random = new Random();
            int randomNumber = random.Next(0, 24);
            string secretword = wordLibrary[randomNumber].ToUpper();
            char guess;
            string guesses = string.Empty;
            char[] hiddenword = new char[8] {'_','_','_','_', '_', '_', '_', '_' };
            byte lives = 5;
            int index1 = 8;
            int index2 = 8;
            bool win = false;
            Console.WriteLine("Hi! Welcome to a pure text based game of \"Hangman\"");
            Console.WriteLine("You start with 5 lives, you lose 1 for each wrong guess");
            Console.WriteLine("You guess by typing in a single letter and press enter");
            Console.WriteLine("If you guess the 8 letter word, you win!");
            while (lives > 0 && !win)
            {
                Console.WriteLine(secretword);
                if (guesses != string.Empty)
                {
                    Console.WriteLine("You have guessed on following letters:");
                    Console.WriteLine(guesses);
                }
                Console.WriteLine($"You currently have {lives} lives\n\n\n");
                Console.WriteLine(hiddenword);
                guess = Convert.ToChar(Console.ReadLine().ToUpper());
                if (secretword.Contains(guess))
                {
                    index1 = secretword.IndexOf(guess);
                    index2 = secretword.LastIndexOf(guess);
                    hiddenword[index1] = guess;
                    hiddenword[index2] = guess;
                    bool mybool = true;
                    for (int i = 0; i < hiddenword.Length; i++)
                    {
                        if (hiddenword[i] == secretword[i])
                        {

                        }
                        else
                        {
                            mybool = false;
                        }
                    }
                    if (mybool)
                    {
                        win = true;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong guess, you lost a life :(");
                    lives--;
                }
                guesses += guess;
                Console.WriteLine("=========================");
            }
            if (win)
            {
                Console.WriteLine($"Congratulations the word was {secretword}, you've won the game!!! Thanks for playing!");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
            Console.ReadKey();
        }
    }
}
