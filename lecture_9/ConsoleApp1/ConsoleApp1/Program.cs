using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Today ");
            sb.Append("is bad weather");
            sb.Append(DateTime.Now);
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
