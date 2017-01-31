using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1- Write a program that reads a text file and displays the number of words.
namespace Exercises_Sec9_Lec75
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Shaiful\Desktop\Resume Shaiful Ullah.docx";


            var text = File.ReadAllText(path);

            var separator = new char[] { ' ', ',', '.', '?', '!', ';', ':', '\'', '-', '/', '=' };


            var words = text.Split(separator);
            var wordsCount = 0;
            foreach (var duma in words)
            {
                wordsCount++;
            }
            Console.WriteLine("Words in file : " + wordsCount);
        }
    }
}
