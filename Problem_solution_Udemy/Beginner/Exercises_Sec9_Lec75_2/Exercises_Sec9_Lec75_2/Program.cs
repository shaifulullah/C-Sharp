using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2- Write a program that reads a text file and displays the longest word in the file.
namespace Exercises_Sec9_Lec75_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Shaiful\Desktop\words.txt";
            var text = File.ReadAllText(path);

            var separator = new char[] { ' ', ',', '.', '?', '!', ';', ':', '\'', '-', '/', '=' };

            var words = text.Split(separator);
            var largestWord = "";
            foreach (var word in words)
            {
                if (word.Length>largestWord.Length)
                {
                    largestWord = word;
                }
            }
            Console.WriteLine(largestWord);
        }
    }
}
