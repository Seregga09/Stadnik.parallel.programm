using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            string str = Console.ReadLine();
            new Thread(() => { Summ(str); }).Start();
        }
        static void Summ(string str)
        {
            try
            {
                int nul = Convert.ToInt32(str);
                Console.WriteLine(nul);
                if (nul > 0)
                {
                    int max = nul;
                    for (int i = 0; i < max; i++)
                    {
                        nul += i;
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Результат суммы: {nul}\n");
                }
                else if (nul < 0)
                {
                    int min = nul;
                    int j = 0;
                    for (int k = min; k < 0; k++)
                    {
                        nul += k;
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Итог суммы: {nul}\n");
                }
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Errorr! {e.Message}");
                Console.Read();
            }
        }
    }
}