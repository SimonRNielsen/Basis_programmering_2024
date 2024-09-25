using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse1
{
    enum orientation : byte
    {
        nord = 1,
        øst = 2,
        syd = 3,
        vest = 4
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInput;
            int overflow_int = 321;
            byte overflow_byte;
            int float_to_int;
            float myFloat = 2322.223f;
            orientation myDirection = orientation.nord;
            Console.WriteLine("Skriv et tal");
            myInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"myInput er nu {myInput}, test nu med et andet tal");
            if (int.TryParse(Console.ReadLine(), out myInput))
            {
                Console.WriteLine("myInput er nu: {0}", myInput);
            }
            else
            {
                Console.WriteLine("Lortet virkede ikke");
            }
            unchecked
            {
                overflow_byte = (byte)overflow_int;
            }
            Console.WriteLine($"Resultatet af overflowet er {overflow_byte}");
            float_to_int = (int)myFloat;
            Console.WriteLine($"myFloat er nu converteret fra en float på {myFloat} til en integer på {float_to_int}");
            Console.WriteLine($"Du vender pt mod {myDirection}");
            Console.WriteLine("Skriv hvilken retning du vil bevæge dig i, nord=1, øst=2, syd=3, vest=4");
            myDirection = (orientation)Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Du vender nu mod {myDirection}");
            Console.ReadKey();
        }
    }
}
