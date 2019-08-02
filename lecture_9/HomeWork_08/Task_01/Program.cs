using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] poem = "Ночь, улица, фонарь, аптека; Бессмысленный и тусклый свет; Живи еще хоть четветь века -; все будет так.Исхода нет; Умрешь - начнешь опять сначала; И повторится все, как встарь; Ночь, леденая рябь канала,; Аптека, улица, фонарь.; ".Split(';');
            for (int i = 0; i < poem.Length-1; i++)
            {
                Console.WriteLine(poem[i]);
            }

            Console.Read();
        }
    }
}
