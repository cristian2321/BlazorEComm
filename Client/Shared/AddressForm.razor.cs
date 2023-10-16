using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class AddressForm
{
    [Inject]
    IAddressService AddressService { get; set; } = default!;

    [Inject]
    IRedirectService RedirectService { get; set; } = default!;

    [Parameter]
    public bool Add { get; set; } = default!;

    [Parameter]
    public Guid AddressId { get; set; }

    private string _submitText = string.Empty;
    private string _message = string.Empty;
    private Address _address = new();


    protected override async Task OnInitializedAsync()
    {
        if (Add)
        {
            _submitText = MessagesClientSharedComponements.MessageAddAddress;
        }
        else
        {
            _submitText = MessagesClientSharedComponements.MessageUpdateAddress;

            var address = await AddressService.GetAddress(AddressId);
            if (address is null)
            {
                RedirectService.NavigateTo(RedirectService.GetBaseUri());
            }

            _address = address!; 
        }
    }

    private async Task HandleAddressAddOrUpdate()
    {
        if (Add)
        {
            var response = await AddressService.AddAddress(_address);
            if (response is not null)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.BaseAddressUrl);
            }
        }

        else 
        {
            var response = await AddressService.UpdateAddress(_address);
            if (response)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.BaseAddressUrl);
            }
            else
            {
                _message = MessagesClientSharedComponements.MessageUpdateAddressNotWork;
            }
        }
    }
}