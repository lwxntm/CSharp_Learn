using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Demo1
{
    class Person
    {
        private int age;
        private string name;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person() { }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 10)
                {
                    age = value;
                }
            }
        }
        public string Name { get { return name; } set { name = value; } }
        public override string ToString()
        {
            return $"a Person named {this.name}, {this.age} years old ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void ListTest()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.ForEach(l => Console.WriteLine(l));
        }

        public static void LinqTest()
        {
            var numbers = new int[7] { 2, 3, 4, 5, 6, 7, 8 };
            var querynum = from num in numbers where num % 2 == 0 select num;
            var res = querynum.ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            // anotherquery
            var anotherquery = numbers.Where(num => num % 2 == 0).ToList();
            foreach (var item in anotherquery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
