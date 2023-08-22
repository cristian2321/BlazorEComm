using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.AddressService;

public class AddressService : IAddressService
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IHttpContextService _httpContextService;

    public AddressService(EcommDbContext ecommDbContext, IHttpContextService httpContextService)
    {
        _ecommDbContext = ecommDbContext;
        _httpContextService = httpContextService;
    }


    public async Task<ServiceResponse<Address>> AddAddress(Address address, CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();
        address.UserId = userId;

        await SetPrincipalAddress(address, userId, cancellationToken);

        _ecommDbContext.Add(address);
        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<Address> { Data = address };
    }

    public async Task<ServiceResponse<bool>> DeleteAddress(Guid addressId, CancellationToken cancellationToken)
    {
        var address = await GetAddress(addressId, cancellationToken);
        if (address is null || address.Data is null)
        {
            return new()
            {
                Data = !ConstantServerServices.IsSucces,
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageAddressNotFound
            };
        }

        await SetPrincipalAddress(address.Data, address.Data.UserId, cancellationToken, ConstantServerServices.IsDelete);
        
        _ecommDbContext.Remove(address.Data);
        await _ecommDbContext.SaveChangesAsync(cancellationToken);
       
        return new() { Data = ConstantServerServices.IsSucces };
    }

    public async Task<ServiceResponse<List<Address>>> GetAddresses(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _ecommDbContext.Addresses
                .Where(x => x.UserId == _httpContextService.GetUserId())
                .OrderByDescending(x=>x.Principal)
                .ToListAsync(cancellationToken)
        };

    public async Task<ServiceResponse<Address?>> GetAddress(Guid addressId, CancellationToken cancellationToken)
    {
        var address = await _ecommDbContext.Addresses.FirstOrDefaultAsync(x => x.Id == addressId, 
            cancellationToken);

        return address is not null? 
            new()
            {
                Data = address
            }:
            new()
            {
                Data = default
            };
    }

    public async Task<ServiceResponse<Address?>> UpdateAddress(Address address, CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();
        address.UserId = userId;

        var oldAddress = await GetAddress(address.Id, cancellationToken);

        if (oldAddress is null || oldAddress.Data is null)
        {
            return new ()
            {
                Data = default,
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageAddressNotFound
            };
        }

        oldAddress.Data.Principal = address.Principal;
        await SetPrincipalAddress(oldAddress.Data, userId, cancellationToken);

        UpdateOldAddress(address, oldAddress.Data);

        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new () { Data = address };
    }

    private async Task SetPrincipalAddress(Address address, Guid userId, CancellationToken cancellationToken, bool isDeleted = false)
    {
        if (address.Principal)
        {
            if (isDeleted)
            {
                var firstAddress = await _ecommDbContext.Addresses.FirstOrDefaultAsync(x => x.UserId == userId &&
                        !x.Principal, 
                    cancellationToken);

                if (firstAddress is not null)
                {
                    firstAddress.Principal = ConstantServerServices.IsPrincipal;
                }

                return;
            }
            
            var addressPrincipal = await GetAddressPrincipal(userId, cancellationToken);
            if (addressPrincipal is not null && addressPrincipal.Id != address.Id)
            {
                addressPrincipal.Principal = !ConstantServerServices.IsPrincipal;
            }
        }
        else if (!(await AnyAddressPrincipal(userId, cancellationToken)))
        {
            address.Principal = ConstantServerServices.IsPrincipal;
        }
    }

    private async Task<Address?> GetAddressPrincipal(Guid userId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Addresses
                .FirstOrDefaultAsync(x => x.UserId == userId && x.Principal,
                    cancellationToken);

    private async Task<bool> AnyAddressPrincipal(Guid userId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Addresses
            .AnyAsync(x => x.UserId == userId &&
                    x.Principal,
                cancellationToken);

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