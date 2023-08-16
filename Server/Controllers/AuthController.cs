using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlazorEComm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<string>>> Register(UserRegisterDto userRegister, CancellationToken cancellationToken)
        {
            var response = await _authService
                .Register(new User
                {
                    Email = userRegister.Email
                }, userRegister.Password, cancellationToken);

            return response.Succes ?
                Ok(response) :
                BadRequest(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto userLogin, CancellationToken cancellationToken)
        {
            var response = await _authService.Login(userLogin.Email, userLogin.Password, cancellationToken);

            return response.Succes ?
                Ok(response) :
                BadRequest(response);
        }

        [HttpPost("change-password"), Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody] string newPassword, CancellationToken cancellationToken) 
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var response =  await _authService.ChangePassword(Guid.Parse(userId), newPassword, cancellationToken);

            return response.Succes ?
                Ok(response) :
                BadRequest(response);
        }
    }
}
