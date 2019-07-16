using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {                
                int num = rnd.Next(0, 100);
                arr[i] = num;
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Array.Sort(arr);
            int maxValue = arr[arr.Length - 1];
            Console.Write("Максимальное значение - ");
            Console.WriteLine(maxValue);
            Console.Read();
        }
    }
}
