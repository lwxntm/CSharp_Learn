using System;
using ServiceStack;
using ServiceStack.Text;
namespace JsonDemos
{
    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Id=System.Guid.NewGuid().ToString();
            Name=name;
            Age=age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person wang=new Person("xiaotian", 25);
            var leiStr = wang.ToJson();
            Console.WriteLine(leiStr);
            Person lei=leiStr.FromJson<Person>();
            Console.WriteLine(lei.Id);
            var obj = JsonObject.Parse(leiStr);
            var n1 = obj.Get<string>("Name");
            Console.WriteLine(n1);
            Console.WriteLine("============");
            var dynObj = DynamicJson.Deserialize(leiStr);
            var dynName=dynObj.Name;
            Console.WriteLine(dynName);
        }
    }
}
