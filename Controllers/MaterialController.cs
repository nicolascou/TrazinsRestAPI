using Microsoft.AspNetCore.Mvc;
using TrazinsAPI.Data;
using TrazinsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TrazinsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MaterialController : ControllerBase
{
    private readonly TrazinsAPIContext _context;

    public MaterialController(TrazinsAPIContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Material>>> Get(string tipo = "all")
    {
        List<Material> materials;
        if (tipo == "all")
        {
            materials = await _context.Material.ToListAsync();
        }
        else
        {
            materials = await _context.Material.Where(m => m.Tipo == tipo).ToListAsync();
        }
        return Ok(materials);
    }
}