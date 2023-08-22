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

    protected override async Task OnInitializedAsync()
    {
        await AuthService.ValidateUserAuthenticated();

        _addresses = await AddressService.GetAddresses();
        _existsAddress = _addresses is not null && _addresses.Any();
    }

    public void NavigateToUpdate(Guid addressId) => 
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AddressUpdateUrl}/{addressId}");

    public void NavigateToDelete(Guid addressId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AddressDeleteUrl}/{addressId}");
}