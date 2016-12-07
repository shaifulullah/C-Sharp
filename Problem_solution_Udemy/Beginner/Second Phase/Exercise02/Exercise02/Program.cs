using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//Write a program and continuously ask the user to enter a number or "ok" to exit.Calculate the sum of all the 
//    previously entered numbers and display it on the console.
namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter any number of press \"ok\" to exit");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine($"{sum}");
            Console.ReadKey();

            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number to continue or \"ok\" to exit");
            //    var input = Console.ReadLine();
            //    if (input.ToLower() == "ok")
            //    {
            //        break;
            //    }
            //    sum +=Convert.ToInt32(input);
            //}
            //Console.WriteLine($"sum of all number is {sum}");
        }
        }
}
