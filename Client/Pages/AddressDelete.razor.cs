using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class AddressDelete
{
    [Inject]
    IAddressService AddressService { get; set; } = default!;

    [Inject]
    NavigationManager NavigationManager { get; set; } = default!;

    [Parameter]
    public Guid AddressId { get; set; }

    private const string AddressUrl = "/address";
    private string _message = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        var response = await AddressService.DeleteAddress(AddressId);
        if (response)
        {
            NavigationManager.NavigateTo(AddressUrl);
        }
        else 
        {
            _message = "Delete did not work";
        }
    }
}