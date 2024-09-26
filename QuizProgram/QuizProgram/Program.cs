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
            #region WordLibrary_array
            string[] wordLibrary = new string[]                                                     //Creates a "library" using a string-array words, in this case all are 8 characters long and have a max of 2 duplicate characters (the latter is important for the way the solution is found)
            {
                "garden",
                "bicycle",
                "twinkle",
                "journey",
                "harmful",
                "circuit",
                "bamboo",
                "sandwic",
                "giraffe",
                "wristband",
                "hockey",
                "relaxed",
                "charmed",
                "magnet",
                "painted",
                "hurdles",
                "marathon",
                "puzzle",
                "galaxy",
                "horizon",
                "kitten",
                "stumble",
                "bubble",
                "jacket",
                "robotic",
                "decent",
                "trolley",
                "plumber",
                "sapphire",
                "biscuit",
                "vacuum",
                "cuddle",
                "twisted",
                "unicorn",
                "laptop",
                "courage",
                "drizzle",
                "kerfuffle",
                "mimetic",
                "hurdler",
                "twitchy",
                "caramel",
                "folder",
                "bracket",
                "tropical",
                "backflip",
                "dolphin",
                "fungoid",
                "fragile",
                "jigsaw",
                "sponge",
                "fiddler",
                "tandem",
                "whistle",
                "coaster",
                "champion",
                "habitat",
                "leopard",
                "neither",
                "paddler",
                "ramble",
                "spiral",
                "carpet",
                "tablet",
                "unveil",
                "windmill",
                "zodiac",
                "zooming",
                "furnace",
                "pioneer",
                "trouble",
                "dazzled",
                "marquee",
                "blossom",
                "melody",
                "trendy",
                "quicks",
                "wildcard",
                "patriot",
                "research",
                "jumbled",
                "lizard",
                "whisker",
                "thermos",
                "opulent",
                "magical",
                "factor",
                "circuit",
                "embrace",
                "diamond",
                "fractal",
                "hustler",
                "banquet",
                "glisten",
                "splendid",
                "glimmer",
                "sparkle",
                "voyager",
                "carving",
                "dazzler",
                "tobacco",
                "attuned",
                "finicky",
                "paddle",
                "sketchy",
                "subtle",
                "lumber",
                "capture",
                "twinkle",
                "cinder",
                "abandon",
                "champion",
                "impulse",
                "nocturnal",
                "overlap",
                "vibrant",
                "notebook",
                "garden",
                "acquaint",
                "acquire",
                "doughnut",
                "fracture",
                "glacial",
                "calculate",
                "malware",
                "landmark",
                "journal",
                "mystery",
                "sandal",
                "faucet",
                "snuggle",
                "brighten",
                "climber",
                "flounder",
                "tincture",
                "harmonic",
                "exercise",
                "acquiesce",
                "studded",
                "peacock",
                "rumbling",
                "toolkit",
                "playful",
                "tornado",
                "windy",
                "gadget",
                "hydrant",
                "bandage",
                "bohemian",
                "jackpot"
            };
            #endregion
            Random random = new Random();                                                           //Creates a random number generater *Praise aRaNGesus!*
            int randomNumber = random.Next(0, (wordLibrary.Length - 1));                            //Generates a random number between the max size of the wordLibrary-array and including 0
            string secretword = wordLibrary[randomNumber].ToUpper();                                //Takes random number to call a string from the earlier made library and sets it as the string "secretword"
            string player_input = string.Empty;
            char guess = '\0';
            string guesses = string.Empty;
            char[] hiddenword = new char[10] { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' };  //Sets the characters in "hiddenword" (the one that must be equal to "secretword" to win) as "_" for user-readability
            Array.Resize(ref hiddenword, secretword.Length);                                        //Makes certain only the correct amount of fields are displayed
            byte lives = 5;                                                                         //Sets starting lives to 5
            bool win = false;                                                                       //Determines wether or not the player has won by (being a result of a process) comparing "hiddenword" and "secretword"
            Console.WriteLine("Hi! Welcome to a pure text based game of \"Hangman\"");
            Console.WriteLine("You start with 5 lives, you lose 1 for each wrong guess");
            Console.WriteLine("You guess by typing in a single letter and press enter");
            Console.WriteLine($"If you guess the {secretword.Length} letter word, you win!");
            while (lives > 0 && !win)                                                               //Ensures game keeps looping until player runs out of lives or wins
            {
                if (player_input.Length > 1)                                                        //Condition that tells the player he input too many characters - doesn't run on first pass since the string is empty
                {
                    Console.WriteLine("Invalid input! Too many characters");
                }
                if (guesses != string.Empty)                                                        //Feeds user info on which characters have been picked - doesn't run first time since it's empty, but runs every following time
                {
                    Console.WriteLine("You have guessed on following letters:");
                    Console.WriteLine(guesses);
                }
                Console.WriteLine($"You currently have {lives} lives\n\n\n");                       //Informs player of the amount of lives remaining and spaces the word to be guessed 3 lines further down
                Console.WriteLine(hiddenword);                                                      //Displays unknown "_" or known characters of the secret word
                player_input = Console.ReadLine().ToUpper();                                        //Yields player input in upper casings for consistency
                if ((player_input.Length == 1) && byte.TryParse(player_input, out byte check))      //Checks if player input a single number and informs player that action isn't allowed
                {
                    Console.Clear();                                                                //Clears the window to avoid clutter
                    Console.WriteLine("Numbers are not accepted");
                    guess = '\0';
                }
                else if (player_input.Length == 1)                                                  //Confirms that the user only put in a single character to avoid "Convert.ToChar" to return an exception
                {
                    guess = Convert.ToChar(player_input);                                           //Converts user input to a singular uppercase character
                    if (secretword.Contains(guess))                                                 //Checks if the secret word contains the guessed upon character
                    {
                        int index1 = secretword.IndexOf(guess);                                     //Finds the position of the first instance of the guessed character in the string
                        int index2 = secretword.LastIndexOf(guess);                                 //Finds the position of the last (if any) of the guessed character in the string
                        bool mybool = true;
                        hiddenword[index1] = guess;                                                 //Replaces the "_" in the hiddenword string array with the guessed letter, other right below it replaces an additional one if applicable
                        hiddenword[index2] = guess;
                        for (int i = 0; i < hiddenword.Length; i++)
                        {
                            if (hiddenword[i] != secretword[i])                                     //Checks if any characters in the "hiddenword" character-array differs from the characters in the "secretword" string
                            {
                                mybool = false;                                                     //If any difference is detected, sets "mybool" as false
                            }
                        }
                        if (mybool)                                                                 //If "mybool" is set to false because of the above check, victory is denied
                        {
                            win = true;                                                             //Ends loop even if the player still has lives remaining
                        }
                        Console.Clear();                                                            //Clears the window to avoid clutter
                    }
                    else
                    {                                                                               //Removes a life if a guess was wrong, and informs player
                        Console.Clear();                                                            //Clears the window to avoid clutter
                        Console.WriteLine("Wrong guess, you lost a life :(");
                        lives--;
                    }
                }
                if (guesses.Contains(guess))                                                        //Checks if player already guessed on the entered character, and informs the player
                {
                    Console.Clear();                                                                //Clears the window to avoid clutter
                    Console.WriteLine("You already tried this character or invalid input, guess again");
                    guesses = guesses.Replace(guess.ToString(), "");                                //Removes the current instance of the character in the string to avoid duplicates for better user-readability
                }
                guesses += guess;                                                                   //Adds the guessed character to those already guessed
                Console.WriteLine("=========================\n\n");                                 //Used as a new "header" for the next loop
                if (lives == 5)
                {
                    Console.WriteLine("   ------");
                    Console.WriteLine("   |    |");
                    Console.WriteLine("   |");
                    Console.WriteLine("   |");
                    Console.WriteLine("   |");
                    Console.WriteLine("   |");
                    Console.WriteLine("--------\n\n");
                }
                else if (lives == 4)
                {
                    Console.WriteLine("   ------");
                    Console.WriteLine("   |    |");
                    Console.WriteLine("   |    O");
                    Console.WriteLine("   |");
                    Console.WriteLine("   |");
                    Console.WriteLine("   |");
                    Console.WriteLine("--------\n\n");
                }
                else if (lives == 3)
                {
                    Console.WriteLine("   ------");
                    Console.WriteLine("   |    |");
                    Console.WriteLine("   |    O");
                    Console.WriteLine("   |    |");
                    Console.WriteLine("   |");
                    Console.WriteLine("   |");
                    Console.WriteLine("--------\n\n");
                }
                else if (lives == 2)
                {
                    Console.WriteLine("   ------");
                    Console.WriteLine("   |    |");
                    Console.WriteLine("   |   \\O/");
                    Console.WriteLine("   |    |");
                    Console.WriteLine("   |   / \\");
                    Console.WriteLine("   |");
                    Console.WriteLine("--------\n\n");
                }
                else if (lives == 1)
                {
                    Console.WriteLine("   ------");
                    Console.WriteLine("   |    |");
                    Console.WriteLine("   |  __O__");
                    Console.WriteLine("   |    |");
                    Console.WriteLine("   |   / \\");
                    Console.WriteLine("   |");
                    Console.WriteLine("--------\n\n");
                }
            }
            if (win)                                                                                //If the loop was ended with lives remaining and guessed the word, this displays the victory message
            {
                Console.WriteLine($"Congratulations the word was {secretword}, you've won the game!!! Thanks for playing!");
            }
            else
            {                                                                                       //This displays the loss message if player runs out of lives
                Console.WriteLine("Game Over\n\n");
                Console.WriteLine("   ------");
                Console.WriteLine("   |    |");
                Console.WriteLine("   |    O");
                Console.WriteLine("   |   /|\\");
                Console.WriteLine("   |   / \\");
                Console.WriteLine("   |");
                Console.WriteLine("--------");
            }
            //Console.ReadKey();                                                                      //Prevents console window from closing until a key is pressed
        }
    }
}
