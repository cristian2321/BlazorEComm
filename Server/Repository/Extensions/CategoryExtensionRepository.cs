using BlazorEComm.Server.Data;
using BlazorEComm.Shared.Models;
using System.Threading;

namespace BlazorEComm.Server.Repository.Extensions;

public class CategoryExtensionRepository : ICategoryExtensionRepository
{
    private readonly EcommDbContext _ecommDbContext;

    public CategoryExtensionRepository(EcommDbContext ecommDbContext)
    {
        _ecommDbContext = ecommDbContext;
    }

    public async Task<bool> AnyDbCategory(Category category, CancellationToken cancellationToken) =>
        await _ecommDbContext.Categories
            .AnyAsync(x => x.Name == category.Name && !x.Deleted, cancellationToken);

    public async Task<Category?> GetAdminCategory(Guid categoryId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Categories
            .FirstOrDefaultAsync(x => !x.Deleted && x.Id == categoryId, cancellationToken);

    public async Task<List<Category>> GetCategories(CancellationToken cancellationToken, bool isVisible = true) =>
         isVisible?
            await _ecommDbContext.Categories
                .Where(x => x.Visible && !x.Deleted)
                .ToListAsync(cancellationToken) :
            await _ecommDbContext.Categories
                .Where(x => !x.Deleted)
                .ToListAsync(cancellationToken);

    public async Task<List<string>> GetCategoriesName(CancellationToken cancellationToken) =>
        await _ecommDbContext.Categories.Where(x => !x.Deleted)
            .Select(x => x.Name)
            .ToListAsync(cancellationToken);

    public async Task<Category?> GetCategoryById(Guid categoryId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId, cancellationToken);

    public async Task<Guid> GetCategoryIdByName(string categoryName, CancellationToken cancellationToken) =>
        await _ecommDbContext.Categories
            .Where(x => !x.Deleted && x.Name.ToLower() == categoryName.ToLower())
            .Select(x => x.Id)
            .FirstOrDefaultAsync(cancellationToken);

    public async Task<string?> GetCategoryNameById(Guid categoryId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Categories
            .Where(x => !x.Deleted && x.Id == categoryId)
            .Select(x => x.Name)
            .FirstOrDefaultAsync(cancellationToken);
}