using Microsoft.AspNetCore.Mvc;
using TrazinsAPI.Data;
using TrazinsAPI.Models;

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
    public ActionResult<IEnumerable<Material>> Get(string tipo)
    {
        List<Material> materials;
        if (tipo == "all")
        {
            materials = _context.Material.ToList();
        }
        else
        {
            materials = _context.Material.Where(m => m.Tipo == tipo).ToList();
        }
        return Ok(materials);
    }
}