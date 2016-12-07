using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace practice

{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double firstNum, secNum;
                Console.WriteLine("This program decides which one of 2 numbers is greater than 10.");
                Console.WriteLine();
                Console.WriteLine("What is your first number?");
                firstNum = Convert.ToDouble(Console.ReadLine()); //defines firstNum
                Console.WriteLine("What is your second number?");
                secNum = Convert.ToDouble(Console.ReadLine()); //defines secNum
                if ((firstNum > 10) && (secNum > 10))  //evaluates both numbers to be greater than
                {
                    Console.WriteLine();
                    Console.WriteLine("Both of your numbers are greater than 10.  Please try again.");
                }
                else if ((firstNum > 10) && (secNum < 10))  //evaluates firstNum to be greater
                {
                    Console.WriteLine();
                    Console.WriteLine("Your first number {0} is greater than 10 and your second number {1} is less than 10.", firstNum, secNum);
                }
                else if ((firstNum < 10) && (secNum > 10))  // evaluates secNum to be greater
                {
                    Console.WriteLine();
                    Console.WriteLine("Your first number {0} is less than 10 and your second number {1} is greater.", firstNum, secNum);
                }
                else  // just in case both numbers are less than 10
                {
                    Console.WriteLine("Both of your numbers are less than 10!");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to quit");
                Console.ReadKey();


                /*bool numbersOK = false;
                double var1, var2;
                var1 = 0;
                var2 = 0;
                while (!numbersOK)
                {
                    WriteLine("Give me a number:");
                    var1 = ToDouble(ReadLine());
                    WriteLine("Give me another number:");
                    var2 = Convert.ToDouble(ReadLine());
                    if ((var1 > 10) && (var2 > 10))
                    {
                        WriteLine("Only one number may be greater than 10.");
                    }
                    else
                    {
                        numbersOK = true;
                    }
                }
                WriteLine($"You entered {var1} and {var2}.");
                Console.ReadKey();*/



                /*bool numbersOK = false;
                double var1, var2;
                var1 = 0;
                var2 = 0;
                while (!numbersOK)
                {
                    Console.WriteLine("Give me a number:");
                    var1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Give me another number:");
                    var2 = Convert.ToDouble(Console.ReadLine());
                    if ((var1 > 10) && (var2 > 10))
                    {
                        Console.WriteLine("Only one number may be greater than 10.");//check if both numbers are greater than 
                               //10 if so go back to the while loop and ask for new numbers because numbersOK is still false
                    }
                    else
                    {
                        numbersOK = true;// otherwise set numbersOk to true which means the while loop is false now so 
                        //it gets out of the while loop and executes the next line of code after the while loop
                    }
                }
                Console.WriteLine($"You entered {var1} and {var2}.");
                Console.ReadKey();*/

                /*int var1, var2;
                Console.WriteLine("enter your first integer value");
                var1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your second integer value");
                var2 = Convert.ToInt32(Console.ReadLine());
                if (var1 >= 10 && 10 <= var2)
                    Console.WriteLine("Please enter a digit less than 10");
                var1 = Convert.ToInt32(Console.ReadLine());
                var2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"your first number is {var1} and second number is {var2}");
                Console.ReadKey();*/
            }
        }
    }
    }
