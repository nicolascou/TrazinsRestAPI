using Microsoft.EntityFrameworkCore;

namespace TrazinsAPI.Data
{
    public class TrazinsAPIContext : DbContext
    {
        public TrazinsAPIContext(DbContextOptions<TrazinsAPIContext> options)
            : base(options)
        {
        }

        // public DbSet<TrazinsAPI.Models.Registro> Registro { get; set; } = default!;
        public DbSet<TrazinsAPI.Models.Material> Material { get; set; } = default!;
    }
}