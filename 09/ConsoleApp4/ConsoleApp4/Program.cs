using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 0;
            for (int pep = 1; pep <= 20; pep++)
            {
                Console.WriteLine("Рост бояра?");
                int large = int.Parse(Console.ReadLine());
                if (large > 160)
                {
                    end = end + 1;
                }
            }
            Console.WriteLine(end + " бояр должны подвергнуться наказанию.");
            Console.ReadLine();
        }
    }
}
