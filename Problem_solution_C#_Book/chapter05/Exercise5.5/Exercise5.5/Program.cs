using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a console application that accepts a string and replaces all
            //occurrences of the string no with yes.
            WriteLine("Enter your string with \"no\" words :" );
            string inputString = ReadLine();
            inputString = inputString.ToLower();
            inputString = inputString.Replace("no", "yes");
            WriteLine($"your replaced string is {inputString}");
            ReadKey();
        }
    }
}
