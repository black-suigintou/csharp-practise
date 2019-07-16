using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[3];
            arr[0] = "Hello";
            arr[1] = "a";
            arr[2]=32;
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Измененный массив:");
            arr[0] = arr[0] + ", guys!";
            int num1 = Convert.ToInt32(arr[2]);
            int num2 = num1 + 10;
            arr[2] = num2;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.Read();
        }
    }
}
