using BCryptSample.IService;
using BCryptSample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BCryptSample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }
        
        [HttpPost]
        public User SignUp([FromBody] User user)
        {
            return _userService.SignUp(user);
        }

        [HttpGet]
        public User Login([FromBody] User user)
        {
            return _userService.Login(user);
        }

    }
}
