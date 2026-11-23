using Microsoft.EntityFrameworkCore;

namespace RemesaSmart.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        // Aquei vamos a definir los Dbsets nuestas entidades
        public DbSet<Gasto> gastos {get; set;}
        
    }
}