using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name!");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}!");
            Console.WriteLine("Try typing a number!");
            int random_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You just wrote {random_number}!");
            Console.WriteLine("Press a key!");
            ConsoleKeyInfo t = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"You Pressed: {t.Key}");
            Console.ReadLine();
        }
    }
}
