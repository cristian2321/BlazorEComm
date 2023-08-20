using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class AddressAdd
{
    [Inject]
    IAuthService AuthService { get; set; } = default!;

    [Inject]
    IAddressService AddressService { get; set; } = default!;

    [Inject]
    NavigationManager NavigationManager { get; set; } = default!;
  
    private const string RegisterUrl = "register";
    private const string AddressUrl = "address";

    private readonly Address _address = new();
    
    protected override async Task OnInitializedAsync()
    {
        if (!await AuthService.IsUserAuthenticated())
        {
            NavigationManager.NavigateTo(RegisterUrl);
        }
    }

    private async Task HandleAdd() 
    {
        var response = await AddressService.AddAddress(_address);
        if (response is not null) 
        {
            NavigationManager.NavigateTo(AddressUrl);
        }
    }
}