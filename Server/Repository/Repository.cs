using BlazorEComm.Server.Services;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository;

public class Repository : IRepository
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly ILogger<Repository> _logger; 

    public Repository(EcommDbContext ecommDbContext, ILogger<Repository> logger)
    {
        _ecommDbContext = ecommDbContext;
        _logger = logger;
    }

    public bool Add(Entity entity)
    {
        try
        {
            _ecommDbContext.Add(entity);

            return ConstantServerServices.IsSucces;
        }
        catch (Exception ex)
        {
            _logger.LogError("Error {method} :{error}", nameof(Add), ex.StackTrace);
            
            return !ConstantServerServices.IsSucces;
        }
    }

    public bool Delete(Entity entity)
    {
        try
        {
            _ecommDbContext.Entry(entity).State = EntityState.Deleted;

            return ConstantServerServices.IsSucces;
        }
        catch (Exception ex)
        {
            _logger.LogError("Error {method} :{error}", nameof(Delete), ex.StackTrace);

            return !ConstantServerServices.IsSucces;
        }
    }

    public bool Update(Entity entity)
    {
        try
        {
            _ecommDbContext.Entry(entity).State = EntityState.Modified;

            return ConstantServerServices.IsSucces;
        }
        catch (Exception ex)
        {
            _logger.LogError("Error {method} :{error}", nameof(Delete), ex.StackTrace);

            return !ConstantServerServices.IsSucces;
        }
    }

    public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken)
    {
        var saveResult = await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return saveResult > 0;
    }
}
