using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            Console.WriteLine("Enter First number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
                result = "greater than";
            else if (firstNumber == secondNumber)
                result = "equal to";
            else result = "less than";
            
            Console.WriteLine ($"The first number is {result} the second number.");
            Console.ReadKey();

            /*string comparison;
            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }
            Console.WriteLine($"The first number is { comparison} the second number.");
            Console.ReadKey();*/
        }
    }
}
