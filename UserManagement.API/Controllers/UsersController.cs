using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UserManagement.API.Fake;
using UserManagement.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManagement.API.Controllers
{
    [Route("api/[controller]")]  //"api/Users"
    [ApiController]
    public class UsersController : ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(200);


        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = _users.FirstOrDefault(user => user.Id == id);
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post([FromBody] User user)
        {
            _users.Add(user);
            return user;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public User Put(int id, [FromBody] User user)
        {
            var userToUpdate = _users.FirstOrDefault(user => user.Id == id);
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Sex=user.Sex;
            userToUpdate.Address = user.Address;
            userToUpdate.Salary = user.Salary;
            return userToUpdate;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var userToUpdate = _users.FirstOrDefault(user => user.Id == id);
            _users.Remove(userToUpdate);
        }
    }
}
