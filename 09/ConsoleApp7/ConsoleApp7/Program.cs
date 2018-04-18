using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            
            for (int x =0; x <= word.Length-1; x++)
            {
                char letter = word[x];
                if (letter == 'ж')
                {
                    z = z + 1;
                    Console.WriteLine(z);
                }
            }
            Console.ReadLine();
        }
    }
}
