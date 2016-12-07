using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program and ask the user to enter the width and height of an image. 
//Then tell if the image is landscape or portrait.
//Solution using enum
namespace Exercise03
{
    public enum ImgOri
    {
        landscape,
        portrait
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the image: ");
            var w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image: ");
            var h = Convert.ToInt32(Console.ReadLine());
            var orientation = w > h ? ImgOri.landscape : ImgOri.portrait;
            Console.WriteLine($"this image is {orientation}");
            Console.ReadKey();
        }
    }
}
/* solution 01
  namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the image: ");
            var w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image: ");
            var h = Convert.ToInt32(Console.ReadLine());
            if (w > h)
            {
                Console.WriteLine("this is landscape");
            }
            else
            {
                Console.WriteLine("this is portrait");
            }
            Console.ReadKey();
        }
    }
}
*/
