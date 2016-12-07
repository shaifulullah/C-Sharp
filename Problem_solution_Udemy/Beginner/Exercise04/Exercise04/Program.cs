using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc 
//and focus purely on the logic. Write a program that asks the user to enter the speed limit. 
//Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit,
//program should display Ok on the console. If the value is above the speed limit, the program should calculate 
//the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and 
//displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the minimum speed limit in KM/hr: ");
            var MinSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Maximim speed limit in KM/hr: ");
            var MaxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the car speed in KM/hr: ");
            var CarSpeed = Convert.ToInt32(Console.ReadLine());
            if (MinSpeed > CarSpeed)
            {
                Console.WriteLine("you are ok!");
            }
            else
            {
                const int kmPerDemerit = 5;
                var demeritPoints = (CarSpeed - MaxSpeed)/kmPerDemerit;
                if (demeritPoints>12)
                {
                    Console.WriteLine("your license has been suspended!");
                }
                else
                {
                    Console.WriteLine($"you are penalized by {demeritPoints} Demerit Points");
                }
            }
        }
    }
}
