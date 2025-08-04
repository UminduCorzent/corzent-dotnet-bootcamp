using DotNetLearner.API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DotNetLearner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtTokenGenerator _jwt;

        public AuthController(JwtTokenGenerator jwt)
        {
            _jwt = jwt;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            if (dto.Username == "username" &&  dto.Password == "password123")
            {
                var token = _jwt.GenerateToken(dto.Username);
                return Ok(new { token });
            }

            return Unauthorized("Invalid credentials");
        }

        public class LoginDto
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
