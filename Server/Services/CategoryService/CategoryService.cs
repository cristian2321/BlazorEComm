using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly ICategoryExtensionRepository _categoryExtensionRepository;
    private readonly IRepository _repository;

    public CategoryService(ICategoryExtensionRepository categoryExtensionRepository, IRepository repository)
    {
        _categoryExtensionRepository = categoryExtensionRepository;
        _repository = repository;
    }
    
    public async Task<ServiceResponse<List<Category>>> AddCategory(Category category, CancellationToken cancellationToken)
    {
        if (await _categoryExtensionRepository.AnyDbCategory(category, cancellationToken))
        {
            return await GetAdminCategories(cancellationToken);
        }

        var added = _repository.Add(category);
        if (added)
        {
            _ = await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetAdminCategories(cancellationToken);
    }

    public async Task<ServiceResponse<List<Category>>> DeleteCategory(Guid categoryId, CancellationToken cancellationToken)
    {
        var category = await _categoryExtensionRepository.GetCategoryById(categoryId, cancellationToken);
        if (category is null)
        {
            return new ()
            {
                Succes = !ConstantServerServices.IsSucces, 
                Message = MessagesServerServices.MessageCategoryNotFound 
            };
        }

        category.Deleted = ConstantServerServices.IsDelete;
        category.Visible = !ConstantServerServices.IsVisible;

        var updated = _repository.Update(category);
        if (updated)
        {
            _ = await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetAdminCategories(cancellationToken);
    }

    public async Task<ServiceResponse<List<Category>>> GetAdminCategories(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _categoryExtensionRepository.GetCategories(cancellationToken, !ConstantServerServices.IsVisible)
        };

    public async Task<ServiceResponse<Category?>> GetAdminCategory(Guid categoryId, CancellationToken cancellationToken)
    {
        var category =  await _categoryExtensionRepository.GetAdminCategory(categoryId, cancellationToken);
        
        return category is null ?
            new() { Succes = !ConstantServerServices.IsSucces, Message = MessagesServerServices.MessageCategoryNotFound } :
            new() { Data = category };
    }

    public async Task<ServiceResponse<List<Category>>> GetCategories(CancellationToken cancellationToken) =>
            new ServiceResponse<List<Category>>
            {
                Data = await _categoryExtensionRepository.GetCategories(cancellationToken)
            };

    public async Task<ServiceResponse<List<string>>> GetCategoriesName(CancellationToken cancellationToken) => 
        new()
        {
            Data = await _categoryExtensionRepository.GetCategoriesName(cancellationToken)
        };

    public async Task<ServiceResponse<Guid>> GetCategoryIdByName(string categoryName, CancellationToken cancellationToken)
    {
        var categoryId = await _categoryExtensionRepository.GetCategoryIdByName(categoryName, cancellationToken);

        return categoryId == Guid.Empty ? 
            new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageCategoryIdNotFound
            }: 
            new () 
            { 
                Data = categoryId 
            };
    }

    public async Task<ServiceResponse<string>> GetCategoryNameById(Guid categoryId, CancellationToken cancellationToken)
    {
        var categoryName = await _categoryExtensionRepository.GetCategoryNameById(categoryId, cancellationToken);
        return string.IsNullOrWhiteSpace(categoryName) ?
            new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageCategoryNameNotFound
            } :
            new()
            {
                Data = categoryName
            };
    }

    public async Task<ServiceResponse<List<Category>>> UpdateCategory(Category category, CancellationToken cancellationToken)
    {
        var dbCategory = await _categoryExtensionRepository.GetCategoryById(category.Id, cancellationToken);
        if (dbCategory is null)
        {
            return new () 
            {
                Succes = !ConstantServerServices.IsSucces, 
                Message = MessagesServerServices.MessageCategoryNotFound 
            };
        }

        dbCategory.Name = category.Name;
        dbCategory.Url = category.Url;
        dbCategory.Visible = category.Visible;

        var updated = _repository.Update(dbCategory);
      
        if (updated)
        {
            _ = await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetAdminCategories(cancellationToken);
    } 
}