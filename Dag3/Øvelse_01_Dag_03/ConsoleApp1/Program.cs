using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    enum Gender {Male, Female, Other }

    internal class Program
    {
        

        static void Main(string[] args)
        {
            Gender gender = Gender.Female;

            //Console.WriteLine(gender);
            Console.WriteLine("Chose your gender!");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i +":" + Enum.Parse(typeof(Gender),i.ToString()));
            }

            int selection = int.Parse(Console.ReadLine());

            gender = (Gender)selection;
            Console.WriteLine();
            Console.WriteLine(gender);


            switch (gender)
            {
                case Gender.Male:
                    break;
                case Gender.Female:
                    break;
                case Gender.Other:
                    break;
                default:
                    break;
            }

            //int i = 0;

            //if (int.TryParse(Console.ReadLine(), out i))
            //{
            //    Console.WriteLine("Success!");
            //}
            //else
            //{
            //    Console.WriteLine("Parse failed!");
            //}

            //int i = 300;
            //byte b = 0;

            //i = b;

            //checked
            //{
            //    b = (byte)i;
            //}


            //float f = 2333.223f;
            //int i = 0;
            //i = (int)f;
            //Console.WriteLine(i);
        }
    }
}
