using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface ICategoryExtensionRepository
{
    Task<bool> AnyDbCategory(Category category, CancellationToken cancellationToken);

    Task<Category?> GetCategoryById(Guid categoryId, CancellationToken cancellationToken);

    Task<Category?> GetAdminCategory(Guid categoryId, CancellationToken cancellationToken);

    Task<List<string>> GetCategoriesName(CancellationToken cancellationToken);

    Task<Guid> GetCategoryIdByName(string categoryName, CancellationToken cancellationToken);

    Task<string?> GetCategoryNameById(Guid categoryId, CancellationToken cancellationToken);

    Task<List<Category>> GetCategories(CancellationToken cancellationToken, bool isVisible = true);
}