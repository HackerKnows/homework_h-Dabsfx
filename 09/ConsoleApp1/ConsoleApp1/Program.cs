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
            Console.WriteLine("Введите значение в километрах");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение в футах");
            int ft = int.Parse(Console.ReadLine());
            ft = ft * 305;
            km = km * 1000;
            if (ft < km)
            {
                ft = ft / 305;
                Console.WriteLine(ft + " фут");
            }
            else
            {
                km = km / 1000;
                Console.WriteLine(km + " км");
            }
            Console.ReadLine();
        }
    }
}
