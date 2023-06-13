using Microsoft.EntityFrameworkCore;

namespace proyecto.models
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<usuario> Usuario { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Oferta> Oferta { get; set; }

    }
}