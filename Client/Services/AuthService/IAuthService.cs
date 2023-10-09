using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.AuthService;

public interface IAuthService
{
    Task<ServiceResponse<string>> Register(UserRegisterDto userRegister);

    Task<ServiceResponse<string>> Login(UserLoginDto userLogin);

    Task<ServiceResponse<bool>> ChangePassword(UserChangePasswordDto userChangePassword);

    Task ValidateUserAuthenticated();

    Task<bool> IsUserAuthenticated();

    Task<bool> IsUserAuthenticatedWithRoleAdmin();
}