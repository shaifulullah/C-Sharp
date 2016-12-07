using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//Write a program that converts 1 lower case letter ("a" - "z") to its corresponding upper case letter ("A" - "Z").
//For example if the user enters "c" then the program will show "C" on the screen. 

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
           WriteLine("Enter Your Lower Case character: ");
            char input = Convert.ToChar(ReadLine());
            int inputInteger = (int)input;
            if (inputInteger >= 97 && inputInteger <= 122)
            {
                var OutputInteger = inputInteger - 32;
                char finalOutput = (char) OutputInteger;
                WriteLine($"Your upper case character is : {finalOutput}");
            }
            else
            {
                WriteLine("Please enter your Lower case character only: ");
            }
            ReadKey();
        }
    }
}
