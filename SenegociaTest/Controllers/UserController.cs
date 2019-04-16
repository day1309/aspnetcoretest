using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SenegociaTest.Entities;
using SenegociaTest.Helpers;
using SenegociaTest.Models;
using SenegociaTest.Services;

namespace SenegociaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]LoginModel loginModelParams)
        {
            var user = _userService.Authenticate(loginModelParams.UserName, loginModelParams.Password);

            if (user == null)
                return BadRequest(new { message = ErrorMessage.ErrorAuth });

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}