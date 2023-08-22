using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Address>>> AddAddress(Address address, CancellationToken cancellationToken) =>
        Ok(await _addressService.AddAddress(address, cancellationToken));

    [HttpDelete("{addressId}")]
    public async Task<ActionResult<ServiceResponse<bool>>> DeleteAddress(Guid addressId, CancellationToken cancellationToken) =>
        Ok(await _addressService.DeleteAddress(addressId, cancellationToken));

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Address>>>> GetAddresses(CancellationToken cancellationToken) =>
        Ok(await _addressService.GetAddresses(cancellationToken));

    [HttpGet("{addressId}")]
    public async Task<ActionResult<ServiceResponse<Address?>>> GetAddress(Guid addressId, CancellationToken cancellationToken) =>
        Ok(await _addressService.GetAddress(addressId, cancellationToken));

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Address?>>> UpdateAddress(Address address, CancellationToken cancellationToken) =>
        Ok(await _addressService.UpdateAddress(address, cancellationToken));
}