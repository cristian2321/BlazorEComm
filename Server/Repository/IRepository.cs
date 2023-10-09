using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository;

public interface IRepository
{
    public bool Add(Entity entity);

    public bool Delete(Entity entity);

    public bool Update(Entity entity);

    public Task<bool> SaveChangesAsync(CancellationToken cancellationToken);

}