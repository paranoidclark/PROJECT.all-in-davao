using DavaoCityExplorerAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DavaoCityExplorerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DavaoCityExplorerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CategoriesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryModel>>> GetCategories()
    {
        var categories = await _context.Categories
                                       .Include(c => c.Image)
                                       .ToListAsync();

        return Ok(categories);
    }
}
