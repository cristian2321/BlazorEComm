using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class HomeButton
{
    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    private void GoToHome()
    {
        NavigationManager.NavigateTo(NavigationManager.BaseUri);
    }
}