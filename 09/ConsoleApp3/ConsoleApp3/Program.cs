using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2 = 0;
            for (int num1 = 10; num1 <= 25; num1++) 
            {
                num2 = num1;
                Console.WriteLine(num1 + " " + num2 + ".4");
            }
            Console.ReadLine();
        }
    }
}
