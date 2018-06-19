using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDI.Models;

namespace WebApiDI.Services
{
    public class UserService : Interfaces.IUserService
    {
        private Interfaces.IDbFacade _db;

        public UserService(Interfaces.IDbFacade databaseObject)
        {
            this._db = databaseObject; 
        }

        public User CreateUser(User newUser)
        {
            _db.CreateUser(newUser);
            return newUser;
        }

        public IEnumerable<User> GetUsers()
        {
            foreach (User s in _db.GetAllUsers())
            {
                Console.WriteLine(s.Name); 
            }
            return _db.GetAllUsers();
        }
    }
}
