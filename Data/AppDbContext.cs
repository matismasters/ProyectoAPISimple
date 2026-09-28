using Microsoft.EntityFrameworkCore;
using ProyectoAPISimple.Models;

namespace ProyectoAPISimple.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Ejemplo> Ejemplos { get; set; }
    }
}
