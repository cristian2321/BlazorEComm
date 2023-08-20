using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Addresses
{
    [Inject]
    IAuthService AuthService { get; set; } = default!;

    [Inject]
    IAddressService AddressService { get; set; } = default!;

    [Inject]
    NavigationManager NavigationManager { get; set; } = default!;

    private List<Address>? _addresses = default;
    private bool _existsAddress = true;

    private const string RegisterUrl = "register";
    private const string AddAddressUrl = "addAddress";

    protected override async Task OnInitializedAsync()
    {
        if (await AuthService.IsUserAuthenticated())
        {
            _addresses = await AddressService.GetAddresses();
            _existsAddress = _addresses is not null && _addresses.Any();
        }

        else
        {
            NavigationManager.NavigateTo(RegisterUrl);
        }
    }

    private void NavigateToAdd() 
    {
        NavigationManager.NavigateTo(AddAddressUrl);
    }
}