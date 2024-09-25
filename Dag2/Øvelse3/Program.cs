using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountToTens();
        }
        static void CountToTens()
        {
            int a = 0;
            do
            {
                Console.WriteLine($"{a}");
                a++;
            } while (a < 10);
            Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.WriteLine("X:{0}, Y{1}", x, y);
                }
            }
            Console.ReadLine();
        }
    }
}
