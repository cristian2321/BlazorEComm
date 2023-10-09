using BlazorEComm.Shared;

namespace BlazorEComm.Client.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _httpClient;

    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<Category> Categories { get; set; } = new ();

    public List<Category> AdminCategories { get; set; } = new ();

    public event Action? OnChange;

    public async Task AddCategory(Category category)
    {
        var response = await _httpClient.PostAsJsonAsync(ClientApiEndpoints.AdminCategoryApiUrl, category);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    public async Task<bool> DeleteCategory(Guid categoryId)
    {
        var response = await _httpClient.DeleteAsync($"{ClientApiEndpoints.AdminCategoryApiUrl}/{categoryId}");
        if (response is null || !response.IsSuccessStatusCode)
        {
            return !ClientConstants.IsSucces;
        }
        await AfterResponseForAddDeleteAndUpdate(response);

        return ClientConstants.IsSucces;
    }

    public async Task GetAdminCategories()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>
             (ClientApiEndpoints.AdminCategoryApiUrl);
        if (response is not null && response.Data is not null)
        {
            AdminCategories = response.Data;
        }
    }
   
    public async Task<List<string>> GetAdminCategoriesName()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<string>>>
            (ClientApiEndpoints.AdminCategoriesNameApiUrl);
        
        return response is not null && response.Data is not null ? 
            response.Data : default!;
    }

    public async Task<Category?> GetAdminCategory(Guid categoryId)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<Category?>>
             ($"{ClientApiEndpoints.AdminCategoryApiUrl}/{categoryId}");

        return response is not null && response.Data is not null && response.Succes ? 
            response.Data : default;
    }

    public async Task<Guid> GetCategoryIdByName(string categoryName)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<Guid>>
                ($"{ClientApiEndpoints.AdminCategoryIdByNameApiUrl}/{categoryName}");

        return response is not null && response.Data != Guid.Empty && response.Succes ?
            response.Data : default;
    }

    public async Task<string?> GetCategoryNameById(Guid categoryId)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<string>>
            ($"{ClientApiEndpoints.AdminCategoryNameByIdApiUrl}/{categoryId}");

        return response is not null && response.Data is not null && response.Succes ?
            response.Data : default;
    }

    public async Task GetCategories()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>
            (ClientApiEndpoints.BaseApiCategoryUrl);
        if (response is not null && response.Data is not null)
        {
            Categories = response.Data;
        }
    }

    public async Task UpdateCategory(Category category)
    {
        var response = await _httpClient.PutAsJsonAsync(ClientApiEndpoints.AdminCategoryApiUrl, category);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    private async Task AfterResponseForAddDeleteAndUpdate(HttpResponseMessage response)
    {
        var responseCategories = (await response.Content.ReadFromJsonAsync<ServiceResponse<List<Category>>>());
        if (responseCategories is not null && responseCategories.Data is not null && responseCategories.Succes)
        {
            AdminCategories = responseCategories.Data;
        }

        await GetCategories();

        OnChange?.Invoke();
    }
}
