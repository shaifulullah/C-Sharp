using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex02
{
   enum orientation : byte { North=1, South, East, West}
    class Program
    {
        static void Main(string[] args)
        {
            byte directionByte;
            string myDirectionString;
            orientation myDirection = orientation.West;
            WriteLine($"my direction = {myDirection}");
            directionByte = (byte)myDirection;
            myDirectionString = Convert.ToString(myDirection);
            WriteLine($"byte equivalent = {directionByte}");
            WriteLine($"string equivalent = {myDirectionString}");
            ReadKey();
        }
    }
}
