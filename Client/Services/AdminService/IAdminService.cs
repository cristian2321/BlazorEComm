namespace BlazorEComm.Client.Services.AdminService;

public interface IAdminService
{
    Task<bool> IsUserWithAdminRole();
}
