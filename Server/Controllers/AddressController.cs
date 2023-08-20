using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Address>>>> GetAddressPrincipal(CancellationToken cancellationToken) =>
        Ok(await _addressService.GetAddresses(cancellationToken));

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Address>>> AddAddress(Address address, CancellationToken cancellationToken) =>
        Ok(await _addressService.AddAddress(address, cancellationToken));
}