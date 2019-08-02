using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12
{
    public struct rectangle
    {
        public int width, length;       
        public rectangle(int width, int length)
        {
            this.length = length;
            this.width = width;            
        }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            rectangle[] square = new rectangle[100];
            int counterForEquals = 0;
            for (int i = 0; i < square.Length; i++)
            {
                square[i].length = rnd.Next(10);
                square[i].width = square[i].length;
            }
            for (int i = 1; i < square.Length; i++)
            {
                square[0].length.Equals(square[i].length);
                if (square[0].length.Equals(square[i].length) == true) 
                    for (int j = 0; j < 1;j++)
                    {
                        counterForEquals += 1;
                    }                 
            }
            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < square.Length; i++)
            {
                Console.WriteLine(square[i].width); // здесь поставила .width чтобы показать, что square[i].width было присвоено значение square[i].length 
            }            
            Console.WriteLine($"Количество дупликатов {counterForEquals}");            
            Console.Read();

        }
    }
}
