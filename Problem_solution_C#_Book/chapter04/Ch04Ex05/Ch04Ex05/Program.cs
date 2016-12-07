using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.WriteLine("enter your cutternt balance");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your interest rate in % ");
            interestRate=1+ Convert.ToDouble(Console.ReadLine())/100;
            Console.WriteLine("what balance you like to have");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            double totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine($"in {totalYears} year{(totalYears == 1 ?"":"s")} you will have {balance}");
            
            if (totalYears == 0) ;
            Console.WriteLine("halar poot moja los???");
            Console.ReadKey();

            /*double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} " +
            $"you'll have a balance of {balance}.");
            if (totalYears == 0)
                Console.WriteLine(
                "To be honest, you really didn't need to use this calculator.");
            Console.ReadKey();*/
        }
    }
}
