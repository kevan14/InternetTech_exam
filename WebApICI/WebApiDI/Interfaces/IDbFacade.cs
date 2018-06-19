using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDI.Interfaces
{
    public interface IDbFacade
    {
        IEnumerable<Models.User> GetAllUsers();

        Models.User CreateUser(Models.User newUser);

    }
}
