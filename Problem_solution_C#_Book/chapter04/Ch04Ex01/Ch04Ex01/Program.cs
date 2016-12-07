using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            Console.WriteLine("Enter an Integer number: ");
            myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThen10 = myInt < 10;
            bool inBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer less then 10? {isLessThen10}");
            Console.WriteLine($"Integer between 0 and 5? {inBetween0And5}");
            Console.WriteLine($"Exactly one of the above is True? {inBetween0And5 ^ isLessThen10}");
            Console.ReadKey();
         }
    }
}
