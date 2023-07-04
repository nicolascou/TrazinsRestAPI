using Microsoft.EntityFrameworkCore;
using TrazinsAPI.Models;

namespace TrazinsAPI.Data
{
    public class TrazinsAPIContext : DbContext
    {
        public TrazinsAPIContext(DbContextOptions<TrazinsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Material> Material { get; set; } = default!;
        public DbSet<Registro> Registro { get; set; } = default!;
        public DbSet<Registro_Materiales> Registro_Materiales { get; set; } = default!;
    }
}