using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskIn.Web.Models.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
        User GetUserById (int userId);
    }
}
