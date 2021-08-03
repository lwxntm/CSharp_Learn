using System;
using System.Threading.Tasks;
namespace TPL_Demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //多任务串联执行：
            Task<long> myTaskOne = new Task<long>(() => {
                // 此处使用Task.Factory.startNew()时出现异常：Start may not be called on a task that was already started
                Console.WriteLine("Task one run");
                return 10 + 20;
            });

            Task<long> myTaskTwo = myTaskOne.ContinueWith<long>((Task<long> arg) => {
                Console.WriteLine("Task two run");
                return arg.Result + 30;
            });

            Task<long> myTaskThree = myTaskTwo.ContinueWith<long>((Task<long>  arg) => {
                Console.WriteLine("Task three run");
                return arg.Result + 40;
            });
            Task myTaskFour = myTaskThree.ContinueWith((Task<long> arg) =>
              {
                  Console.WriteLine("Task four run");
                  Console.WriteLine(arg.Result*10);
              });

            myTaskOne.Start();
            myTaskFour.Wait();

        }
    }
}
