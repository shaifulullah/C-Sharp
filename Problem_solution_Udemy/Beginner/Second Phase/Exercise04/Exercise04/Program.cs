using System;
//Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
//If the user guesses the number, display “You won"; otherwise, display “You lost". 
//(To make sure the program is behaving correctly, you can display the secret number on the console first.)

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            var number  = new Random().Next(1,10);
            Console.WriteLine($"Random number is {number}");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess a number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess==number)
                {
                    Console.WriteLine("Congrats you have own!");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("you have lost!");
                }
            }
            Console.ReadKey();
        }
    }
}
