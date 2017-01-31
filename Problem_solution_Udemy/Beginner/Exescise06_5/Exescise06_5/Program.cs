/*
5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 
5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
     */

using System;
using System.Collections.Generic;

namespace Exescise06_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n  Enter comma seperated numbers");
                var input = Console.ReadLine();
                var inputNew = input.Split(',');

                var list = new List<int>();
                foreach (var n in inputNew)
                    list.Add(Convert.ToInt32(n));

                if (list.Count < 5)
                {
                    Console.WriteLine("invalid List: Start again");
                    continue;
                }

                var minList = new List<int> {0, 0, 0};
                for (var i = 0; i < minList.Count; i++)
                {
                    minList[i] = list[0];

                    foreach (var n in list)
                    {
                        if (minList[i] > n)
                            minList[i] = n;
                    }

                    var list2 = new List<int>();
                    foreach (var n in list)
                    {
                        if (n != minList[i])
                            list2.Add(n);
                    }
                    list = list2;

                }
                Console.Write("\n Minimum 3 values are:");
                foreach (var i in minList)
                {
                    Console.Write(i + ",");
                }
                break;

                //var numbers = new List<int>();
                //while (true)
                //{
                //    Console.Write("Enter 5 comma separated numbers: ");
                //    var input = Console.ReadLine();
                //    var values = input.Split(',');

                //    if (values.Length < 5)
                //    {
                //        Console.WriteLine("Invalid List. Try again.");
                //        continue;
                //    }
                //    Array.Sort(values);
                //    for (int i = 0; i < 3; i++)
                //    {
                //        Console.WriteLine(values[i]);
                //    }
                //    break;

            }

        }

    }
}
