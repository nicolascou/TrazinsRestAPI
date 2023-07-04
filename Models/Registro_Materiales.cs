using System.ComponentModel.DataAnnotations;

namespace TrazinsAPI.Models
{
    public class Registro_Materiales
    {
        [Key]
        public int Id { get; set; }
        public int ID_Registro { get; set; }
        public int ID_Material { get; set; }
    }
}