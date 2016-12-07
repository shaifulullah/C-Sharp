using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance, interestRate, targetBalance;
            Console.WriteLine("what is current balance: ");
            currentBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what is your interest rate in % : ");
            interestRate= 1+ Convert.ToDouble(Console.ReadLine())/100;
            Console.WriteLine("what is your target Balance : ");
            do
            {
                targetBalance = Convert.ToDouble(Console.ReadLine());
                if (targetBalance <= currentBalance)
                    Console.WriteLine("You must enter an amount greater than " +
                    "your current balance!\nPlease enter another value.");
            }
            while (currentBalance < targetBalance);
            targetBalance = Convert.ToDouble(Console.ReadLine());
            double totalYears=0;
            
            do
            {
                currentBalance *= interestRate;
                ++totalYears;
            }
            while (currentBalance < targetBalance);
            Console.WriteLine($"in {totalYears} year {(totalYears == 1 ? "" : "s")} you willhave balance of {currentBalance}. ");
            Console.ReadKey();
            /*double balance, interestRate, targetBalance;
        Console.WriteLine("What is your current balance?");
        balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is your current annual interest rate (in %)?");
        interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
        Console.WriteLine("What balance would you like to have?");
        targetBalance = Convert.ToDouble(Console.ReadLine());
        int totalYears = 0;
        do
            {
                balance *= interestRate;
                ++totalYears;
            }
            while (balance < targetBalance);
            Console.WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} you'll have a balance of {balance}.");
            Console.ReadKey();*/
        }
    } 
}
