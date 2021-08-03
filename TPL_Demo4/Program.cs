using System;
using System.Threading.Tasks;

namespace TPL_Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Func委托
            Func<long> myFunc = new Func<long>(DoPosTotal);
            Task<long> myTask=Task<long>.Run(myFunc);
            //创建Func委托
            Func<long> myFunc2 = new Func<long>(DoNegTotal);
            Task<long> myTask2 = Task<long>.Run(myFunc2);
            Console.WriteLine(DateTime.Now);
            long result = myTask.Result;
            Console.WriteLine(DateTime.Now);
            long result2 = myTask2.Result;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"the result is {result}and {result2}");
        }

        public static long DoPosTotal()
        {
            long posTotal = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                posTotal += i;
            }
            return posTotal;
        }
        public static long DoNegTotal()
        {
            long negTotal = 0;
            for (int i = 0; i > int.MinValue; i--)
            {
                negTotal += i;
            }
            return negTotal;
        }
    }
}
