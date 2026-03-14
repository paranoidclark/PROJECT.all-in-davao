using DavaoCityExplorerAPI.Data;
using DavaoCityExplorerAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DavaoCityExplorerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlacesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PlacesController(ApplicationDbContext context)
    {
        _context = context;
    }


    // Get all places
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PlaceModel>>> GetPlaces()
    {
        var places = await _context.Places
                                   .Include(p => p.Category)
                                   .Include(p => p.Image)
                                   .Include(p => p.PlaceTags)
                                        .ThenInclude(pt => pt.Tag)
                                   .ToListAsync();

        return Ok(places);
    }


    // Get specific place by ID
    [HttpGet("{id}")] 
    public async Task<ActionResult<PlaceModel>> GetPlace(int id)
    {
        var place = await _context.Places
                                   .Include(p => p.Category)
                                   .Include(p => p.Image)
                                   .Include(p => p.PlaceTags)
                                        .ThenInclude(pt => pt.Tag)
                                   .FirstOrDefaultAsync(p => p.PlaceID == id);

        if (place == null)
        {
            return NotFound();
        }

        return Ok(place);
    }
}
