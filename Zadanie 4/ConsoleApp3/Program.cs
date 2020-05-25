using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внимание!");

            Console.WriteLine($"id потока-{Thread.CurrentThread.ManagedThreadId}");

            List<int> array = new List<int>();

            for (int i = 1; i < 200; i++)
            {
                array.Add(i);
            }

            // параллельная обработка
            array.AsParallel().ForAll(x =>
            {
                double value = Math.Pow(x, 2);
                Console.WriteLine(
                    $"Число - {x}, \tквадрат числа - {value}, \tтекущий поток - {Thread.CurrentThread.ManagedThreadId}");
            });

            Console.WriteLine($"Спасибо за внимание");
            Console.ReadLine();
        }
    }
}