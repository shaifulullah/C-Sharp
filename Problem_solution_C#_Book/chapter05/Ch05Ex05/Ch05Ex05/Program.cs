using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = { ' ' };
            char[] trimChar = {'f','e','j'};
            string userInput = ReadLine();
            userInput = userInput.ToLower();
            userInput = userInput.Trim(trimChar);
            string[] myString;
            myString = userInput.Split(separator);
            foreach (string word in myString)
            {
                WriteLine($"{word}");
            }
            ReadKey();
        }
    }
}
