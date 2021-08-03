using System;
using System.Diagnostics;
using System.Threading.Tasks;
namespace TPL_Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //带有参数的Tasks
            int[] maxValues = { int.MaxValue, int.MaxValue / 2, int.MaxValue / 3, int.MaxValue / 4, int.MaxValue / 5 };
            Task<long>[] myTasks = new Task<long>[maxValues.Length];

            for (int i = 0; i < maxValues.Length; i++)
            {
                myTasks[i] = Task<long>.Factory.StartNew(stateValue =>
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    long posTotal = 0;
                    for (int i = 0; i < (int)stateValue; i++)
                    {
                        posTotal += i;
                    }
                    s.Stop();
                    Console.WriteLine($"运行任务耗时{s.Elapsed}");
                    return posTotal;
                }, maxValues[i]);
            }
            Task.WaitAll(myTasks);
            foreach (var myTask in myTasks)
            {
                Console.WriteLine(myTask.Result);
            }

        }
    }
}
