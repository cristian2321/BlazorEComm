using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class AddressDelete
{
    [Inject]
    IAddressService AddressService { get; set; } = default!;

    [Inject]
    IAuthService AuthService { get; set; } = default!;

    [Inject]
    IRedirectService RedirectService { get; set; } = default!;

    [Parameter]
    public Guid AddressId { get; set; }

    private string _message = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        await AuthService.ValidateUserAuthenticated();

        var response = await AddressService.DeleteAddress(AddressId);
        if (response)
        {
            RedirectService.NavigateTo(ClientApiEndpoints.BaseAddressUrl);
        }
        else
        {
            _message = MessagesClientPages.MessageDeleteNoWork;
        }
    }
}