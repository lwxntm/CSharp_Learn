using System;
using System.Threading.Tasks;
namespace TPL_Demo8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ParaNumTest();
            }

        }

        public static void ParaNumTest()
        {
            object key = new object();
            int Count = 0;
            Task[] myTasks = new Task[10];
            for (int i = 0; i < myTasks.Length; i++)
            {
                myTasks[i] = Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        //lock (key)
                        {
                            Count++;
                        }

                    }
                });
            }
            Task.WaitAll(myTasks);
            Console.WriteLine($"Count is {Count}");
        }
    }
}
