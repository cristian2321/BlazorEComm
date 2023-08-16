using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Register
{
    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    private readonly UserRegisterDto _userRegister = new ();

    private string _message = string.Empty;
    private string _messageCssClass = string.Empty;

    private const string TextSucces = "text-success";
    private const string TextDanger = "text-danger";

    private async Task HandleRegistration()
    {
        var result = await AuthService.Register(_userRegister);
        _message = result.Message;
     
        _messageCssClass = result.Succes ?
            TextSucces :
            TextDanger;
    }
}