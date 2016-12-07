using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace practice
{
    class Program
    {
        static int MaxValue(int[] intArray, out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for (int i =1; i<intArray.Length; i++)
            {
                if (maxVal < intArray[i])
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }
            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxIndex;
            WriteLine($"{MaxValue(myArray, out maxIndex)}");
            WriteLine($"{maxIndex + 1}");
            ReadKey();
        }
        /*
        static int MaxValue(int[] intArray, out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }
            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxIndex;
            WriteLine($"The maximum value in myArray is { MaxValue(myArray, out maxIndex)}");
            WriteLine($"The first occurrence of this value is at element { maxIndex + 1}");
            ReadKey();
        }
        */
        /*
        static int DoubleNum(int val)
        {
            val *= 2;
            return val;
        }
        static void Main(string[] args)
        {
            int myNumber = 5;
            WriteLine($"myNumber = {myNumber}");
            myNumber = DoubleNum (myNumber);
            WriteLine($"myNumber = {myNumber}");
            ReadKey();
            */
        /*static void ShowDouble(int val)
        {
            val *= 2;
            WriteLine($"val doubled = {val}");
        }
        static void Main(string[] args)
        {
            int myNumber = 5;
            WriteLine($"myNumber = {myNumber}");
            ShowDouble(myNumber);
            WriteLine($"myNumber = {myNumber}");
            ReadKey();     
        }
        */
    }
}
