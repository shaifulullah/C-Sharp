﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "shaiful";
            const string goodName = "kiyaan";
            const string badName = "mou";
            Console.WriteLine("Enter your name: ");
            string name;
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case goodName:
                    Console.WriteLine("This is very fantastic name :)");
                    break;
                case badName:
                    Console.WriteLine("yea Khoda tui kochugas e fashi de");
                    break;             
            }
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();
            /* const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    Console.WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name.");
                    break;
            }
            Console.WriteLine($"Hello {name}!");
            Console.ReadKey();*/
        }
    }
}
