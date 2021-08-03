using System;
using System.Threading.Tasks;

namespace TPL_Demo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Action[] actions = new Action[] { eat, sleep, eat, sleep, eat, sleep, eat, sleep, eat, sleep, eat, sleep };

            var result = Parallel.ForEach(actions, action => action.Invoke());


            Console.WriteLine("Hello World!");
        }

        public static void eat()
        {
            Console.WriteLine("吃饭啦！！");
        }
        public static void sleep()
        {
            Console.WriteLine("睡觉啦！");
        }
    }
}
