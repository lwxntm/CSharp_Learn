using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TPL_Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // 耗时操作1
            Task<long> posTask = Task<long>.Run(() =>
            {
                long posTotal = 0;
                for (int i = 0; i < int.MaxValue; i++)
                {
                    posTotal += i;
                }
                return posTotal;
            });


            // 耗时操作2
            Task<long> negTask = Task<long>.Run(() =>
            {
                long negTotal = 0;
                for (int i = 0; i > int.MinValue; i--)
                {
                    negTotal += i;
                }
                return negTotal;
            });


            long total = posTask.Result + negTask.Result;

            stopWatch.Stop();

            Console.WriteLine($"posTotal is {posTask.Result}");
            Console.WriteLine($"negTotal is {negTask.Result}");
            Console.WriteLine($"Total is {total}");

            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
