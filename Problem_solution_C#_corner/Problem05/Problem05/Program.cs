using System;
using static System.Console;
using static System.Convert;
/*Write a program (using a switch statement) that takes one value from the user and asks about the type of 
 conversion and then performs a conversion depending on the type of conversion. If user enters:

I -> convert from inches to centimeters. 
G -> convert from gallons to liters. 
M -> convert from mile to kilometer. 
P -> convert from pound to kilogram. 

If the user enters any other character then show a proper message.
 */

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimeter, liters, kilometer, kilogram;
            WriteLine("Enter the value you wanted to convert: ");
            int input = ToInt32(ReadLine());
            WriteLine("\n Press Any Of The Given Choices \n I->convert from inches to centimeters." +
                      "\n G->convert from gallons to liters.\n M->convert from mile to kilometer."+
                      "\n P->convert from pound to kilogram.");
            char choice = Char.ToLower(ToChar(ReadLine()));
            switch (choice)
            {
                case 'i':
                    centimeter = input / 0.3937;                       //1 cm is equal is 0.3037 inch
                    WriteLine($"In Centimeters: {centimeter}");
                    break;
                case 'g':
                    liters= input * 3.78;                             // 1 gallon=3.78 litters
                    WriteLine($"In Liters: { liters}");
                    break;
                case 'm':
                    kilometer = input *1.60;                          // 1 mile=1.4 KM
                    WriteLine($"In kilometer: { kilometer}");
                    break;
                case 'p':
                    kilogram = input * 0.453;                          // 
                    WriteLine($"In kilogram: { kilogram}");
                    break;
                default:
                    WriteLine("You Enter A Invalid Choice, Please Enter A Valid Choice...!");
                    ReadLine();
                    break;
                   }
            ReadKey();
        }
    }
}





/*enum Orientation : byte
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }
    struct Route
    {
        public Orientation Direction;
        public double Distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Route myRoute;
            int myDirection = -1;
            double myDistance;
            WriteLine("1) North\n2) South\n3) East\n4) West");
            do
            {
                WriteLine("Select a direction:");
                myDirection = ToInt32(ReadLine());
            }
            while ((myDirection < 1) || (myDirection > 4));
            WriteLine("Input a distance:");
            myDistance = ToDouble(ReadLine());
            myRoute.Direction = (Orientation)myDirection;
            myRoute.Distance = myDistance;
            WriteLine($"myRoute specifies a direction of {myRoute.Direction} " +
            $"and a distance of {myRoute.Distance}");
            ReadKey();
        }
    }
}*/
   