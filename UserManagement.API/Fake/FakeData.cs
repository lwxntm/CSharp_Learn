using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Models;
using Bogus;

namespace UserManagement.API.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int num)
        {
            if (_users == null)
            {
                var sex = new[] { "male", "female" };
                _users=new  Faker<User>()
                    .RuleFor(u=>u.Id, f=>f.IndexFaker+1)
                    .RuleFor(u=>u.FirstName, f=>f.Name.FirstName())
                    .RuleFor(u=>u.LastName, f=>f.Name.LastName())
                    .RuleFor(u=>u.Sex, f=>f.PickRandom(sex))
                    .RuleFor(u=>u.Address, f=>f.Address.FullAddress())
                    .RuleFor(u=>u.Salary, f=>f.Random.Number(2000, 10000))
                    .Generate(num);
            }
            return _users;
        }
    }
}
