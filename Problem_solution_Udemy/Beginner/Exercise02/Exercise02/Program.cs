using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program which takes two numbers from the console and displays the maximum of the two
namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter two numbers: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //var MaxNumber = (a > b) ? a : b;
            //Console.WriteLine($"Here is the maximum number: {MaxNumber}");
            Console.WriteLine("Enter two number in between 1 and 10");
            var a= Convert.ToInt32(Console.ReadLine());
            var output = (a < 10 && a > 0) ? "invalid" : "vLID";
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
