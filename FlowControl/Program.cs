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
            int player_input = 0;
            Random random = new Random();
            bool keep_playing = true;
            string quit;
            Console.WriteLine("Welcome to rock, paper, scissor!");
            while (keep_playing)
            {
                int npc_input = random.Next(1, 4);
                Console.WriteLine("Type 1 to play rock. Type 2 to play paper. Type 3 to play scissor. Type 'quit' to exit");
                if (int.TryParse(Console.ReadLine(), out player_input))
                {
                    switch (player_input)
                    {
                        case 1:
                            switch (npc_input)
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

                                    break;
                                case 2:

                                    break;
                                case 3:

                                    break;
                            }
                            break;
                        case 3:
                            switch (npc_input)
                            {
                                case 1:

                                    break;
                                case 2:

                                    break;
                                case 3:

                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    quit = Console.ReadLine();
                    if (quit == "quit")
                    {
                        keep_playing = false;
                    }
                }
            }
        }
    }
}
