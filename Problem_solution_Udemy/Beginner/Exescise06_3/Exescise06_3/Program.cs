/*
 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. 
Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
 */

using System;
using System.Collections.Generic;

namespace Exescise06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (numbers.Count<5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                
                if (numbers.Contains(number))
                {
                    Console.WriteLine("This number is already exists please enther another number");
                    continue;
                }
                numbers.Add(number);
            }
             numbers.Sort();

            foreach (var numbe in numbers)
            {
                Console.WriteLine(numbe);
            }
        }
    }
}
