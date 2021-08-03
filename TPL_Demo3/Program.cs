using System;
using System.Threading.Tasks;
namespace TPL_Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Action委托
            Action myAction = new Action(DoSomeThing);
            Task myActionTask = new Task(myAction);
            myActionTask.Start();

            Task myLambdaTask = new Task(() => {
                long posTotal = 0;
                for (int i = 0; i < int.MaxValue; i++)
                {
                    posTotal += i;
                }
                Console.WriteLine($"posTotal is {posTotal}");
            });
            myLambdaTask.Start();
            Task.WaitAll(myActionTask,myLambdaTask);
            Console.WriteLine("Success!");
        }

        public static void DoSomeThing()
        {
            long posTotal = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                posTotal += i;
            }
            Console.WriteLine($"posTotal is {posTotal}");
        }
    }
}
