/*Exercises
Section 6, Lecture 55
Note: For any of these exercises, ignore input validation unless otherwise directed.Assume the user enters values in the format that the
program expects.

1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on 
the number of names provided, display a message based on the above pattern.
*/

using System;
using System.Collections.Generic;
using System.Xml;

namespace Exescise06_1
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
                    break;
                names.Add(input);
            }
            if (names.Count > 2 )
            {
                Console.WriteLine($"{names[0]},{names[1]} and {names.Count - 2} others likes your post");
            }
            else if(names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} likes your post");
            }
            else if (names.Count == 1)
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
