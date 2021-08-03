using System;
using System.Diagnostics;

namespace TPL_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // 耗时操作1
            long posTotal = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                posTotal += i;
            }
            
            // 耗时操作2
            long negTotal = 0;
            for (int i = 0; i > int.MinValue; i--)
            {
                negTotal += i;
            }
        
            long total = posTotal + negTotal;
            
            stopWatch.Stop();

            Console.WriteLine($"posTotal is {posTotal}");
            Console.WriteLine($"negTotal is {negTotal}");
            Console.WriteLine($"Total is {total}");

            Console.WriteLine(stopWatch.Elapsed);

        }

    }
}
