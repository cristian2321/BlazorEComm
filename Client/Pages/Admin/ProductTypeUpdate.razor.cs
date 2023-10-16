using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductTypeUpdate
{
    [Parameter]
    public Guid ProductTypeId { get; set; }

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    protected override async Task OnInitializedAsync() => 
        _ = await AdminService.IsUserWithAdminRole();
}