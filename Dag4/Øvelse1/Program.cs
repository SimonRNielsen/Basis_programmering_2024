using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[7] { 12, 33, 532, 145, 1, 4565, 1 };
            string input;
            byte changeNumber;
            int inputNumber;
            bool loop = true;
            /*
            Console.WriteLine(myArray[4]);
            myArray[2] = 36562;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            */
            foreach (int number in myArray)
            {
                Console.WriteLine(number.ToString());
            }
            while (loop)
            {
                Console.WriteLine("Which line do you want to change the number of? if you want to end program type 'exit', if you want to add an extra type 'new'");
                input = (Console.ReadLine());
                if (input.ToLower() == "new")
                {
                    Array.Resize(ref myArray, myArray.Length+1);
                    Console.WriteLine("What number would you like to add?");
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                    myArray[myArray.Length-1] = inputNumber;
                    foreach (int number in myArray)
                    {
                        Console.WriteLine(number.ToString());
                    }
                }
                else if (input.ToLower() == "exit")
                {
                    loop = false;
                }
                else
                {
                    byte.TryParse(input, out changeNumber);
                    Console.WriteLine("What would you like to change it to?");
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                    myArray[(changeNumber - 1)] = inputNumber;
                    Console.WriteLine("The array now contains following numbers:");
                    foreach (int number in myArray)
                    {
                        Console.WriteLine(number.ToString());
                    }
                }
            }
            /*
            string[] myStrArray = new string[10] { "Phillip", "Thomas", "Stephanie", "David", "Irene", "Rikke", "Simon", "Christian", "Silas", "Lasse" };
            Console.WriteLine(myStrArray[4]);
            myStrArray[2] = "Mario";
            for (int i = 0; i < myStrArray.Length; i++)
            {
                Console.WriteLine(myStrArray[i]);
            }
            foreach (string name in myStrArray)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
            */
        }
    }
}
