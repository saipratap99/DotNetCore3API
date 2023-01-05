using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetAPIService.Models;
using DotNetAPIService.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetAPIService.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
        

        [HttpGet]
        public ActionResult<User[]> Users()
        {
            return Ok(this._userService.GetUsers());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<User> Get(int id)
        {
            User user;
            if((user = this._userService.GetUser(id)) != null)
                return Ok(user);
            else
                return NotFound($"User Not Found with id: {id}");
        }



    }
}

