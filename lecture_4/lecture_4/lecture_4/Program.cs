using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now.TimeOfDay;
            int hours = data.Hours;
            if (hours>=9&hours<12)
            {
                Console.WriteLine("Good morning,guys");
            }
            else if (hours>=12&hours<15)
            {
                Console.WriteLine("Good day,guys");
            }
            else if (hours>=15&hours<22)
            {
                Console.WriteLine("Good evening, guys");
            }
            else
            {
                Console.WriteLine("Good night, guys");
            }
            Console.Read();
        }
    }
}
