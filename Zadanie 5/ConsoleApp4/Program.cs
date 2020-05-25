using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("начало");

            var result = await MethodAsync(30);

            Console.WriteLine("длинна масива=" + result.Length);

            foreach (var k in result)
            {
                Console.Write(k + ", ");
            }

            Console.WriteLine($"конец") ;
            Console.Read();
        }

        // асинхронный метод
        static async Task<int[]> MethodAsync(int n)
        {
            Console.WriteLine($"1 id потока-{Thread.CurrentThread.ManagedThreadId}");
            return await Task.Run(() =>
            {
                Console.WriteLine($"2 id потока-{Thread.CurrentThread.ManagedThreadId}");
                var range = Enumerable.Range(0, n);
                return range.ToArray();
            });
        }
    }
}
