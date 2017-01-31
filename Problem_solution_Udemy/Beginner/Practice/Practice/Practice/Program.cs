using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Users\Shaiful\Desktop\Resume Shaiful Ullah.docx";
            var file = File.ReadAllText(path);

            var separators = new char[] { ' ', ',', '.', '?', '!', ';', ':', '\'', '-', '/', '=' };

            var words = file.Split(separators);
            var wordcount = 0;

            foreach (var word in words)
            {
                wordcount++;
            }
            Console.WriteLine(wordcount);
        }
    }
}





//var sentance =
//    "This is a sentance of very very very big big big and big example. Now i am trying to learn something but this face book is making " +
//    "my life is very much hell. and seriously i dont like is very much. infact not much at all. Only Allah can tell me when i can get " +
//    "rid of tjis hell. ok enough oif typing";

//const int maxLength = 50;

//if (sentance.Length < maxLength)
//{
//    Console.WriteLine(sentance);
//}
//else
//{
//    var words = sentance.Split(' ');
//    var totalCharacter = 0;
//    var summaryWords = new List<string>();

//    foreach (var word in words)
//    {
//        summaryWords.Add(word);

//        totalCharacter += word.Length + 1;
//        if (totalCharacter > maxLength)
//        {
//            break;
//        }
//    }
//    var summary = string.Join(" ", summaryWords) + ".......";
//    Console.WriteLine(summary);
//}














//var factorial = 1;
//WriteLine("enter number:");
//var number = ToInt32(ReadLine());

//for (int i = 1; i <=number; i++)
//{
//    factorial *= i;
//}
//WriteLine($"{number}!={factorial}");
//ReadKey();