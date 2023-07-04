using System.ComponentModel.DataAnnotations;

namespace TrazinsAPI.Models;

public class Material
{
    [Key]
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public string? Tipo { get; set; }
}