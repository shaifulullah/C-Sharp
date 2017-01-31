﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Exercises
Section 6, Lecture 55
Note: For any of these exercises, ignore input validation unless otherwise directed. Assume the user enters values in the format that the 
program expects.

1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on 
the number of names provided, display a message based on the above pattern.
2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display 
the reversed name on the console.
3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. 
Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display 
the unique numbers that the user has entered.
5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 
5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
     */
namespace Exescise06
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                names.Add(input);
            }
            if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]} , {names[1]} and {names.Count - 2} others likes your post");                
            }
            else if(names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} likes your post");
            }
            else if(names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

//var names = new List<string>();

//while (true)
//{
//    Console.Write("Type a name (or hit ENTER to quit): ");

//    var input = Console.ReadLine();
//    if (String.IsNullOrWhiteSpace(input))
//        break;
//    names.Add(input);
//}

//if (names.Count > 2)
//    Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
//else if (names.Count == 2)
//    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
//else if (names.Count == 1)
//    Console.WriteLine("{0} likes your post.", names[0]);
//else
//    Console.WriteLine();