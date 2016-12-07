using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
//Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
//    Display the count on the console.


namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorial = 1;
            WriteLine("enter number:");
            var number = ToInt32(ReadLine());

            for (int i = 1; i <=number; i++)
            {
                factorial *= i;
            }
            WriteLine($"{number}!={factorial}");
            ReadKey();
        }
    }
}
