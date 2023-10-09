using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<Category>>>> AddCategory(Category category, CancellationToken cancellationToken) =>
        Ok(await _categoryService.AddCategory(category, cancellationToken));

    [HttpDelete("admin/{categoryId}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<Category>>>> DeleteCategory(Guid categoryId, CancellationToken cancellationToken) =>
        Ok(await _categoryService.DeleteCategory(categoryId, cancellationToken));

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories(CancellationToken cancellationToken) =>
        Ok(await _categoryService.GetCategories(cancellationToken));

    [HttpGet("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<Category>>>> GetAdminCategories(CancellationToken cancellationToken) =>
        Ok(await _categoryService.GetAdminCategories(cancellationToken));

    [HttpGet("admin/categoriesName"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetCategoriesName(CancellationToken cancellationToken) =>
        Ok(await _categoryService.GetCategoriesName(cancellationToken));

    [HttpGet("admin/categoryIdByName/{categoryName}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<Guid>>> GetCategoryIdByName(string categoryName, CancellationToken cancellationToken) =>
        Ok(await _categoryService.GetCategoryIdByName(categoryName, cancellationToken));

    [HttpGet("admin/categoryNameById/{categoryId}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<Guid>>> GetCategoryNameById(Guid categoryId, CancellationToken cancellationToken) =>
        Ok(await _categoryService.GetCategoryNameById(categoryId, cancellationToken));

    [HttpGet("admin/{categoryId}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<Category?>>> GetAdminCategory(Guid categoryId, CancellationToken cancellationToken) =>
        Ok(await _categoryService.GetAdminCategory(categoryId, cancellationToken));

    [HttpPut("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<Category>>>> UpdateCategory(Category category, CancellationToken cancellationToken) =>
        Ok(await _categoryService.UpdateCategory(category, cancellationToken));
}