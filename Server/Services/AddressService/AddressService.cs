using BlazorEComm.Server.Repository.Extensions.Interfaces;
using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.AddressService;

public class AddressService : IAddressService
{
    private readonly IRepository _repository;
    private readonly IAddressExtensionRepository _addressExtensionRepository;
    private readonly IHttpContextService _httpContextService;

    public AddressService(IRepository repository, IAddressExtensionRepository addressExtensionRepository, IHttpContextService httpContextService)
    {
        _repository = repository;
        _addressExtensionRepository = addressExtensionRepository;
        _httpContextService = httpContextService;
    }

    public async Task<ServiceResponse<Address>> AddAddress(Address address, CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();
        address.UserId = userId;

        await SetPrincipalAddress(address, userId, cancellationToken);

        var added = _repository.Add(address);
        if (added)
        {
            added = await _repository.SaveChangesAsync(cancellationToken);
        }

        return added ?
            new () { Data = address }: 
            new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageAddressNotAdded
            };
    }

    public async Task<ServiceResponse<bool>> DeleteAddress(Guid addressId, CancellationToken cancellationToken)
    {
        var address = await _addressExtensionRepository.GetAddress(addressId, cancellationToken);
        if (address is null || address is null)
        {
            return new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageAddressNotFound
            };
        }

        await SetPrincipalAddress(address, address.UserId, cancellationToken, ConstantServerServices.IsDelete);

        var deleted = _repository.Delete(address);
        
        return deleted ? 
            new() { Data = await _repository.SaveChangesAsync(cancellationToken) }:
            new() { Data = deleted };
    }

    public async Task<ServiceResponse<Address?>> GetAddress(Guid addressId, CancellationToken cancellationToken)
    {
        var address = await _addressExtensionRepository.GetAddress(addressId, cancellationToken);

        return address is not null ?
         new()
         {
             Data = address
         } :
         new()
         {
             Data = default
         };
    }

    public async Task<ServiceResponse<List<Address>>> GetAddresses(CancellationToken cancellationToken) =>
        new() { Data = await _addressExtensionRepository.GetAddresses(cancellationToken) };

    public async Task<ServiceResponse<Address?>> UpdateAddress(Address address, CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();
        address.UserId = userId;

        var oldAddress = await _addressExtensionRepository.GetAddress(address.Id, cancellationToken);

        if (oldAddress is null)
        {
            return new ()
            {
                Data = default,
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageAddressNotFound
            };
        }

        oldAddress.Principal = address.Principal;
        await SetPrincipalAddress(oldAddress, userId, cancellationToken);

        UpdateOldAddress(address, oldAddress);

        var updated = _repository.Update(oldAddress);
        if (updated)
        {
            updated = await _repository.SaveChangesAsync(cancellationToken);
        }

        return updated ?
            new() { Data = address } :
            new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageAddressNotUpdated
            };
    }

    private async Task SetPrincipalAddress(Address address, Guid userId, CancellationToken cancellationToken, bool isDeleted = false)
    {
        if (address.Principal)
        {
            if (isDeleted)
            {
                var firstAddress = await _addressExtensionRepository.GetAddressNotPrincipal(userId, cancellationToken);

                if (firstAddress is not null && firstAddress is not null)
                {
                    firstAddress.Principal = ConstantServerServices.IsPrincipal;
                }

                return;
            }
            
            var addressPrincipal = await _addressExtensionRepository.GetAddressPrincipal(userId, cancellationToken);
            if (addressPrincipal is not null && addressPrincipal.Id != address.Id)
            {
                addressPrincipal.Principal = !ConstantServerServices.IsPrincipal;
            }
        }
        else if (!(await _addressExtensionRepository.AnyAddressPrincipal(userId, cancellationToken)))
        {
            address.Principal = ConstantServerServices.IsPrincipal;
        }
    }

    private static void UpdateOldAddress(Address address, Address oldAddress)
    {
        oldAddress.FirstName = address.FirstName;
        oldAddress.LastName = address.LastName;
        oldAddress.Street = address.Street;
        oldAddress.City = address.City;
        oldAddress.Region = address.Region;
        oldAddress.Country = address.Country;
        oldAddress.PostalCode = address.PostalCode;
    }
}