using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    /// <summary>
    /// Enum for races
    /// </summary>
    enum AllianceRace : int
    {
        Dwarf = 1, Human = 2, Nightelf = 3, Gnome = 4
    }
    enum HordeRace : int
    {
        Orc = 1, Troll = 2, Tauren = 3, Undead = 4
    }
    enum PlayerClass : int
    {
        Warrior = 1, Mage = 2, Warlock = 3, Priest = 4, Paladin = 5, Hunter = 6
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string faction = string.Empty;
            string allianceRace = string.Empty;
            string hordeRace = string.Empty;
            string player_class = string.Empty;
            string playerName;
            Console.WriteLine("Welcome, please create a new character!");
            Console.WriteLine("Start by choosing which faction you want to fight for");
            Console.WriteLine("Choices are 'Alliance' or 'Horde'");
            faction = Console.ReadLine();
            switch (faction.ToLower())
            {
                case "alliance":
                    faction = "Alliance";
                    Console.WriteLine("Now select a race, type the number for the one you want to play as");
                    Console.WriteLine("Your choices are: \n1 = Dwarf \n2 = Human \n3 = Night Elf \n4 = Gnome");
                    allianceRace = Console.ReadLine();
                    break;
                case "horde":
                    faction = "Horde";
                    Console.WriteLine("Now select a race, type the number for the one you want to play as");
                    Console.WriteLine("Your choices are: 'Orc', 'Troll', 'Tauren', 'Undead'");
                    hordeRace = Console.ReadLine();
                    break;
                default:
                    faction = "Horde";
                    Console.WriteLine("Now select a race, type the number for the one you want to play as");
                    Console.WriteLine("Your choices are: 'Orc' (3), 'Troll', 'Tauren', 'Undead'");
                    hordeRace = Console.ReadLine();
                    break;
            }
            Console.WriteLine("Now select a class");
            switch (race.ToLower())
            {
                case "human":
                    race = "Human";
                    Console.WriteLine("Your choices for this race is: 'Warrior', 'Mage', 'Warlock'");
                    player_class = Console.ReadLine();
                    break;
                case "orc":
                    race = "Orc";
                    Console.WriteLine("Your choices for this race is: 'Warrior', 'Mage', 'Warlock'");
                    player_class = Console.ReadLine();
                    break;
                case "dwarf":
                    race = "Dwarf";
                    Console.WriteLine("Your choices for this race is 'Priest', 'Paladin', 'Hunter'");
                    player_class = Console.ReadLine();
                    break;
                case "tauren":
                    race = "Tauren";
                    Console.WriteLine("Your choices for this race is 'Priest', 'Paladin', 'Hunter'");
                    player_class = Console.ReadLine();
                    break;
                case "night elf":
                    race = "Night elf";
                    Console.WriteLine("Your choices for this race is 'Hunter', 'Mage', 'Priest'");
                    player_class = Console.ReadLine();
                    break;
                case "undead":
                    race = "Undead";
                    Console.WriteLine("Your choices for this race is 'Hunter', 'Mage', 'Priest'");
                    player_class = Console.ReadLine();
                    break;
                case "troll":
                    race = "Troll";
                    Console.WriteLine("Your choices for this race is 'Warrior', 'Hunter', 'Mage'");
                    player_class = Console.ReadLine();
                    break;
                case "gnome":
                    race = "Gnome";
                    Console.WriteLine("Your choices for this race is 'Warrior', 'Hunter', 'Mage'");
                    player_class = Console.ReadLine();
                    break;
            }
            switch (player_class.ToLower())
            {
                case "warrior":
                    player_class = "Warrior";
                    break;
                case "mage":
                    player_class = "Mage";
                    break;
                case "warlock":
                    player_class = "Warlock";
                    break;
                case "priest":
                    player_class = "Priest";
                    break;
                case "paladin":
                    player_class = "Paladin";
                    break;
                case "hunter":
                    player_class = "Hunter";
                    break;
            }
            Console.WriteLine("Choose your charactername!");
            playerName = Console.ReadLine();
            bool allegianceToHorde = faction == "Horde";
            Console.WriteLine($"Welcome to the game {playerName}, you are a {race} {player_class} fighting for the {faction}");
            if (allegianceToHorde)
            {
                Console.WriteLine("FOR THE HORDE!");
            }
            else
            {
                Console.WriteLine("For the Alliance!");
            }
            Console.ReadKey();
        }
    }
}
