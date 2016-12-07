using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes coordinates (x, y) of a center of a circle and its radius from the user, 
//the program will determine whether a point lies inside the circle, on the circle or outside the circle.
namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
                int x, y, radius;
                int radius_square, coordinates_calculation;
                Console.WriteLine("Enter X and Y coordinates of circle:");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Radius of circle:");
                radius = Convert.ToInt32(Console.ReadLine());
                radius_square = radius * radius;                      // Because equation of a circle is (x-a)^2+(y-b)^2=r^2
                                                                      //And here at the origin (0,0) so we do here 
                coordinates_calculation = (x * x) + (y * y);
                if (coordinates_calculation <= radius_square)
                {

                    Console.WriteLine("Points Lies On The Circle");
                }
                else
                {
                Console.WriteLine("Points Lies InSide The Circle");                 
                }
                Console.ReadKey(); 
        }
    }
}
