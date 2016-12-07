using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
//Write a program that takes three points (x1, y1), (x2, y2) and (x3, y3) from the user and the program will check 
//wheteher or not all the three points fall on one straight line.
namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3;
            double slope1, slope2, slope3;
            WriteLine("Please enter first coordinates X1 and Y1 value: ");
            x1 = ToInt32(ReadLine());
            y1 = ToInt32(ReadLine());
            WriteLine("Please enter first coordinates X2 and Y2 value: ");
            x2 = ToInt32(ReadLine());
            y2 = ToInt32(ReadLine());
            WriteLine("Please enter first coordinates X3 and Y3 value: ");
            x3 = ToInt32(ReadLine());
            y3 = ToInt32(ReadLine());
            slope1 = y2 - y1/x2 - x1;
            slope2 = y3 - y2/x3 - x2;
            slope3 = y3 - y1/x3 - x1;
            if (slope1 == slope2 && slope2 == slope3)
            {
                WriteLine("They are straight line");
            }
            else
            {
                WriteLine("All points are not fall on one straight line");
            }
            ReadKey();
        }
    }
}
