using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDI.Models;

namespace WebApiDI.Services
{
    public class DbMock : Interfaces.IDbFacade
    {
        private Dictionary<int, User> _dict = new Dictionary<int, User>();
        private int counter = 0;

        public DbMock()
        {
            User u1 = new User() { Name = "Kennet", Age = 25 };
            User u2 = new User() { Name = "Emil", Age = 24 };
            CreateUser(u1);
            CreateUser(u2);
        }


        public User CreateUser(User newUser)
        {
            _dict.Add(counter, newUser);
            counter++;
            return newUser;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _dict.Values;
        }

        public Dictionary<int, User> GetDataModel()
        {
            return _dict;
        }
    }
}
