using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a console application that places double quotes around each word in a string.
            /* SOl#1 
            WriteLine("Enter a string:");
             string myString = ReadLine();
             myString ="\""+ myString.Replace(" ", "\"\"")+"\"";
             WriteLine($"here is the output {myString}");
             ReadKey();
             */
            /*Sol2
            WriteLine("Enter a string");
             string mystring = ReadLine();
             string[] words = mystring.Split(' ');
             foreach (string word in words)
             {
                 WriteLine($"\"{word}\""); 
             }
             ReadKey();
             */
            WriteLine("Enter a string");
            string myString = ReadLine();
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                WriteLine($"\"{word}\"");
            }
            ReadKey();
        }
    }
}
