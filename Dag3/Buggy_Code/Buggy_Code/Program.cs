using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buggy_Code
{
    internal class Program
    {
        static int First = 12;
        static string Message = "Hello World"; 
        static int numbre = 1;

        static void Main(string[] args)
        {
            CalculateSum(5); //Denne er korrekt

            Console.ReadKey();
        }

        /// <summary>
        /// Lægger to tal sammen og returnerer resultatet. Hvis man giver den 1,2 skal den returnere 3.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        static int AddNumbers(int first, int second)
        {
            return first + second; //Var sat til First der er en static integer
        }

        /// <summary>
        /// Skriver en besked ud til konsollen, skriver en beskedi konsollen, hvis man skriver Hello, skriver den Hello
        /// </summary>
        /// <param name="message">beskeden, som skrives ud</param>
        static void WriteMessage(string message)
        {
            Console.WriteLine(message); //Returnerer en static string i stedet for den reelle funktion
        }

        /// <summary>
        /// Tæller til et tal, hvis der skrives 3 bør den skrive 1,2,3
        /// </summary>
        /// <param name="number">tallet der skal tælles til</param>
        static void CountToNumber(int number)
        {
            for (int i = 0; i < number; i++) //referede til en static integer der altid er 1
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Skriver beskeden med caps hvis bool parametret er true. Hvis der gives true og Hello, skal den skrive HELLO
        /// </summary>
        /// <param name="UseCaps">skal det skrives med caps</param>
        /// <param name="message">Beskeden der skal skrives</param>
        static void WriteMessageWithCaps(bool UseCaps, string message)
        {
            if (UseCaps) //der stod (UseCaps = true) der skal enten sammenlignes ellers forsøger den at sætte det som true. True er i øvrigt underforstået som argument
            {
                Console.WriteLine(message.ToUpper());
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        /// <summary>
        /// Beregner gennemsnitsværdien af de givende tal. Hvis der indtastes 10,20,30 skal den returnere 20
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns>Gennemsnittet</returns>
        static float CalculateAverageValue(float first, float second, float third)
        {
            float sum = first + second + third;
            float average = sum / 3; //antog kun at der var 2 tal (dividerer med 2), men der er 3 tal så derfor skal der divideres med 3
            return average;
        }

        /// <summary>
        /// Beregner den samlede sum op til det indtastede max tal hvis max er 5 skal den give 15
        /// </summary>
        static int CalculateSum(int max)
        {
            int sum = 0;

            for (int i = 1; i <= max; i++)
            {
                sum += i;
                Console.WriteLine($"Adding {i}, sum is now: {sum}");
            }
            return (sum + 1);
        }

        /// <summary>
        /// Tager imod et tal mellem 1,2,3 og skriver ud til konsollen hvad der er indtastet.
        /// </summary>
        static void WriteNumberWithSwitchCase()
        {
            Console.WriteLine("Enter a number between 1 and 3");
            int number = Convert.ToInt32(Console.ReadLine()); //Der stod "number = Console.Read();, dette læser ikke input korrekt

            switch (number)
            {
                case 1:
                    Console.WriteLine("The number was 1");
                    break;
                case 2:
                    Console.WriteLine("The number was 2");
                    break;
                case 3:
                    Console.WriteLine("The number was 3");
                    break;
                default:
                    Console.WriteLine("Number was not 1, 2 or 3");
                    break;
            }

        }


    }
}
