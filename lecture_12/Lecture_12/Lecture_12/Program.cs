using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12
{
    struct rectangle
    {
        public int width;
        public int length;
        rectangle(int width, int length)
        {
            this.length = length;
            this.width = width;
            width = length;
        }
    }
    class Program
    {     

        static void Main(string[] args)
        {
            Random rnd = new Random();
            rectangle[] square = new rectangle [100];
            for (int i = 0; i < square.Length; i++)
            {
                square[i].length = rnd.Next(10);
            }
            for (int i = 1; i < square.Length; i++)
            {
                square[0].Equals(square[i]);
                if (square[0].Equals(square[i]) == true) ;                                                 
                                
            }
            for (int i = 0; i < square.Length; i++)
            {
                Console.WriteLine(square[i]);
            }

            
            Console.Read();

        }
    }
}
