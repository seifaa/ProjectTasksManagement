using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTasksManagement.Application.Contracts;
using ProjectTasksManagement.Application.Dtos.Authentication;

namespace ProjectTasksManagement.API.Controllers
{
    public class AccountController : ControllerBase
    {
         private readonly IAuthService _authService;

        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto userDto)
        {

                var result = await _authService.RegisterAsync(userDto);
                return Ok(result);

        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto userDto)
        {
         
          

                var result = await _authService.LoginAsync(userDto);
                return Ok(result);
           
        }
    }

}
