namespace BlazorEComm.Client.Services.CategoryService;

public interface ICategoryService
{
    event Action? OnChange;

    List<Category> Categories { get; set; }

    List<Category> AdminCategories { get; set; }

    Task GetCategories();

    Task GetAdminCategories();

    Task<List<string>> GetAdminCategoriesName();

    Task<Category?> GetAdminCategory(Guid categoryId);

    Task<Guid> GetCategoryIdByName(string categoryName);

    Task<string?> GetCategoryNameById(Guid categoryId);

    Task AddCategory(Category category);

    Task UpdateCategory(Category category);

    Task<bool> DeleteCategory(Guid categoryId);
}