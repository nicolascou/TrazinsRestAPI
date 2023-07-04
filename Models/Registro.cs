using System.ComponentModel.DataAnnotations;

namespace TrazinsAPI.Models;

public class Registro
{
    [Key]
    public int Id { get; set; }
    public string? Intervencion { get; set; }
    public string? Gabinete { get; set; }
    public string? NumeroHistoriaClinica { get; set; }
    public DateTime Fecha { get; set; }
}