﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4_MailingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your streetname?");
            string road_name = Console.ReadLine();
            Console.WriteLine("Which housenumber?");
            int house_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which houseletter (if any)?");
            string house_letter = Console.ReadLine();
            Console.WriteLine("What zipcode?");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which city?");
            string city = Console.ReadLine();
            Console.WriteLine("Which Country?");
            string country = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("What is your phonenumber?");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Finally, what is your email address?");
            enter_email: 
            string email = Console.ReadLine();
            if (email.Contains("@") && email.Contains("."))
            {
                Console.WriteLine("Valid email format! Thank you!");
            }
            else
            {
                Console.WriteLine("Invalid email format, please try again!");
                goto enter_email;
            }
            // Console.WriteLine("Invalid email, please try again!");
            Console.WriteLine("You input following information:");
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Address = {road_name} {house_number}{house_letter}");
            Console.WriteLine($"Zipcode, city and country = {zipcode} {city}, {country}");
            Console.WriteLine($"Phonenumber = {phone}");
            Console.WriteLine($"Email-address = {email}");
            Console.ReadLine();
        }
    }
}
