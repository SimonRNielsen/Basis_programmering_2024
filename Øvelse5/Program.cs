using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Adding these two numbers together gives {x + y}");
            Console.WriteLine($"Subtracting these two numbers gives {y - x} if you subtract the second number with the first");
            Console.WriteLine($"Subtracting these two numbers gives {x - y} if you subtract the first number with the second");
            Console.WriteLine($"Multiplying these numbers yields {x * y}");
            Console.WriteLine($"Dividing these two yields {x / y} if you divide the first number with the second");
            Console.WriteLine($"Dividing these two yields {y / x} if you divide the second number with the first");
            Console.WriteLine($"First number becomes {x += y} if assigned the sum of first and second number added");
            Console.WriteLine($"First number becomes {y += x} if assigned the sum of second and first number added");
            Console.WriteLine($"First number becomes {x -= y} if the first number is substacted with the second");
            Console.WriteLine($"First number becomes {y -= x} if the second number is substacted with the first");
            Console.WriteLine($"First number becomes {x *= y} if the first number is multiplied by the second");
            Console.WriteLine($"First number becomes {y *= x} if the second number is multiplied by the first");
            Console.ReadKey();
        }
    }
}
