using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class AddressForm
{
    [Inject]
    IAddressService AddressService { get; set; } = default!;

    [Inject]
    NavigationManager NavigationManager { get; set; } = default!;

    private const string AddressUrl = "/address";

    private string _submitText = string.Empty;
    private string _message = string.Empty;
    private Address _address = new();

    [Parameter]
    public bool Add { get; set; } = default!;

    [Parameter]
    public Guid AddressId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (Add)
        {
            _submitText = "Add address";
        }
        else
        {
            _submitText = "Update address";

            var address = await AddressService.GetAddress(AddressId);
            if (address is null)
            {
                NavigationManager.NavigateTo(NavigationManager.BaseUri);
            }

            _address = address!; 
        }
    }

    private async Task HandleAddressCrud()
    {
        if (Add)
        {
            var response = await AddressService.AddAddress(_address);
            if (response is not null)
            {
                NavigationManager.NavigateTo(AddressUrl);
            }
        }

        else 
        {
            var response = await AddressService.UpdateAddress(_address);
            if (response)
            {
                NavigationManager.NavigateTo(AddressUrl);
            }
            else
            {
                _message = "Update did not work";
            }
        }
    }
}