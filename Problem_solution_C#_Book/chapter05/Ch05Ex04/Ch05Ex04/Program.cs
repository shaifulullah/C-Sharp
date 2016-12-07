using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendsName = { "abul", "Babul", "kabul", "Dabul", "Foul" };
            WriteLine($"Here are my {friendsName.Length}" + "friend list");
            foreach (string friend in friendsName)
            {
                WriteLine(friend );
            }
           
            ReadKey();
        }
    }
}
