using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            for (int num1 = 100; num1 <= 200; num1++)
            {
                if (num1 % num == 0) 
                {
                    Console.WriteLine(num1);
                }
            }
            Console.ReadLine();
        }
    }
}
