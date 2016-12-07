using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console.
//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());

            var facttorial = 1;
            for (int i = 1; i <= input; i++)
            {
                facttorial *= i;
            }
            Console.WriteLine($"{input}!={facttorial}");
            Console.ReadKey();












            //Console.WriteLine("Enter a number: ");
            //var number=Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine($"{number}!={factorial}");
            //Console.ReadKey();
        }   
    }
}
