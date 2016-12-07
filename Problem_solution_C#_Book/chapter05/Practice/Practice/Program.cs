using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] trimChar = { ' ','e','s' };
            string userInput = ReadLine();
            userInput= userInput.ToLower();
            userInput = userInput.Trim(trimChar);
            WriteLine($"this is ans { userInput} ");
            ReadKey();
         }
    }
}
