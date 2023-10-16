using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class CategoryUpdate
{
    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    [Parameter]
    public Guid CategoryId { get; set; }

    protected override async Task OnInitializedAsync() => 
        _ = await AdminService.IsUserWithAdminRole();
}