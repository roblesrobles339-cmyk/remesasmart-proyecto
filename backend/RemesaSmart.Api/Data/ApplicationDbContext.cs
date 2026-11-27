using Microsoft.EntityFrameworkCore;

namespace RemesaSmart.Api.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        // Aqui estan definidos los Dbsets nuestas entidades
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Hogar> Hogares {get; set;}
        public DbSet<Categoria> Categorias {get; set;}
        public DbSet<Gasto> Gastos {get;set;}
    }
}