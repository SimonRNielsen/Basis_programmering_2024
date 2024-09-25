using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_02_Dag_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SaySomething();
          //  SaySomethingWithParameter("Hello");

           int result = ReturnSomething();
     

            Console.WriteLine(result);
        }

        static void SaySomething()
        {
            Console.WriteLine("Hello World");
        }

        static void SaySomethingWithParameter(string msg)
        {
            Console.WriteLine(msg);
        }
        static int ReturnSomething()
        {
            return 10;
        }

        static float Add(float a, float b)
        {
            return a + b;
        }

        static float Divide(float a, float b)
        {
            return a / b;
        }

        static float Multiply(float a, float b)
        {
            return a * b;
        }
        static float Subtract(float a, float b)
        {
         
            return a - b;
        
        }


        //(X + B * 10) / Y
        
        /// <summary>
        /// Does something
        /// </summary>
        /// <param name="x">firs value</param>
        /// <param name="b">second value</param>
        /// <param name="y">last value</param>
        /// <returns>returns the result</returns>
        static float Something(float x, float b, float y )
        {
            return (x + b * 10) / y;
        }

    }
}
