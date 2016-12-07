using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    //1- Write a program and ask the user to enter a number.The number should be between 1 to 10. 
    //If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". 
    //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 10: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input>=1 && input<=10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.ReadKey();
        }
    }
}
