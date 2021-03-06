﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryTrainer {
	class Program {
		static void Main(string[] args) {
			GuessNumber();
		}

		static void GuessNumber() {
			// создаем генератор случайных чисел
			Random rand = new Random();
            int win = 0;
            int time = 2000;
			int maxTarget = 100;
            while (true)
            {
                // генерируем случайное число с помощью генератора
                int target = rand.Next(maxTarget);
                {
                    Console.WriteLine("Запомните число: " + target);
                    Thread.Sleep(time);
                    Console.Clear();

                    Console.WriteLine("Введите запомненное число");
                    int guess = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (guess == target)
                    {
                        Console.WriteLine("Вы угадали!");
                        maxTarget = maxTarget + 200;
                        win = win + 1;
                        if (win >= 10)
                        {
                            time = time - 200;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ошиблись ='(");
                        maxTarget = maxTarget - 100;
                    }

                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
		}
	}
}
