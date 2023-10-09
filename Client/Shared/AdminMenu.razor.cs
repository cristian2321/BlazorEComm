using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorEComm.Client.Shared;

public partial class AdminMenu
{
    [Inject]
    private AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;

    bool _isAuthorize = false;

    protected async override Task OnInitializedAsync()
    {
        var role =(await AuthenticationStateProvider.GetAuthenticationStateAsync())
            .User.Claims.FirstOrDefault(x=>x.Type == ClaimTypes.Role);
        if (role is not null && role.Value is not null && role.Value.Contains("Admin"))
        {
            _isAuthorize = true;
        }
    }
}