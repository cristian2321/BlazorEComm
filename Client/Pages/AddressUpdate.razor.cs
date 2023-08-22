using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class AddressUpdate
{
    [Parameter]
    public Guid AddressId { get; set; }
}