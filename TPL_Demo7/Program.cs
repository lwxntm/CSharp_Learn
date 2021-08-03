using System;
using System.Threading.Tasks;
namespace TPL_Demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据并行
            string[] Fruits = { "apple", "banana", "orange", "strawberry", "cherry", "lemon", "mango" };
            Parallel.ForEach(Fruits, e => {
                Console.WriteLine($"{e} has {e.Length} characters");
            });
        }
    }
}
