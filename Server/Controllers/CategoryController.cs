using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories(CancellationToken cancellationToken) =>
            Ok(await _categoryService.GetCategories(cancellationToken));
    }
}
