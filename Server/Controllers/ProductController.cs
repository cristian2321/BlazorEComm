using BlazorEComm.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private EcomDbContext _context;

    public ProductController(EcomDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts(CancellationToken cancellationToken) =>
        Ok(await _context.Products.ToListAsync(cancellationToken));
}