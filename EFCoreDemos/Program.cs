using System;
using EFCoreDemos.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace EFCoreDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db=new NorthwindContext())
            {
                var q = from c in db.Customers where c.Country == "China" select c;
                q.ToList<Customer>().ForEach(c => Console.WriteLine(c));
                //查找国家是“USA”的所有成员。
                //db.Customers.Add(new Customer
                //{
                //    CustomerId = "74239",
                //    CompanyName = "Wuxi Apptec",
                //    ContactName = "lulu Wang",
                //    ContactTitle = "researcher",
                //    Address = "NT1-2241",
                //    City = "qidong",
                //    Region = "jiangsu",
                //    PostalCode = "000000",
                //    Country = "China",
                //    Phone = "18790621937",
                //    Fax = "00000"
                //});
                //db.SaveChanges();
                //添加一个成员


            }
        }
    }
}
