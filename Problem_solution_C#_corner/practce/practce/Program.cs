using System;
using System.Globalization;

namespace practce
{
    public enum ShippingMethod
    {
        RegularMail=1,
        RegisteredAirMail=2,
        Express=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a:{a},b:{b}", a, b);

            var array1 = new int[] {1, 2, 3};
            var array2 = array1;
            array2[0] = 4;
            Console.WriteLine(String.Format("array1[0]:{0}, array2[1]:{0}", array1[0], array2[0]));
            Console.ReadKey();
        }
    }
}