using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Exercise5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a console application that accepts a string from the user and outputs a string with the
            // characters in reverse order
            /*WriteLine("Please enter your string :");
            string userInput = ReadLine();
            WriteLine($"you have entered {userInput}");
            string output = "";
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                output += userInput[i];
            }
            WriteLine($"Reversed String : {output}");
            ReadKey();*/
            WriteLine("Give me your input and i will reverse it :");
            string userInput = ReadLine();
            string reverseString = "";
            for(int i= userInput.Length-1; i>=0; i--)
            {
                reverseString += userInput[i];
            }
            WriteLine($"your reversal strig is :{reverseString}");
            ReadKey();
        }     
    }
}
