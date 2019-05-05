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

        [HttpPost]
        public void Post([FromBody]User value)
        {
            _us.AddUser(value);
        }
    }
}