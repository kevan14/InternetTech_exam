using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {

        private Interfaces.IUserService _userService;

        public UsersController(Interfaces.IUserService userService)
        {
            this._userService = userService; 
        }

        // GET: api/users
        [HttpGet]
        public Response.ResponseModel Get()
        {
            return new Response.ResponseModel() { Status = "200", Data = _userService.GetUsers() };
        }


        // POST api/users
        [HttpPost]
        public void Post(Models.User newUser)
        {
            _userService.CreateUser(newUser);
        }

    }
}
