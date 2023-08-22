using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IPasswordService _passwordService;

        public AuthController(IAuthService authService, IPasswordService passwordService)
        {
            _authService = authService;
            _passwordService = passwordService;
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
            var response =  await _passwordService.ChangePassword(newPassword, cancellationToken);

            return response.Succes ?
                Ok(response) :
                BadRequest(response);
        }
    }
}
