using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Language_Select:
            string userName = string.Empty;
            string password = string.Empty;
            int minimum_age = 18;
            string input_userName;
            string input_password;
            int input_age;
            string selected_language;
            string new_user;
            string new_user_userName;
            string new_user_password;
            Console.WriteLine("Please select language (english)/Vælg venligst sprog (dansk)");
            selected_language = Console.ReadLine();
            if (selected_language.ToLower() == "english")
            {
                Console.WriteLine("How old are you?");
                input_age = Convert.ToByte(Console.ReadLine());
                if (input_age >= minimum_age)
                {
                    Console.WriteLine($"Please login!");
                    Console.WriteLine($"Username:");
                    input_userName = Console.ReadLine();
                    Console.WriteLine($"Password:");
                    input_password = Console.ReadLine();
                    switch (input_userName)
                    {
                        case "Simon":
                            userName = "Simon";
                            password = "424242";
                            break;
                        case "Stefan":
                            userName = "Stefan";
                            password = "123456";
                            break;
                        case "Claus":
                            userName = "Claus";
                            password = "234567";
                            break;
                        case "Inga":
                            userName = "Inga";
                            password = "345678";
                            break;
                        case "Finn":
                            userName = "Finn";
                            password = "456789";
                            break;
                        case "Hans":
                            userName = "Hans";
                            password = "567890";
                            break;
                        case "Gerda":
                            userName = "Gerda";
                            password = "678901";
                            break;
                        case "Betina":
                            userName = "Betina";
                            password = "789012";
                            break;
                        case "Bente":
                            userName = "Bente";
                            password = "890123";
                            break;
                        case "Britta":
                            userName = "Britta";
                            password = "901234";
                            break;
                    }
                    if ((userName == input_userName) && (password == input_password))
                    {
                        Console.WriteLine($"Welcome {userName}!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Unknown username and/or password, would you like to try again or create a new user? (yes/no)");
                        new_user = Console.ReadLine();
                        if (new_user.ToLower() == "yes")
                        {
                            Console.WriteLine("Username");
                            new_user_userName = Console.ReadLine();
                            Console.WriteLine("Password");
                            new_user_password = Console.ReadLine();
                            Console.WriteLine("Success!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Goodbye, have a nice day!");
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You are not old enough to use this application!");
                    Console.ReadKey();
                }
            }
            else if (selected_language.ToLower() == "dansk")
            {
                Console.WriteLine("Hvor gammel er du?");
                input_age = Convert.ToByte(Console.ReadLine());
                if (input_age >= minimum_age)
                {
                    Console.WriteLine($"Venligst login!");
                    Console.WriteLine($"Brugernavn:");
                    input_userName = Console.ReadLine();
                    Console.WriteLine($"Kodeord:");
                    input_password = Console.ReadLine();
                    switch (input_userName)
                    {
                        case "Simon":
                            userName = "Simon";
                            password = "424242";
                            break;
                        case "Stefan":
                            userName = "Stefan";
                            password = "123456";
                            break;
                        case "Claus":
                            userName = "Claus";
                            password = "234567";
                            break;
                        case "Inga":
                            userName = "Inga";
                            password = "345678";
                            break;
                        case "Finn":
                            userName = "Finn";
                            password = "456789";
                            break;
                        case "Hans":
                            userName = "Hans";
                            password = "567890";
                            break;
                        case "Gerda":
                            userName = "Gerda";
                            password = "678901";
                            break;
                        case "Betina":
                            userName = "Betina";
                            password = "789012";
                            break;
                        case "Bente":
                            userName = "Bente";
                            password = "890123";
                            break;
                        case "Britta":
                            userName = "Britta";
                            password = "901234";
                            break;
                    }
                    if ((userName == input_userName) && (password == input_password))
                    {
                        Console.WriteLine($"Velkommen {userName}!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Ukendt brugernavn og/eller kodeord, vil du gerne oprette en ny bruger (ja/nej)");
                        new_user = Console.ReadLine();
                        if (new_user.ToLower() == "ja")
                        {
                            Console.WriteLine("Brugernavn");
                            new_user_userName = Console.ReadLine();
                            Console.WriteLine("Kodeord");
                            new_user_password = Console.ReadLine();
                            Console.WriteLine("Success!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Farvel, hav en god dag!");
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Du er ikke gammel nok til at bruge denne program!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Wrong input, please type again/Forkert indtastning, prøv venligst igen");
                goto Language_Select;
            }
        }
    }
}
