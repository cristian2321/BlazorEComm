using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.CategoryService;

public interface ICategoryService
{
    Task<ServiceResponse<List<Category>>> AddCategory(Category category, CancellationToken cancellationToken);

    Task<ServiceResponse<List<Category>>> DeleteCategory(Guid categoryId, CancellationToken cancellationToken);
  
    Task<ServiceResponse<List<Category>>> GetCategories(CancellationToken cancellationToken);

    Task<ServiceResponse<List<Category>>> GetAdminCategories(CancellationToken cancellationToken);

    Task<ServiceResponse<Category?>> GetAdminCategory(Guid categoryId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<Category>>> UpdateCategory(Category category, CancellationToken cancellationToken);

    Task<ServiceResponse<List<string>>> GetCategoriesName(CancellationToken cancellationToken);

    Task<ServiceResponse<Guid>> GetCategoryIdByName(string categoryName, CancellationToken cancellationToken);

    Task<ServiceResponse<string>> GetCategoryNameById(Guid categoryId, CancellationToken cancellationToken);
}