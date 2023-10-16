using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Register
{
    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    private readonly UserRegisterDto _userRegister = new ();

    private string _message = string.Empty;
    private string _messageCssClass = string.Empty;

    private async Task HandleRegistration()
    {
        var result = await AuthService.Register(_userRegister);

        if (result.Succes)
        {
            _messageCssClass = ClientCssConstants.TextSucces;
            RedirectService.NavigateTo(ClientApiEndpoints.BaseLoginUrl);
        }
        else
        {
            _message = result.Message;
            _messageCssClass = ClientCssConstants.TextDanger;
        }
    }
}