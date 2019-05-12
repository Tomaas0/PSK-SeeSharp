using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.IServices;
using Application.Entities;

namespace Application.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private IUserService _us;

        public UsersController(IUserService us)
        {
            _us = us;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _us.GetAllUsers();
        }

        [Route("Login")]
        [HttpPost]
        public ActionResult Login([FromBody]User value)
        {
            User user = _us.LoginUser(value.Email, value.Password);
            if(user != null)
                return Ok();
                else return Unauthorized();

        }

        [Route("New")]
        [HttpPost]
        public void Post([FromBody]User value)
        {
            _us.AddUser(value);
        }

        [Route("Remove/{id}")]
        [HttpPost]
        public void Post(int id)
        {
            _us.RemoveUser(id);
        }
    }
}