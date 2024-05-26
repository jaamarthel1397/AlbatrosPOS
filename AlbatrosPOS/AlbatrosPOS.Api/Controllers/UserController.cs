using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.UserService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbatrosPOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        // POST api/<UserController>/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            var result = await this.userService.Login(user.Username, user.Password);

            if (result != string.Empty)
            {
                return Ok(new { 
                    Token = result,
                    UserName = user.Username,
                });
            }

            return BadRequest();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            var result = await this.userService.Register(user.Username, user.Password);

            if (result == true)
            {
                return Ok(true);
            }

            return BadRequest(result);
        }
    }
}
