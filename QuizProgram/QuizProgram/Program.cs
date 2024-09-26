using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordLibrary = new string[25]                                               //Creates a "library" using a string-array of 25 words, in this case all are 8 characters long and have a max of 2 duplicate characters (the latter is important for the way the solution is found)
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
            Random random = new Random();                                                       //Creates a random number generater *Praise aRaNGesus!*
            int randomNumber = random.Next(0, 24);                                              //Generates a random number between and including 0-24
            string secretword = wordLibrary[randomNumber].ToUpper();                            //Takes random number to call a string from the earlier made library and sets it as the string "secretword"
            string player_input = string.Empty;
            char guess = '\0';
            string guesses = string.Empty;
            char[] hiddenword = new char[8] { '_', '_', '_', '_', '_', '_', '_', '_' };         //Sets the characters in "hiddenword" (the one that must be equal to "secretword" to win) as "_" for user-readability
            byte lives = 5;                                                                     //Sets starting lives to 5
            int index1;
            int index2;
            bool win = false;                                                                   //Determines wether or not the player has won by (being a result of a process) comparing "hiddenword" and "secretword"
            Console.WriteLine("Hi! Welcome to a pure text based game of \"Hangman\"");
            Console.WriteLine("You start with 5 lives, you lose 1 for each wrong guess");
            Console.WriteLine("You guess by typing in a single letter and press enter");
            Console.WriteLine("If you guess the 8 letter word, you win!");
            while (lives > 0 && !win)                                                           //Ensures game keeps looping until player runs out of lives or wins
            {
                if (player_input.Length > 1)                                                     //Condition that tells the player he input too many characters - doesn't run on first pass since the string is empty
                {
                    Console.WriteLine("Invalid input! Too many characters");
                }
                if (guesses != string.Empty)                                                    //Feeds user info on which characters have been picked - doesn't run first time since it's empty, but runs every following time
                {
                    Console.WriteLine("You have guessed on following letters:");
                    Console.WriteLine(guesses);
                }
                Console.WriteLine($"You currently have {lives} lives\n\n\n");                   //Informs player of the amount of lives remaining and spaces the word to be guessed 3 lines further down
                Console.WriteLine(hiddenword);                                                  //Displays unknown "_" or known characters of the secret word
                player_input = Console.ReadLine().ToUpper();                                    //Yields player input in upper casings for consistency
                if ((player_input.Length == 1) && byte.TryParse(player_input, out byte check))  //Checks if player input a single number and informs player that action isn't allowed
                {
                    Console.Clear();                                                            //Clears the window to avoid clutter
                    Console.WriteLine("Numbers are not accepted");
                }
                else if (player_input.Length == 1)                                              //Confirms that the user only put in a single character to avoid "Convert.ToChar" to return an exception
                {
                    guess = Convert.ToChar(player_input);                                       //Converts user input to a singular uppercase character
                    if (secretword.Contains(guess))                                             //Checks if the secret word contains the guessed upon character
                    {
                        index1 = secretword.IndexOf(guess);                                     //Finds the position of the first instance of the guessed character in the string
                        index2 = secretword.LastIndexOf(guess);                                 //Finds the position of the last (if any) of the guessed character in the string
                        hiddenword[index1] = guess;                                             //Replaces the "_" in the hiddenword string array with the guessed letter, other right below it replaces an additional one if applicable
                        hiddenword[index2] = guess;
                        bool mybool = true;
                        for (int i = 0; i < hiddenword.Length; i++)
                        {
                            if (hiddenword[i] != secretword[i])                                 //Checks if any characters in the "hiddenword" character-array differs from the characters in the "secretword" string
                            {
                                mybool = false;                                                 //If any difference is detected, sets "mybool" as false
                            }
                        }
                        if (mybool)                                                             //If "mybool" is set to false because of the above check, victory is denied
                        {
                            win = true;                                                         //Ends loop even if the player still has lives remaining
                        }
                        Console.Clear();                                                        //Clears the window to avoid clutter
                    }
                    else
                    {                                                                           //Removes a life if a guess was wrong, and informs player
                        Console.Clear();                                                        //Clears the window to avoid clutter
                        Console.WriteLine("Wrong guess, you lost a life :(");
                        lives--;
                    }
                }
                if (guesses.Contains(guess))                                                    //Checks if player already guessed on the entered character, and informs the player
                {
                    Console.Clear();                                                            //Clears the window to avoid clutter
                    Console.WriteLine("You already tried this character, guess again");
                    guesses = guesses.Replace(guess.ToString(), "");                            //Removes the current instance of the character in the string to avoid duplicates for better user-readability
                }
                guesses += guess;                                                               //Adds the guessed character to those already guessed
                Console.WriteLine("=========================");                                 //Used as a new "header" for the next loop
            }
            if (win)                                                                            //If the loop was ended with lives remaining and guessed the word, this displays the victory message
            {
                Console.WriteLine($"Congratulations the word was {secretword}, you've won the game!!! Thanks for playing!");
            }
            else
            {                                                                                   //This displays the loss message if player runs out of lives
                Console.WriteLine("Game Over");
            }
            Console.ReadKey();                                                                  //Prevents console window from closing until a key is pressed
        }
    }
}
