using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInter
{
    public class Person
    {
        public string Name;

        public void Introduce(string abc)
        {
            Console.WriteLine("Hi {0}, I am {1}",abc, Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person=new Person();
            person.Name = "Kiyaan";
            person.Introduce("Mosh");
        }
    }
}
