using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskIn.Web.Models
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers => 
            new List<User> 
            {
                new User {Id = 1, Name = "John One"},
                new User {Id = 2, Name = "John Doe"},
                new User {Id = 3, Name = "John Tres"},
                new User {Id = 4, Name = "John Four"}

            };

        public User GetUserById(int userId)
        {
            return AllUsers.First(u => u.Id == userId);
        }
    }
}
