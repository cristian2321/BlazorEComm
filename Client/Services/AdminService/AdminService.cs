using BlazorEComm.Server.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Services.AdminService;

public class AdminService: IAdminService
{
    private IAuthService _authService;
    private NavigationManager _navigationManager;

    public AdminService(NavigationManager navigationManager, IAuthService authService)
    {
        _navigationManager = navigationManager;
        _authService = authService;
    }

    public async Task<bool> IsUserWithAdminRole()
    {
        var authentificateRole = await _authService.IsUserAuthenticatedWithRoleAdmin();
        if (!authentificateRole)
        {
            _navigationManager.NavigateTo(_navigationManager.BaseUri);
        }

        return ConstantServerServices.IsSucces;
    }
}
