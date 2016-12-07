using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;
            Console.WriteLine("Enter First Number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have entered {firstNumber} as 1st number");
            Console.WriteLine("Enter Second Number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have entered {secondNumber} as 2nd number");
            Console.WriteLine("Enter Third Number: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have entered {thirdNumber} as 3rd number");
            Console.WriteLine("Enter Fourth Number: ");
            fourthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have entered {fourthNumber} as 4th number");
            Console.WriteLine($"The product of your {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is " +
                $"{firstNumber*secondNumber*thirdNumber*fourthNumber}.");

            Console.ReadKey();
        }
    }
}
