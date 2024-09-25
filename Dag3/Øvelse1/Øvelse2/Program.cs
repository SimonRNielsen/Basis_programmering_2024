using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int returned_int;
            int firstNumber = 21;
            int secondNumber = 42;
            Greeting();
            ConditionalGreeting();
            ConditionalGreeting("Jeg er nu ændret");
            returned_int = RetrieveValue();
            Console.WriteLine($"{returned_int}");
            Console.WriteLine(DivideNumbers(secondNumber,firstNumber));
            Console.WriteLine(MultipliedNumbers(secondNumber,7));
            Console.WriteLine(AddedNumbers(firstNumber,secondNumber));
            Console.WriteLine(SubtractedNumbers(31,secondNumber));
            Console.WriteLine(Equation(10,2,5));
            Console.ReadKey();
        }
        #region Functions
        /// <summary>
        /// Standard velkomstbesked
        /// </summary>
        static void Greeting()
        {
            Console.WriteLine("Hej med dig, jeg er en standard greeting");
        }
        /// <summary>
        /// En standard velkomstbesked der kan modificeres
        /// </summary>
        /// <param name="message">Denne kan ændres hvis man har lyst</param> 
        static void ConditionalGreeting(string message = "Hej, jeg kan ændres i parametre")
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// En funktion der returnerer værdien af 2 tal
        /// </summary>
        /// <returns>Resultatet af tal 1 og 2</returns>
        static int RetrieveValue()
        {
            int firstNumber = 1;
            int secondNumber = 2;
            return firstNumber + secondNumber;
        }
        /// <summary>
        /// En funktion til at dividere 2 tal og returnere værdien
        /// </summary>
        /// <param name="divideInt1">tal eller integer</param>
        /// <param name="divideInt2">tal eller integer</param>
        /// <returns>Første tal eller integer divideret med det andet</returns>
        static int DivideNumbers(int divideInt1, int divideInt2)
        {
            return divideInt1 / divideInt2;
        }
        /// <summary>
        /// En funktion til at gange 2 tal og returnere værdien
        /// </summary>
        /// <param name="multiInt1">tal eller integer</param>
        /// <param name="multiInt2">tal eller integer</param>
        /// <returns>De 2 tal/integers ganget med hinanden</returns>
        static int MultipliedNumbers(int multiInt1, int multiInt2)
        {
            return multiInt1 * multiInt2;
        }
        /// <summary>
        /// En funktion til at lægge 2 tal sammen og returnere værdien
        /// </summary>
        /// <param name="addedInt1">tal eller integer</param>
        /// <param name="addedInt2">tal eller integer</param>
        /// <returns>De 2 tal/integers sammenlagt</returns>
        static int AddedNumbers(int addedInt1, int addedInt2)
        {
            return addedInt1 + addedInt2;
        }
        /// <summary>
        /// En funktion til at trække 2 tal fra hinanden og returnere værdien
        /// </summary>
        /// <param name="subInt1">tal eller integer</param>
        /// <param name="subInt2">tal eller integer</param>
        /// <returns>Resultatet af første tal fratrukket det andet</returns>
        static int SubtractedNumbers(int subInt1, int subInt2)
        {
            return subInt1 - subInt2;
        }
        /// <summary>
        /// En funktion til at udregne ligningen (x+b*10/y)
        /// </summary>
        /// <param name="x">tal eller integer</param>
        /// <param name="b">tal eller integer</param>
        /// <param name="y">tal eller integer</param>
        /// <returns>Resultatet af ligningen</returns>
        static int Equation(int x, int b, int y)
        {
            return (x + b * 10) / y;
        }
        #endregion
    }
}
