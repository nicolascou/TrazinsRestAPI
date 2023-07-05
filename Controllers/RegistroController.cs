using Microsoft.AspNetCore.Mvc;
using TrazinsAPI.Data;
using TrazinsAPI.Models;

namespace TrazinsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistroController : ControllerBase
{
    private readonly TrazinsAPIContext _context;

    public RegistroController(TrazinsAPIContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult> Post(RegistroYMateriales registroYMateriales)
    {
        try
        {
            if (registroYMateriales.Registro is null || registroYMateriales.Materiales is null)
            {
                throw new Exception();
            }

            _context.Registro.Add(registroYMateriales.Registro ?? throw new ArgumentNullException(nameof(registroYMateriales.Registro)));
            await _context.SaveChangesAsync();

            foreach (Material material in registroYMateriales.Materiales)
            {
                _context.Registro_Materiales.Add(new Registro_Materiales
                {
                    ID_Registro = registroYMateriales.Registro.Id,
                    ID_Material = material.Id
                });
            }

            await _context.SaveChangesAsync();
            return Ok(registroYMateriales.Registro);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex);
        }
    }
}

public class RegistroYMateriales
{
    public Registro? Registro { get; set; }
    public Material[]? Materiales { get; set; }
}