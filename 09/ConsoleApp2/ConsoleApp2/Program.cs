using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int max = 100;
            int sum = 0;
            for (int num = 0; num <= 50; num++)
            {
                int number = rand.Next(max);
                Console.WriteLine(number);
                sum = sum + number;
            }
            sum= sum / 50;
            Console.WriteLine(sum + " - среднее число");
            Console.ReadLine();
        }
    }
}
