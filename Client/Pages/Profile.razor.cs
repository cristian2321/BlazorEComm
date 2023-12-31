using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages
{
    public partial class Profile
    {
        [Inject]
        private IAuthService AuthService { get; set; } = default!;

        private readonly UserChangePasswordDto _userChangePassword = new();
       
        private string _message = string.Empty;

        private async Task ChangePassword() => 
            _message = (await AuthService.ChangePassword(_userChangePassword)).Message;
    }
}