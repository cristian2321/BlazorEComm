using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly EcommDbContext _ecommDbContext;

    public CategoryService(EcommDbContext ecommDbContext)
    {
        _ecommDbContext = ecommDbContext;
    }

    public async Task<ServiceResponse<List<Category>>> GetCategories(
        CancellationToken cancellationToken) =>
            new ServiceResponse<List<Category>>
            {
                Data = await _ecommDbContext.Categories.ToListAsync(cancellationToken)
            };
}
