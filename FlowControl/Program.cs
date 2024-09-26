using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player_int;
            Random random = new Random();
            bool keep_playing = true;
            string player_input;
            Console.WriteLine("Welcome to rock, paper, scissor!"); //Welcome message outside loop so it only displays once
            while (keep_playing) //Loop to keep game going
            {
                int npc_input = random.Next(1, 4); //Generates a random number between 1-3 every time it's run
                Console.WriteLine("Type 1 to play rock. Type 2 to play paper. Type 3 to play scissor. Type 'quit' to exit");
                player_input = PlayerInput(Console.ReadLine()); //Calls function to make letters lower case so only one iteration of "quit" is necessary
                if (player_input == "quit") //Checks if player wrote "quit" in any way
                {
                    keep_playing = false; //Ends game loop
                }
                else if (int.TryParse(player_input, out player_int)) //Checks player input for numbers
                {
                    switch (player_int) //Checks what number the player wrote, has 3 cases for each number, each with 3 underlying scenarios. Also has a default in case player didn't write a number between 1-3
                    {
                        case 1:
                            switch (npc_input) //Checks computers random number to see what it played
                            {
                                case 1:
                                    Console.WriteLine("Draw! you both played rock");
                                    break;
                                case 2:
                                    Console.WriteLine("Loss! you played rock, computer played paper");
                                    break;
                                case 3:
                                    Console.WriteLine("Win! you played rock, computer played scissor");
                                    break;
                            }
                            break;
                        case 2:
                            switch (npc_input)
                            {
                                case 1:
                                    Console.WriteLine("Win! you played paper, computer played rock");
                                    break;
                                case 2:
                                    Console.WriteLine("Draw! you both played paper");
                                    break;
                                case 3:
                                    Console.WriteLine("Loss! you played paper, computer played scissor");
                                    break;
                            }
                            break;
                        case 3:
                            switch (npc_input)
                            {
                                case 1:
                                    Console.WriteLine("Loss! you played scissor, computer played rock");
                                    break;
                                case 2:
                                    Console.WriteLine("Win! you played scissor, computer played paper");
                                    break;
                                case 3:
                                    Console.WriteLine("Draw! you both played scissor");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("You didn't input a valid number");
                            break;
                    }
                }
                else //Lets the player know they didn't input any usable info
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
        /// <summary>
        /// A function to make any enter characters lower case
        /// </summary>
        /// <param name="player_input"></param>
        /// <returns>String with only lower case letters</returns>
        static string PlayerInput(string player_input)
        {
            player_input = player_input.ToLower();
            return player_input;
        }
    }
}
