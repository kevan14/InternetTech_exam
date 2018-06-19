using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDI.Interfaces
{
    public interface IUserService
    {
        IEnumerable<Models.User> GetUsers();

        Models.User CreateUser(Models.User newUser);
    }
}
