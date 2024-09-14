using Microsoft.EntityFrameworkCore;
using PERROS2.Models;
namespace PERROS2.Services
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }

    }
}
